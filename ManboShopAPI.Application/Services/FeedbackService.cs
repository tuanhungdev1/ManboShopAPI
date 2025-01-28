using AutoMapper;
using ManboShopAPI.Application.DTOs.FeedbackDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class FeedbackService : IFeedbackService
	{
		private readonly IFeedbackRepository _feedbackRepository;
		private readonly IProductRepository _productRepository;
		private readonly IUserRepository _userRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public FeedbackService(
			IFeedbackRepository feedbackRepository,
			IProductRepository productRepository,
			IUserRepository userRepository,
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_feedbackRepository = feedbackRepository;
			_productRepository = productRepository;
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<IEnumerable<FeedbackDto>> GetAllFeedbacksAsync()
		{
			var feedbacks = await _feedbackRepository.GetAllAsync(true);
			_logger.LogInfo("Lấy danh sách đánh giá thành công");
			return _mapper.Map<IEnumerable<FeedbackDto>>(feedbacks);
		}

		public async Task<FeedbackDto> GetFeedbackByIdAsync(int id)
		{
			var feedback = await _feedbackRepository.GetFeedbackWithDetailsAsync(id);
			if (feedback == null)
			{
				_logger.LogError($"Không tìm thấy đánh giá với id {id}");
				throw new FeedbackNotFoundException(id);
			}

			_logger.LogInfo($"Lấy thông tin đánh giá với id {id} thành công");
			return _mapper.Map<FeedbackDto>(feedback);
		}

		public async Task<IEnumerable<FeedbackDto>> GetFeedbacksByProductIdAsync(int productId)
		{
			if (!await _productRepository.ProductExistsAsync(productId))
			{
				_logger.LogError($"Không tìm thấy sản phẩm với id {productId}");
				throw new ProductNotFoundException(productId);
			}

			var feedbacks = await _feedbackRepository.GetFeedbacksByProductIdAsync(productId);
			_logger.LogInfo($"Lấy danh sách đánh giá cho sản phẩm id {productId} thành công");
			return _mapper.Map<IEnumerable<FeedbackDto>>(feedbacks);
		}

		public async Task<IEnumerable<FeedbackDto>> GetFeedbacksByUserIdAsync(int userId)
		{
			if (!await _userRepository.UserExistsAsync(userId))
			{
				_logger.LogError($"Không tìm thấy người dùng với id {userId}");
				throw new UserNotFoundException(userId);
			}

			var feedbacks = await _feedbackRepository.GetFeedbacksByUserIdAsync(userId);
			_logger.LogInfo($"Lấy danh sách đánh giá của người dùng id {userId} thành công");
			return _mapper.Map<IEnumerable<FeedbackDto>>(feedbacks);
		}

		public async Task<IEnumerable<FeedbackDto>> GetFeedbacksByStarRatingAsync(int rating)
		{
			if (rating < 0 || rating > 5)
			{
				_logger.LogError($"Số sao đánh giá không hợp lệ: {rating}");
				throw new FeedbackBadRequestException("Số sao đánh giá phải từ 0 đến 5");
			}

			var feedbacks = await _feedbackRepository.GetFeedbacksByStarRatingAsync(rating);
			_logger.LogInfo($"Lấy danh sách đánh giá {rating} sao thành công");
			return _mapper.Map<IEnumerable<FeedbackDto>>(feedbacks);
		}

		public async Task<double> GetAverageStarRatingForProductAsync(int productId)
		{
			if (!await _productRepository.ProductExistsAsync(productId))
			{
				_logger.LogError($"Không tìm thấy sản phẩm với id {productId}");
				throw new ProductNotFoundException(productId);
			}

			var averageRating = await _feedbackRepository.GetAverageStarRatingForProductAsync(productId);
			_logger.LogInfo($"Lấy điểm đánh giá trung bình của sản phẩm id {productId} thành công");
			return averageRating;
		}

		public async Task<FeedbackDto> CreateFeedbackAsync(FeedbackForCreateDto feedbackDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				await ValidateFeedbackData(feedbackDto);

				// Kiểm tra xem người dùng đã đánh giá sản phẩm này chưa
				if (await _feedbackRepository.UserHasFeedbackForProductAsync(feedbackDto.UserId, feedbackDto.ProductId))
				{
					throw new FeedbackBadRequestException("Người dùng đã đánh giá sản phẩm này");
				}

				var feedback = _mapper.Map<Feedback>(feedbackDto);
				await _feedbackRepository.AddAsync(feedback);
				await _feedbackRepository.SaveChangesAsync();

				var createdFeedback = await _feedbackRepository.GetFeedbackWithDetailsAsync(feedback.Id);

				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Tạo đánh giá mới thành công cho sản phẩm id {feedbackDto.ProductId}");
				return _mapper.Map<FeedbackDto>(createdFeedback);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError("Tạo đánh giá mới thất bại");
				throw;
			}
		}

		public async Task<FeedbackDto> UpdateFeedbackAsync(int id, FeedbackForUpdateDto feedbackDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var existingFeedback = await _feedbackRepository.FindByCondition(fb => fb.Id == id)
										.FirstOrDefaultAsync();
					;
				if (existingFeedback == null)
				{
					throw new FeedbackNotFoundException(id);
				}

				_mapper.Map(feedbackDto, existingFeedback);
				_feedbackRepository.Update(existingFeedback);
				await _feedbackRepository.SaveChangesAsync();

				var updatedFeedback = await _feedbackRepository.GetFeedbackWithDetailsAsync(id);

				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Cập nhật đánh giá id {id} thành công");
				return _mapper.Map<FeedbackDto>(updatedFeedback);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Cập nhật đánh giá id {id} thất bại");
				throw;
			}
		}

		public async Task DeleteFeedbackAsync(int id)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var feedback = await _feedbackRepository.GetByIdAsync(id);
				if (feedback == null)
				{
					throw new FeedbackNotFoundException(id);
				}

				_feedbackRepository.Remove(feedback);
				await _feedbackRepository.SaveChangesAsync();

				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Xóa đánh giá id {id} thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Xóa đánh giá id {id} thất bại");
				throw;
			}
		}

		private async Task ValidateFeedbackData(FeedbackForCreateDto feedbackDto)
		{
			if (!await _userRepository.UserExistsAsync(feedbackDto.UserId))
			{
				throw new UserNotFoundException(feedbackDto.UserId);
			}

			if (!await _productRepository.ProductExistsAsync(feedbackDto.ProductId))
			{
				throw new ProductNotFoundException(feedbackDto.ProductId);
			}

			if (feedbackDto.Star < 0 || feedbackDto.Star > 5)
			{
				throw new FeedbackBadRequestException("Số sao đánh giá phải từ 0 đến 5");
			}

			if (string.IsNullOrWhiteSpace(feedbackDto.Content))
			{
				throw new FeedbackBadRequestException("Nội dung đánh giá không được để trống");
			}
		}
	}
}