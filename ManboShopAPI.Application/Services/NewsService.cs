using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.NewsDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

public class NewsService : INewsService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILoggerService _logger;

	public NewsService(
		IUnitOfWork unitOfWork,
		IMapper mapper,
		ILoggerService logger)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
	}

	public async Task<(IEnumerable<NewsDto> news, MetaData metaData)> GetAllNewsAsync(NewsRequestParameters newsRequestParameters)
	{
		var news = await _unitOfWork.NewsRepository.FetchAllNewsWithPaging(newsRequestParameters);
		_logger.LogInfo("Lấy danh sách tin tức thành công.");
		var newsDtoList = _mapper.Map<IEnumerable<NewsDto>>(news);
		return (newsDtoList, metaData: news.MetaData);
	}

	public async Task<NewsDto> GetNewsByIdAsync(int newsId)
	{
		var news = await _unitOfWork.NewsRepository.GetNewsByIdWithDetailsAsync(newsId);
		if (news == null)
		{
			_logger.LogError($"Không tìm thấy tin tức với Id {newsId}");
			throw new NewsNotFoundException(newsId);
		}
		_logger.LogInfo($"Lấy dữ liệu tin tức thành công.");
		return _mapper.Map<NewsDto>(news);
	}

	public async Task CreateNewsAsync(NewsForCreateDto newsForCreateDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			bool isNewsExisting = await _unitOfWork.NewsRepository.TitleExistsAsync(newsForCreateDto.Title);
			if (isNewsExisting)
			{
				_logger.LogError($"Tiêu đề tin tức {newsForCreateDto.Title} đã tồn tại trong hệ thống.");
				throw new NewsBadRequestException($"Tiêu đề tin tức {newsForCreateDto.Title} đã tồn tại trong hệ thống.");
			}

			// Kiểm tra tất cả productIds có tồn tại không
			foreach (var productId in newsForCreateDto.ProductIds)
			{
				var product = await _unitOfWork.ProductRepository.GetByIdAsync(productId);
				if (product == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với Id {productId}");
					throw new ProductNotFoundException(productId);
				}
			}

			var news = _mapper.Map<News>(newsForCreateDto);
			await _unitOfWork.NewsRepository.AddAsync(news);
			await _unitOfWork.SaveChangesAsync();

			// Tạo NewsDetails cho từng sản phẩm
			foreach (var productId in newsForCreateDto.ProductIds)
			{
				var newsDetail = new NewsDetail
				{
					NewsId = news.Id,
					ProductId = productId
				};
				await _unitOfWork.NewsDetailRepository.AddAsync(newsDetail);
			}
			await _unitOfWork.SaveChangesAsync();

			await _unitOfWork.CommitAsync();
			_logger.LogInfo("Tạo tin tức mới thành công.");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task UpdateNewsAsync(int newsId, NewsForUpdateDto newsForUpdateDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var existingNews = await _unitOfWork.NewsRepository.GetByIdAsync(newsId);
			if (existingNews == null)
			{
				_logger.LogError($"Không tìm thấy tin tức với Id {newsId}");
				throw new NewsNotFoundException(newsId);
			}

			if (existingNews.Title != newsForUpdateDto.Title &&
				await _unitOfWork.NewsRepository.TitleExistsAsync(newsForUpdateDto.Title))
			{
				_logger.LogError($"Tiêu đề tin tức {newsForUpdateDto.Title} đã tồn tại trong hệ thống.");
				throw new NewsBadRequestException($"Tiêu đề tin tức {newsForUpdateDto.Title} đã tồn tại trong hệ thống.");
			}

			// Kiểm tra tất cả productIds có tồn tại không
			foreach (var productId in newsForUpdateDto.ProductIds)
			{
				var product = await _unitOfWork.ProductRepository.GetByIdAsync(productId);
				if (product == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với Id {productId}");
					throw new ProductNotFoundException(productId);
				}
			}

			// Cập nhật thông tin News
			_mapper.Map(newsForUpdateDto, existingNews);
			existingNews.UpdatedAt = DateTime.UtcNow;
			_unitOfWork.NewsRepository.Update(existingNews);

			// Xóa tất cả NewsDetails cũ
			var existingNewsDetails = await _unitOfWork.NewsDetailRepository
				.FindAsync(nd => nd.NewsId == newsId);
			_unitOfWork.NewsDetailRepository.RemoveRange(existingNewsDetails);

			// Thêm NewsDetails mới
			foreach (var productId in newsForUpdateDto.ProductIds)
			{
				var newsDetail = new NewsDetail
				{
					NewsId = newsId,
					ProductId = productId
				};
				await _unitOfWork.NewsDetailRepository.AddAsync(newsDetail);
			}

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Cập nhật thành công tin tức với Id {existingNews.Id}");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task DeleteNewsAsync(int newsId)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var existingNews = await _unitOfWork.NewsRepository.GetByIdAsync(newsId);
			if (existingNews == null)
			{
				_logger.LogError($"Không tìm thấy tin tức với Id {newsId}");
				throw new NewsNotFoundException(newsId);
			}

			// Xóa tất cả NewsDetails liên quan
			var newsDetails = await _unitOfWork.NewsDetailRepository
				.FindAsync(nd => nd.NewsId == newsId);
			_unitOfWork.NewsDetailRepository.RemoveRange(newsDetails);

			// Xóa News
			_unitOfWork.NewsRepository.Remove(existingNews);

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Xóa thành công tin tức với Id {existingNews.Id}");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<NewsDto> GetNewsByTitleAsync(string title)
	{
		var news = await _unitOfWork.NewsRepository
			.FindByCondition(n => n.Title == title)
			.FirstOrDefaultAsync();

		if (news == null)
		{
			_logger.LogError($"Không tìm thấy tin tức với tiêu đề là {title}.");
			throw new NewsNotFoundException($"Không tìm thấy tin tức với tiêu đề là {title}.");
		}

		var newsDto = _mapper.Map<NewsDto>(news);
		_logger.LogInfo($"Lấy dữ liệu thành công tin tức với tiêu đề là {title}");
		return newsDto;
	}
}