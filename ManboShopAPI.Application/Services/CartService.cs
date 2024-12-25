using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class CartService : ICartService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public CartService(
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<(IEnumerable<CartDto> cartDtos, MetaData metaData)> GetAllCartAsync(CartRequestParameters cartRequestParameters)
		{
			var carts = await _unitOfWork.CartRepository.FetchAllCartAsync(cartRequestParameters);
			_logger.LogInfo("Lấy danh sách giỏ hàng thành công");

			var cartDtos = _mapper.Map<IEnumerable<CartDto>>(carts);
			return (cartDtos, carts.MetaData);
		}



		public async Task<CartDto> CreateCartAsync(CartForCreateDto cartForCreateDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				if (cartForCreateDto.UserId == null && cartForCreateDto.SessionId == null)
				{
					_logger.LogError("UserId hoặc SessionId không được để trống");
					throw new CartBadRequestException("UserId hoặc SessionId không được để trống");
				}

				if (cartForCreateDto.UserId != null & cartForCreateDto.SessionId != null)
				{
					_logger.LogError("Chỉ được chọn một trong hai UserId hoặc SessionId");
					throw new CartBadRequestException("Chỉ được chọn một trong hai UserId hoặc SessionId");
				}

				if (cartForCreateDto.SessionId != null)
				{
					bool isCartExist = await _unitOfWork.CartRepository
						.IsCartExistsAsync(cartForCreateDto.SessionId);

					if (isCartExist)
					{
						_logger.LogError($"Giỏ hàng với SessionId {cartForCreateDto.SessionId} đã tồn tại");
						throw new CartBadRequestException($"Giỏ hàng với SessionId {cartForCreateDto.SessionId} đã tồn tại");
					}
				}

				if (cartForCreateDto.UserId != null)
				{
					var existingCart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(cartForCreateDto.UserId.Value, false);
					if (existingCart != null)
					{
						_logger.LogError($"Người dùng với UserId {cartForCreateDto.UserId} đã có giỏ hàng");
						throw new CartBadRequestException($"Người dùng với UserId {cartForCreateDto.UserId} đã có giỏ hàng");
					}
				}

				var cart = _mapper.Map<Cart>(cartForCreateDto);
				await _unitOfWork.CartRepository.AddAsync(cart);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo("Tạo giỏ hàng mới thành công");
				return _mapper.Map<CartDto>(cart);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError("Tạo giỏ hàng mới thất bại");
				throw;
			}
		}

		public async Task<CartDto> GetCartBySessionIdAsync(string sessionId)
		{
			var cart = await _unitOfWork.CartRepository.GetCartBySessionIdAsync(sessionId, true);
			if (cart == null)
			{
				_logger.LogError($"Không tìm thấy giỏ hàng với SessionId {sessionId}");
				throw new CartNotFoundException($"Không tìm thấy giỏ hàng với SessionId {sessionId}");
			}

			_logger.LogInfo($"Lấy thông tin giỏ hàng với SessionId {sessionId} thành công");
			return _mapper.Map<CartDto>(cart);
		}

		public async Task<CartDto> GetCartByUserIdAsync(int userId)
		{
			var cart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId, true);
			if (cart == null)
			{
				_logger.LogError($"Không tìm thấy giỏ hàng với UserId {userId}");
				throw new CartNotFoundException($"Không tìm thấy giỏ hàng với UserId {userId}");
			}

			_logger.LogInfo($"Lấy thông tin giỏ hàng với UserId {userId} thành công");
			return _mapper.Map<CartDto>(cart);
		}

		public async Task<IEnumerable<CartDto>> GetAllCartsAsync()
		{
			var carts = await _unitOfWork.CartRepository.GetCartsWithItemsAsync();
			_logger.LogInfo("Lấy danh sách tất cả giỏ hàng thành công");
			return _mapper.Map<IEnumerable<CartDto>>(carts);
		}

		public async Task ClearCartAsync(int cartId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				await _unitOfWork.CartRepository.ClearCartAsync(cartId);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Xóa tất cả sản phẩm trong giỏ hàng {cartId} thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task MergeCartsAsync(int sourceCartId, int destinationCartId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				if (sourceCartId == destinationCartId)
				{
					_logger.LogError("Không thể gộp giỏ hàng với chính nó");
					throw new CartBadRequestException("Không thể gộp giỏ hàng với chính nó");
				}

				var sourceCart = await _unitOfWork.CartRepository.GetByIdAsync(sourceCartId);

				if (sourceCart == null)
				{
					_logger.LogError($"Không tìm thấy giỏ hàng nguồn với Id {sourceCartId}");
					throw new CartNotFoundException($"Không tìm thấy giỏ hàng nguồn với Id {sourceCartId}");
				}

				var destinationCart = await _unitOfWork.CartRepository.GetByIdAsync(destinationCartId);

				if (destinationCart == null)
				{
					_logger.LogError($"Không tìm thấy giỏ hàng đích với Id {destinationCartId}");
					throw new CartNotFoundException($"Không tìm thấy giỏ hàng đích với Id {destinationCartId}");
				}

				await _unitOfWork.CartRepository.MergeCartsAsync(sourceCartId, destinationCartId);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Gộp giỏ hàng {sourceCartId} vào giỏ hàng {destinationCartId} thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task<decimal> GetCartTotalAsync(int cartId)
		{
			var total = await _unitOfWork.CartRepository.GetCartTotalAsync(cartId);
			_logger.LogInfo($"Tính tổng giá trị giỏ hàng {cartId} thành công");
			return total;
		}

		public async Task<int> GetCartItemsCountAsync(int cartId)
		{
			var count = await _unitOfWork.CartRepository.GetCartItemsCountAsync(cartId);
			_logger.LogInfo($"Lấy số lượng sản phẩm trong giỏ hàng {cartId} thành công");
			return count;
		}

		public async Task AssignCartToUserAsync(int cartId, int userId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				await _unitOfWork.CartRepository.AssignCartToUserAsync(cartId, userId);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Gán giỏ hàng {cartId} cho người dùng {userId} thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task UpdateCartSessionAsync(int cartId, string newSessionId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				await _unitOfWork.CartRepository.UpdateCartSessionAsync(cartId, newSessionId);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Cập nhật SessionId mới {newSessionId} cho giỏ hàng {cartId} thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task<OrderDto> CheckoutCart(int cartId, OrderForCreateDto orderForCreateDto)
		{

			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var cart = await _unitOfWork.CartRepository
								.FindByCondition(c => c.Id == cartId)
								.Include(c => c.CartItems)
								.ThenInclude(ci => ci.Product)
								.FirstOrDefaultAsync()
								;

				if (cart == null)
				{
					_logger.LogError($"Không tìm thấy giỏ hàng với Id {cartId}");
					throw new CartNotFoundException($"Không tìm thấy giỏ hàng với Id {cartId}", false);
				}

				if (cart.CartItems.Count == 0)
				{
					_logger.LogError($"Giỏ hàng {cartId} không có sản phẩm nào");
					throw new CartBadRequestException($"Giỏ hàng {cartId} không có sản phẩm nào");
				}

				var order = _mapper.Map<Order>(orderForCreateDto);

				if (orderForCreateDto.Total == null)
				{
					order.Total = await GetCartTotalAsync(cartId);
				}

				await _unitOfWork.OrderRepository.AddAsync(order);
				await _unitOfWork.SaveChangesAsync();
				_logger.LogInfo($"Tạo đơn hàng mới thành công");

				foreach (var cartItem in cart.CartItems)
				{
					var orderItem = new OrderDetail
					{
						OrderId = order.Id,
						ProductId = cartItem.ProductId,
						Quantity = cartItem.Quantity,
						Price = cartItem.Product.Price
					};

					await _unitOfWork.OrderDetailRepository.AddAsync(orderItem);
				}
				_logger.LogInfo($"Thêm sản phẩm vào đơn hàng {order.Id} thành công");
				await _unitOfWork.CartRepository.ClearCartAsync(cartId);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Đặt hàng thành công từ giỏ hàng {cartId}");
				return _mapper.Map<OrderDto>(order);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError("Đặt hàng thất bại");
				throw;
			}
		}
	}
}
