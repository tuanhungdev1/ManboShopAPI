using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.FeedbackDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
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
		private readonly IFeedbackLikeRepository _feedbackLikeRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public FeedbackService(
			IFeedbackRepository feedbackRepository,
			IFeedbackLikeRepository feedbackLikeRepository,
			IProductRepository productRepository,
			IUserRepository userRepository,
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_feedbackRepository = feedbackRepository;
			_feedbackLikeRepository = feedbackLikeRepository;
			_productRepository = productRepository;
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<(IEnumerable<FeedbackDto> feedbacks, MetaData metaData)> GetAllFeedbacksAsync(FeedbackRequestParameters feedbackRequestParameters)
		{
			var feedbacks = await _feedbackRepository.GetAllFeedbackAsync(feedbackRequestParameters);
			_logger.LogInfo("Lấy danh sách đánh giá thành công");
			var feedbackDtos = _mapper.Map<IEnumerable<FeedbackDto>>(feedbacks);
			return (feedbackDtos, feedbacks.MetaData);
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

		public async Task<(IEnumerable<FeedbackDto> feedbackDtos, MetaData metaData)> GetFeedbacksByProductIdAsync(
	int productId,
	FeedbackRequestParameters feedbackRequestParameters,
	int? currentUserId = null) // Thêm parameter này
		{
			if (!await _productRepository.ProductExistsAsync(productId))
			{
				_logger.LogError($"Không tìm thấy sản phẩm với id {productId}");
				throw new ProductNotFoundException(productId);
			}

			var feedbacks = await _feedbackRepository.GetFeedbacksByProductIdAsync(productId, feedbackRequestParameters);
			_logger.LogInfo($"Lấy danh sách đánh giá cho sản phẩm id {productId} thành công");

			var feedbackDtos = _mapper.Map<IEnumerable<FeedbackDto>>(feedbacks);

			foreach (var feedbackDto in feedbackDtos)
			{
				feedbackDto.TotalLikes = await _feedbackRepository.GetFeedbackLikesCountAsync(feedbackDto.Id);

				// Kiểm tra trạng thái like nếu có currentUserId
				if (currentUserId.HasValue)
				{
					feedbackDto.IsLiked = await _feedbackRepository.IsLikedByUserAsync(feedbackDto.Id, currentUserId.Value);
				}
				else
				{
					feedbackDto.IsLiked = false;
				}
			}

			return (feedbackDtos, metaData: feedbacks.MetaData);
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

		public async Task<FeedbackDto> CreateFeedbackAsync(int userId, FeedbackForCreateDto feedbackDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				await ValidateFeedbackData(feedbackDto);

				if (!await _userRepository.UserExistsAsync(userId))
				{
					throw new UserNotFoundException(userId);
				}

				var feedback = _mapper.Map<Feedback>(feedbackDto);

				feedback.UserId = userId;
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

				var feedback = await _feedbackRepository.FindByCondition(f => f.Id == id).AsTracking().Include(f => f.FeedbackLikes).FirstOrDefaultAsync();
				if (feedback == null)
				{
					throw new FeedbackNotFoundException(id);
				}

				foreach (var like in feedback.FeedbackLikes)
				{
					_feedbackLikeRepository.Remove(like);
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


		public async Task<FeedbackLikeDto> LikeFeedbackAsync(int feedbackId, int userId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var feedback = await _unitOfWork.FeedbackRepository.GetByIdAsync(feedbackId);
				if (feedback == null)
					throw new FeedbackNotFoundException($"Không tìm thấy đánh giá {feedbackId}");

				var existingLike = await _unitOfWork.FeedbackLikeRepository
					.FindByCondition(l => l.FeedbackId == feedbackId && l.UserId == userId)
					.FirstOrDefaultAsync();

				if (existingLike != null)
					throw new FeedbackBadRequestException("Bạn đã thích đánh giá này rồi");

				var like = new FeedbackLike
				{
					FeedbackId = feedbackId,
					UserId = userId
				};

				await _unitOfWork.FeedbackLikeRepository.AddAsync(like);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				return _mapper.Map<FeedbackLikeDto>(like);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}


		public async Task UnlikeFeedbackAsync(int feedbackId, int userId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var like = await _unitOfWork.FeedbackLikeRepository
					.FindByCondition(l => l.FeedbackId == feedbackId && l.UserId == userId)
					.FirstOrDefaultAsync();

				if (like == null)
					throw new FeedbackNotFoundException("Không tìm thấy lượt thích");

				_unitOfWork.FeedbackLikeRepository.Remove(like);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}


		public async Task<bool> HasUserLikedFeedbackAsync(int feedbackId, int userId)
		{
			return await _unitOfWork.FeedbackLikeRepository
				.FindByCondition(l => l.FeedbackId == feedbackId && l.UserId == userId)
				.AnyAsync();
		}

		public async Task<int> GetFeedbackLikesCountAsync(int feedbackId)
		{
			return await _unitOfWork.FeedbackLikeRepository
				.FindByCondition(l => l.FeedbackId == feedbackId)
				.CountAsync();
		}

		public async Task<IEnumerable<FeedbackLikeDto>> GetFeedbackLikesAsync(int feedbackId)
		{
			var likes = await _unitOfWork.FeedbackLikeRepository
				.FindByCondition(l => l.FeedbackId == feedbackId)
				.Include(l => l.User)
				.OrderByDescending(l => l.CreatedAt)
				.ToListAsync();

			return _mapper.Map<IEnumerable<FeedbackLikeDto>>(likes);
		}

		// Report methods
		public async Task<FeedbackReportDto> ReportFeedbackAsync(
			int feedbackId,
			int userId,
			FeedbackReportForCreateDto reportDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var feedback = await _unitOfWork.FeedbackRepository.GetByIdAsync(feedbackId);
				if (feedback == null)
					throw new FeedbackNotFoundException($"Không tìm thấy đánh giá {feedbackId}");

				var existingReport = await _unitOfWork.FeedbackReportRepository
					.FindByCondition(r => r.FeedbackId == feedbackId && r.UserId == userId)
					.FirstOrDefaultAsync();

				if (existingReport != null)
					throw new FeedbackBadRequestException("Bạn đã báo cáo đánh giá này rồi");

				var report = new FeedbackReport
				{
					FeedbackId = feedbackId,
					UserId = userId,
					Reason = reportDto.Reason,
					Status = ReportStatus.Pending
				};

				await _unitOfWork.FeedbackReportRepository.AddAsync(report);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				return _mapper.Map<FeedbackReportDto>(report);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task<bool> HasUserReportedFeedbackAsync(int feedbackId, int userId)
		{
			return await _unitOfWork.FeedbackReportRepository
				.FindByCondition(r => r.FeedbackId == feedbackId && r.UserId == userId)
				.AnyAsync();
		}

		public async Task<IEnumerable<FeedbackReportDto>> GetFeedbackReportsAsync(int feedbackId)
		{
			var reports = await _unitOfWork.FeedbackReportRepository
				.FindByCondition(r => r.FeedbackId == feedbackId)
				.Include(r => r.User)
				.OrderByDescending(r => r.CreatedAt)
				.ToListAsync();

			return _mapper.Map<IEnumerable<FeedbackReportDto>>(reports);
		}

		public async Task<FeedbackReportDto> UpdateReportStatusAsync(int reportId, ReportStatus status)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var report = await _unitOfWork.FeedbackReportRepository.GetByIdAsync(reportId);
				if (report == null)
					throw new FeedbackNotFoundException($"Không tìm thấy báo cáo {reportId}");

				report.Status = status;
				report.UpdatedAt = DateTime.UtcNow;

				_unitOfWork.FeedbackReportRepository.Update(report);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				return _mapper.Map<FeedbackReportDto>(report);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task DeleteReportAsync(int reportId)
		{
			var report = await _unitOfWork.FeedbackReportRepository.GetByIdAsync(reportId);
			if (report == null)
				throw new FeedbackNotFoundException($"Không tìm thấy báo cáo {reportId}");

			_unitOfWork.FeedbackReportRepository.Remove(report);
			await _unitOfWork.SaveChangesAsync();
		}

		public async Task<IEnumerable<FeedbackReportDto>> GetPendingReportsAsync()
		{
			var reports = await _unitOfWork.FeedbackReportRepository
				.FindByCondition(r => r.Status == ReportStatus.Pending)
				.Include(r => r.User)
				.Include(r => r.Feedback)
				.OrderByDescending(r => r.CreatedAt)
				.ToListAsync();

			return _mapper.Map<IEnumerable<FeedbackReportDto>>(reports);
		}
	}
}