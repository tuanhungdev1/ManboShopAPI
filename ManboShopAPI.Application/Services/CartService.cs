using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.CartItemDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;
using ManboShopAPI.Domain.Enums;


public class CartService : ICartService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILoggerService _logger;
	private readonly IEmailSender _emailSender;

	public CartService(
		IEmailSender emailSender,
		IUnitOfWork unitOfWork,
		IMapper mapper,
		ILoggerService logger)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
		_emailSender = emailSender;
	}

	public async Task<bool> EnsureCartExists(string sessionId)
	{
		if (string.IsNullOrEmpty(sessionId)) return false;

		var cart = await _unitOfWork.CartRepository
			.FindByCondition(c => c.SessionId == sessionId).FirstOrDefaultAsync();

		if (cart == null)
		{
			cart = new Cart
			{
				SessionId = sessionId,
				CreatedAt = DateTime.UtcNow
			};
			await _unitOfWork.CartRepository.AddAsync(cart);
			await _unitOfWork.SaveChangesAsync();
		}

		return true;
	}

	public async Task<CartDto> GetCartBySessionIdAsync(string sessionId)
	{
		var cart = await _unitOfWork.CartRepository.GetCartBySessionIdAsync(sessionId, true);
		if (cart == null)
			throw new CartNotFoundException($"Không tìm thấy giỏ hàng với SessionId {sessionId}");

		return _mapper.Map<CartDto>(cart);
	}

	public async Task<CartDto> GetCartByUserIdAsync(int userId)
	{
		var cart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId, true);
		if (cart == null)
			throw new CartNotFoundException($"Không tìm thấy giỏ hàng của người dùng {userId}", false);

		return _mapper.Map<CartDto>(cart);
	}
	public async Task<CartDto> GetOrCreateCartByUserAsync(int userId)
	{
		var cart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId, true);

		if (cart == null)
		{
			_logger.LogInfo($"Creating new cart for user {userId}");
			cart = new Cart
			{
				UserId = userId,
				CreatedAt = DateTime.UtcNow
			};
			await _unitOfWork.CartRepository.AddAsync(cart);
			await _unitOfWork.SaveChangesAsync();
		}

		return _mapper.Map<CartDto>(cart);
	}
	public async Task<CartDto> GetOrCreateCartBySessionAsync(string sessionId)
	{
		var cart = await _unitOfWork.CartRepository.GetCartBySessionIdAsync(sessionId, true);

		if (cart == null)
		{
			_logger.LogInfo($"Creating new cart for session {sessionId}");
			cart = new Cart
			{
				SessionId = sessionId,
				CreatedAt = DateTime.UtcNow
			};
			await _unitOfWork.CartRepository.AddAsync(cart);
			await _unitOfWork.SaveChangesAsync();
		}

		return _mapper.Map<CartDto>(cart);
	}

	public async Task<CartDto> CreateCartAsync(CartForCreateDto cartDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			if (cartDto.UserId == null && cartDto.SessionId == null)
				throw new CartBadRequestException("UserId hoặc SessionId không được để trống");

			if (cartDto.UserId != null && cartDto.SessionId != null)
				throw new CartBadRequestException("Chỉ được chọn một trong hai UserId hoặc SessionId");

			// Kiểm tra cart tồn tại
			if (cartDto.SessionId != null)
			{
				var existingSessionCart = await _unitOfWork.CartRepository.GetCartBySessionIdAsync(cartDto.SessionId);
				if (existingSessionCart != null)
					throw new CartBadRequestException($"Giỏ hàng với SessionId {cartDto.SessionId} đã tồn tại");
			}

			if (cartDto.UserId != null)
			{
				var existingUserCart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(cartDto.UserId.Value);
				if (existingUserCart != null)
					throw new CartBadRequestException($"Người dùng {cartDto.UserId} đã có giỏ hàng");
			}

			var cart = _mapper.Map<Cart>(cartDto);
			await _unitOfWork.CartRepository.AddAsync(cart);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			return _mapper.Map<CartDto>(cart);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<bool> DoesCartExistAsync(string sessionId) { 
		return await _unitOfWork.CartRepository.IsCartExistsAsync(sessionId);
	}

	public async Task DeleteCartAsync(int cartId)
	{
		var cart = await _unitOfWork.CartRepository.GetByIdAsync(cartId);
		if (cart == null)
			throw new CartNotFoundException($"Không tìm thấy giỏ hàng {cartId}");

		_unitOfWork.CartRepository.Remove(cart);
		await _unitOfWork.SaveChangesAsync();
	}

	public async Task<CartItemDto> AddItemToCartAsync(int cartId, CartItemForCreateDto cartItemDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var cart = await _unitOfWork.CartRepository.FindByCondition(c => c.Id == cartId, true)
													 .Include(c => c.CartItems)
													 .AsTracking()
													 .FirstOrDefaultAsync();
			if (cart == null)
				throw new CartNotFoundException($"Không tìm thấy giỏ hàng {cartId}");

			var productVariant = await _unitOfWork.ProductVariantValueRepository
				.FindByCondition(pv => pv.Id == cartItemDto.ProductVariantValueId && pv.ProductId == cartItemDto.ProductId)
				.FirstOrDefaultAsync();

			if (productVariant == null)
				throw new CartNotFoundException($"Không tìm thấy biến thể sản phẩm");

			if (productVariant.Stock < cartItemDto.Quantity)
				throw new CartBadRequestException($"Số lượng sản phẩm trong kho không đủ");

			var existingItem = cart.CartItems.FirstOrDefault(ci =>
				ci.ProductVariantValueId == cartItemDto.ProductVariantValueId);

			if (existingItem != null)
			{
				existingItem.Quantity += cartItemDto.Quantity;
				_unitOfWork.CartRepository.Update(cart);
			}
			else
			{
				var cartItem = new CartItem
				{
					CartId = cartId,
					ProductVariantValueId = cartItemDto.ProductVariantValueId,
					Quantity = cartItemDto.Quantity
				};
				cart.CartItems.Add(cartItem);
			}

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			var updatedItem = cart.CartItems.First(ci =>
				ci.ProductVariantValueId == cartItemDto.ProductVariantValueId);
			return _mapper.Map<CartItemDto>(updatedItem);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}
	public async Task<CartItemDto> UpdateCartItemAsync(int cartId, int cartItemId, CartItemForUpdateDto cartItemDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var cart = await _unitOfWork.CartRepository.FindByCondition(c => c.Id == cartId)
													 .Include(c => c.CartItems)
													 .ThenInclude(ci => ci.ProductVariantValue)
													 .FirstOrDefaultAsync();
			if (cart == null)
				throw new CartNotFoundException($"Không tìm thấy giỏ hàng {cartId}");

			var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == cartItemId);
			if (cartItem == null)
				throw new CartNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng");

			if (cartItem.ProductVariantValue.Stock < cartItemDto.Quantity)
				throw new CartBadRequestException($"Số lượng sản phẩm trong kho không đủ");

			cartItem.Quantity = cartItemDto.Quantity;

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			return _mapper.Map<CartItemDto>(cartItem);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}
	public async Task RemoveCartItemAsync(int cartId, int cartItemId)
	{
		var cart = await _unitOfWork.CartRepository.FindByCondition(c => c.Id == cartId)
												 .Include(c => c.CartItems)
												 .FirstOrDefaultAsync();
		if (cart == null)
			throw new CartNotFoundException($"Không tìm thấy giỏ hàng {cartId}");

		var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == cartItemId);
		if (cartItem == null)
			throw new CartNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng");

		cart.CartItems.Remove(cartItem);
		await _unitOfWork.SaveChangesAsync();
	}

	public async Task<IEnumerable<CartItemDto>> GetCartItemsAsync(int cartId)
	{
		var cart = await _unitOfWork.CartRepository.FindByCondition(c => c.Id == cartId)
												 .Include(c => c.CartItems)
												 .ThenInclude(ci => ci.ProductVariantValue)
												 .ThenInclude(pvv => pvv.Product)
												 .FirstOrDefaultAsync();
		if (cart == null)
			throw new CartNotFoundException($"Không tìm thấy giỏ hàng {cartId}");

		return _mapper.Map<IEnumerable<CartItemDto>>(cart.CartItems);
	}

	public async Task<decimal> GetCartTotalAsync(int cartId)
	{
		return await _unitOfWork.CartRepository.GetCartTotalAsync(cartId);
	}

	public async Task<int> GetCartItemsCountAsync(int cartId)
	{
		return await _unitOfWork.CartRepository.GetCartItemsCountAsync(cartId);
	}

	public async Task AssignCartToUserAsync(int cartId, int userId)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var existingUserCart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId);
			if (existingUserCart != null)
				throw new CartBadRequestException($"Người dùng {userId} đã có giỏ hàng");

			await _unitOfWork.CartRepository.AssignCartToUserAsync(cartId, userId);
			await _unitOfWork.CommitAsync();
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task MergeSessionCartToUserCart(string sessionId, int userId)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var sessionCart = await _unitOfWork.CartRepository
				.GetCartBySessionIdAsync(sessionId, true);

			if (sessionCart == null || !sessionCart.CartItems.Any())
			{
				return;
			}

			var userCart = await GetOrCreateCartByUserAsync(userId);

			foreach (var item in sessionCart.CartItems)
			{
				var existingItem = userCart.CartItems
					.FirstOrDefault(ci => ci.ProductVariantValueId == item.ProductVariantValueId);

				if (existingItem != null)
				{
					existingItem.Quantity += item.Quantity;
				}
				else
				{
					var newItem = new CartItem
					{
						CartId = userCart.Id,
						ProductVariantValueId = item.ProductVariantValueId,
						Quantity = item.Quantity
					};
					await _unitOfWork.CartItemRepository.AddAsync(newItem);
				}
			}

			// Xóa session cart sau khi merge
			await DeleteCartAsync(sessionCart.Id);

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<OrderDto> CheckoutCartAsync(int userId, OrderForCreateDto orderForCreateDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var user = await _unitOfWork.UserRepository.FindByCondition(u => u.Id == userId)
														.Include(u => u.Addresses)
														.FirstOrDefaultAsync();
														
			if (user == null)
				throw new UserNotFoundException($"Không tìm thấy người dùng {userId}");

			var cart = await _unitOfWork.CartRepository.FindByCondition(c => c.Id == orderForCreateDto.CartId)
													 .AsTracking()
													 .Include(c => c.CartItems)
													 .ThenInclude(ci => ci.ProductVariantValue)
													 .ThenInclude(pvv => pvv.Product)
													 .FirstOrDefaultAsync();

			if (cart == null)
				throw new CartNotFoundException($"Không tìm thấy giỏ hàng {orderForCreateDto.CartId}");

			if (!cart.CartItems.Any())
				throw new CartBadRequestException("Giỏ hàng trống");

			var addressForUser = await _unitOfWork.AddressRepository.GetByIdAsync(orderForCreateDto.AddressId);
			if(addressForUser == null)
				throw new AddressNotFoundException($"Không tìm thấy địa chỉ {orderForCreateDto.AddressId}");

			// Kiểm tra số lượng tồn kho
			foreach (var item in cart.CartItems)
			{
				if (item.ProductVariantValue.Stock < item.Quantity)
					throw new CartBadRequestException(
						$"Sản phẩm {item.ProductVariantValue.Product.Name} - SKU: {item.ProductVariantValue.Sku} không đủ số lượng trong kho");
			}
			
			decimal subTotal = await GetCartTotalAsync(orderForCreateDto.CartId);
			decimal shippingFee = 14000;

			var orderAddress = new OrderAddress
			{
				Name = addressForUser.Name,
				PhoneNumber = addressForUser.PhoneNumber,
				AddressLine = addressForUser.AddressLine,
				City = addressForUser.City,
				State = addressForUser.State,
				Country = addressForUser.Country,
				PostalCode = addressForUser.PostalCode
			};

			var order = new Order
			{
				UserId = userId,
				ShippingAddress = orderAddress,
				PaymentMethod = orderForCreateDto.PaymentMethod,
				Note = orderForCreateDto.Note,
				Status = OrderStatus.Pending,
				SubTotal = subTotal,
				ShippingFee = shippingFee,
				Total = subTotal + shippingFee,
				PaymentStatus = PaymentStatus.Pending,
			};

			await _unitOfWork.OrderRepository.AddAsync(order);
			await _unitOfWork.SaveChangesAsync();
			// Tạo chi tiết đơn hàng
			foreach (var item in cart.CartItems)
			{
				var orderDetail = new OrderDetail
				{
					OrderId = order.Id,
					ProductVariantValueId = item.ProductVariantValueId,
					Quantity = item.Quantity,
					Price = item.ProductVariantValue.Price
				};
				await _unitOfWork.OrderDetailRepository.AddAsync(orderDetail);

				if(item.ProductVariantValue.Stock < item.Quantity)
					throw new CartBadRequestException(
						$"Sản phẩm {item.ProductVariantValue.Product.Name} - SKU: {item.ProductVariantValue.Sku} không đủ số lượng trong kho");
				// Cập nhật số lượng trong kho
				item.ProductVariantValue.Stock -= item.Quantity;
				_unitOfWork.ProductVariantValueRepository.Update(item.ProductVariantValue);
			}

			// Xóa giỏ hàng
			await _unitOfWork.CartRepository.ClearCartAsync(orderForCreateDto.CartId);
			await _unitOfWork.CommitAsync();

			try
			{
				await _emailSender.SendOrderConfirmationEmailAsync(order);
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to send order confirmation email: {ex.Message}");
				// Không throw exception vì đơn hàng vẫn được tạo thành công
			}

			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			_logger.LogError("Lỗi khi tạo đơn hàng");
			throw;
		}
	}

	public async Task ClearCartAsync(int cartId)
	{
		await _unitOfWork.CartRepository.ClearCartAsync(cartId);
	}
}