using AutoMapper;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.DTOs.CartItemDtos;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Application.Contracts;

namespace ManboShopAPI.Application.Services
{
	public class CartItemService : ICartItemService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public CartItemService(
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<CartItemDto> AddItemToCartAsync(CartItemForCreateDto cartItemForCreateDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var exitsingCart = await _unitOfWork.CartRepository.GetByIdAsync(cartItemForCreateDto.CartId);

				if (exitsingCart == null)
				{
					_logger.LogError($"Không tìm thấy giỏ hàng với Id {cartItemForCreateDto.CartId}");
					throw new CartNotFoundException($"Không tìm thấy giỏ hàng");
				}

				var exitsingProduct = await _unitOfWork.ProductRepository.GetByIdAsync(cartItemForCreateDto.ProductId);

				if (exitsingProduct == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với Id {cartItemForCreateDto.ProductId}");
					throw new ProductNotFoundException($"Không tìm thấy sản phẩm");
				}

				var isProductAvailable = await _unitOfWork.CartItemRepository
					.IsStockAvailableAsync(cartItemForCreateDto.ProductId, cartItemForCreateDto.Quantity);

				if (!isProductAvailable)
				{
					_logger.LogError($"Sản phẩm với Id {cartItemForCreateDto.ProductId} không đủ số lượng trong kho");
					throw new CartItemBadRequestException($"Sản phẩm không đủ số lượng trong kho");
				}

				var existingItem = await _unitOfWork.CartItemRepository
					.GetCartItemAsync(cartItemForCreateDto.CartId, cartItemForCreateDto.ProductId);

				if (existingItem != null)
				{
					var totalQuantity = existingItem.Quantity + cartItemForCreateDto.Quantity;

					var isStockAvailable = await _unitOfWork.CartItemRepository
						.IsStockAvailableAsync(cartItemForCreateDto.ProductId, totalQuantity);

					if (!isStockAvailable)
					{
						_logger.LogError($"Sản phẩm với Id {cartItemForCreateDto.ProductId} không đủ số lượng trong kho");
						throw new CartItemBadRequestException($"Sản phẩm không đủ số lượng trong kho");
					}

					existingItem.Quantity += cartItemForCreateDto.Quantity;
					_unitOfWork.CartItemRepository.Update(existingItem);
				}
				else
				{
					var cartItem = _mapper.Map<CartItem>(cartItemForCreateDto);
					await _unitOfWork.CartItemRepository.AddAsync(cartItem);
					existingItem = cartItem;
				}

				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo("Thêm sản phẩm vào giỏ hàng thành công");
				return _mapper.Map<CartItemDto>(existingItem);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError("Thêm sản phẩm vào giỏ hàng thất bại");
				throw;
			}
		}

		public async Task<IEnumerable<CartItemDto>> GetCartItemsByCartIdAsync(int cartId)
		{
			var cart = await _unitOfWork.CartRepository.GetByIdAsync(cartId);

			if (cart == null)
			{
				_logger.LogError($"Không tìm thấy giỏ hàng với Id {cartId}");
				throw new CartNotFoundException($"Không tìm thấy giỏ hàng", false);
			}

			var cartItems = await _unitOfWork.CartItemRepository.GetCartItemsByCartIdAsync(cartId, true);
			_logger.LogInfo($"Lấy danh sách sản phẩm trong giỏ hàng {cartId} thành công");
			return _mapper.Map<IEnumerable<CartItemDto>>(cartItems);
		}

		public async Task UpdateCartItemQuantityAsync(int cartItemId, int quantity)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var cartItem = await _unitOfWork.CartItemRepository.GetByIdAsync(cartItemId);
				if (cartItem == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm trong giỏ hàng với Id {cartItemId}");
					throw new CartItemNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng");
				}

				var isStockAvailable = await _unitOfWork.CartItemRepository
					.IsStockAvailableAsync(cartItem.ProductId, quantity);

				if (!isStockAvailable)
				{
					_logger.LogError("Số lượng sản phẩm trong kho không đủ");
					throw new CartItemBadRequestException("Số lượng sản phẩm trong kho không đủ");
				}

				await _unitOfWork.CartItemRepository.UpdateQuantityAsync(cartItemId, quantity);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Cập nhật số lượng sản phẩm trong giỏ hàng thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task RemoveCartItemAsync(int cartId, int productId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var isProductInCart = await _unitOfWork.CartItemRepository.IsProductInCartAsync(cartId, productId);

				if (!isProductInCart)
				{
					_logger.LogError($"Không tìm thấy sản phẩm trong giỏ hàng với CartId {cartId} và ProductId {productId}");
					throw new CartItemNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng");
				}

				var cartItem = await _unitOfWork.CartItemRepository.GetCartItemAsync(cartId, productId);

				if (cartItem == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm trong giỏ hàng với CartId {cartId} và ProductId {productId}");
					throw new CartItemNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng");
				}

				await _unitOfWork.CartItemRepository.RemoveCartItemAsync(cartId, productId);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Xóa sản phẩm khỏi giỏ hàng thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task<decimal> GetCartItemSubtotalAsync(int cartItemId)
		{
			var cartItem = await _unitOfWork.CartItemRepository.GetByIdAsync(cartItemId);

			if (cartItem == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm trong giỏ hàng với Id {cartItemId}");
				throw new CartItemNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng");
			}

			var subtotal = await _unitOfWork.CartItemRepository.GetCartItemSubtotalAsync(cartItemId);
			_logger.LogInfo($"Tính tổng giá trị sản phẩm trong giỏ hàng thành công");
			return subtotal;
		}

		public async Task BulkUpdateQuantitiesAsync(IEnumerable<(int CartItemId, int NewQuantity)> updates)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				foreach (var update in updates)
				{
					var cartItem = await _unitOfWork.CartItemRepository.GetByIdAsync(update.CartItemId);
					if (cartItem == null)
					{
						throw new CartItemNotFoundException($"Không tìm thấy sản phẩm trong giỏ hàng với Id {update.CartItemId}");
					}

					var isStockAvailable = await _unitOfWork.CartItemRepository
						.IsStockAvailableAsync(cartItem.ProductId, update.NewQuantity);

					if (!isStockAvailable)
					{
						throw new CartItemBadRequestException($"Số lượng sản phẩm trong kho không đủ cho CartItemId {update.CartItemId}");
					}
				}

				await _unitOfWork.CartItemRepository.BulkUpdateQuantitiesAsync(updates);
				await _unitOfWork.CommitAsync();

				_logger.LogInfo("Cập nhật số lượng hàng loạt thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}
	}
}