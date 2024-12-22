using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.NewsDetailDto;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

public class NewsDetailService : INewsDetailService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILoggerService _logger;

	public NewsDetailService(
		IUnitOfWork unitOfWork,
		IMapper mapper,
		ILoggerService logger)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
	}

	public async Task<(IEnumerable<NewsDetailDto> newsDetailDtos, MetaData metaData)> GetAllNewsDetailAsync(NewsDetailRequestParameters newsDetailRequestParameters)
	{
		var newsDetails = await _unitOfWork.NewsDetailRepository.FetchAllNewsDetailsAsync(newsDetailRequestParameters);
		_logger.LogInfo("Lấy danh sách chi tiết tin tức thành công");
		var newsDetailDtos = _mapper.Map<IEnumerable<NewsDetailDto>>(newsDetails);

		return (newsDetailDtos, newsDetails.MetaData);
	}

	public async Task CreateNewsDetailAsync(NewsDetailForCreateDto newsDetailForCreateDto)
	{
		var existingNewsDetail = await _unitOfWork.NewsDetailRepository
									.FindByCondition(nd => nd.NewsId == newsDetailForCreateDto.NewsId && nd.ProductId == newsDetailForCreateDto.ProductId)
									.FirstOrDefaultAsync();

		if (existingNewsDetail != null)
		{
			_logger.LogError($"Chi tiết tin tức với NewsId {newsDetailForCreateDto.NewsId} và ProductId {newsDetailForCreateDto.ProductId} đã tồn tại");
			throw new NewsDetailBadRequestException($"Chi tiết tin tức với NewsId {newsDetailForCreateDto.NewsId} và ProductId {newsDetailForCreateDto.ProductId} đã tồn tại");
		}

		var news = await _unitOfWork.NewsRepository.GetByIdAsync(newsDetailForCreateDto.NewsId);

		if (news == null)
		{
			_logger.LogError($"Không tìm thấy tin tức với Id {newsDetailForCreateDto.NewsId}");
			throw new NewsNotFoundException(newsDetailForCreateDto.NewsId);
		}

		var product = await _unitOfWork.ProductRepository.GetByIdAsync(newsDetailForCreateDto.ProductId);

		if (product == null)
		{
			_logger.LogError($"Không tìm thấy sản phẩm với Id {newsDetailForCreateDto.ProductId}");
			throw new ProductNotFoundException(newsDetailForCreateDto.ProductId);
		}

		var newsDetail = _mapper.Map<NewsDetail>(newsDetailForCreateDto);
		await _unitOfWork.NewsDetailRepository.AddAsync(newsDetail);
		await _unitOfWork.SaveChangesAsync();
		_logger.LogInfo($"Thêm chi tiết tin tức cho NewsId {newsDetailForCreateDto.NewsId} thành công");
	}
	public async Task UpdateNewsDetailAsync(int id, NewsDetailForUpdateDto newsDetailForUpdateDto)
	{
		var newsDetail = await _unitOfWork.NewsDetailRepository.GetByIdAsync(id);

		if (newsDetail == null)
		{
			_logger.LogError($"Không tìm thấy chi tiết tin tức với Id {id}");
			throw new NewsDetailNotFoundException(id);
		}

		var existingNewsDetail = await _unitOfWork.NewsDetailRepository
									.FindByCondition(nd => nd.NewsId == newsDetailForUpdateDto.NewsId && nd.ProductId == newsDetailForUpdateDto.ProductId && nd.Id != id)
									.FirstOrDefaultAsync();

		if(existingNewsDetail != null)
		{
			_logger.LogError($"Chi tiết tin tức với NewsId {newsDetailForUpdateDto.NewsId} và ProductId {newsDetailForUpdateDto.ProductId} đã tồn tại");
			throw new NewsDetailBadRequestException($"Chi tiết tin tức với NewsId {newsDetailForUpdateDto.NewsId} và ProductId {newsDetailForUpdateDto.ProductId} đã tồn tại");
		}
		

		var news = await _unitOfWork.NewsRepository.GetByIdAsync(newsDetailForUpdateDto.NewsId);

		if (news == null)
		{
			_logger.LogError($"Không tìm thấy tin tức với Id {newsDetailForUpdateDto.NewsId}");
			throw new NewsNotFoundException(newsDetailForUpdateDto.NewsId);
		}

		var product = await _unitOfWork.ProductRepository.GetByIdAsync(newsDetailForUpdateDto.ProductId);

		if (product == null)
		{
			_logger.LogError($"Không tìm thấy sản phẩm với Id {newsDetailForUpdateDto.ProductId}");
			throw new ProductNotFoundException(newsDetailForUpdateDto.ProductId);
		}

		_mapper.Map(newsDetailForUpdateDto, newsDetail);
		_unitOfWork.NewsDetailRepository.Update(newsDetail);
		await _unitOfWork.SaveChangesAsync();

		_logger.LogInfo($"Cập nhật chi tiết tin tức với Id {id} thành công");
	}

	public async Task DeleteNewsDetailAsync(int id)
	{
		var newsDetail = await _unitOfWork.NewsDetailRepository.GetByIdAsync(id);

		if (newsDetail == null)
		{
			_logger.LogError($"Không tìm thấy chi tiết tin tức với Id {id}");
			throw new NewsDetailNotFoundException(id);
		}

		_unitOfWork.NewsDetailRepository.Remove(newsDetail);
		await _unitOfWork.SaveChangesAsync();

		_logger.LogInfo($"Xóa chi tiết tin tức với Id {id} thành công");
	}


	public async Task<NewsDetailDto> GetNewsDetail(int id)
	{
		var newsDetail = await _unitOfWork
							.NewsDetailRepository
							.FindByCondition(nd => nd.Id == id)
							.Include(nd => nd.News)
							.Include(nd => nd.Product)
							.FirstOrDefaultAsync()
							;

		if (newsDetail == null)
		{
			_logger.LogError($"Không tìm thấy chi tiết tin tức với Id {id}");
			throw new NewsDetailNotFoundException(id);
		}

		_logger.LogInfo($"Lấy chi tiết tin tức với Id {id} thành công");

		return _mapper.Map<NewsDetailDto>(newsDetail);

	}


	public async Task<IEnumerable<NewsDetailDto>> GetByNewsIdAsync(int newsId)
	{
		var news = await _unitOfWork.NewsRepository.GetByIdAsync(newsId);
		if (news == null)
		{
			_logger.LogError($"Không tìm thấy tin tức với Id {newsId}");
			throw new NewsNotFoundException(newsId);
		}

		var newsDetails = await _unitOfWork.NewsDetailRepository.GetByNewsIdAsync(newsId, true);
		_logger.LogInfo($"Lấy danh sách chi tiết tin tức theo NewsId {newsId} thành công");
		return _mapper.Map<IEnumerable<NewsDetailDto>>(newsDetails);
	}

	public async Task<IEnumerable<NewsDetailDto>> GetByProductIdAsync(int productId)
	{
		var product = await _unitOfWork.ProductRepository.GetByIdAsync(productId);
		if (product == null)
		{
			_logger.LogError($"Không tìm thấy sản phẩm với Id {productId}");
			throw new ProductNotFoundException(productId);
		}

		var newsDetails = await _unitOfWork.NewsDetailRepository.GetByProductIdAsync(productId, true);
		_logger.LogInfo($"Lấy danh sách chi tiết tin tức theo ProductId {productId} thành công");
		return _mapper.Map<IEnumerable<NewsDetailDto>>(newsDetails);
	}

	public async Task<bool> ExistsAsync(int newsId, int productId)
	{
		var exists = await _unitOfWork.NewsDetailRepository.ExistsAsync(newsId, productId);
		_logger.LogInfo($"Kiểm tra tồn tại chi tiết tin tức với NewsId {newsId} và ProductId {productId}");
		return exists;
	}

	public async Task AddNewsDetailsAsync(int newsId, IEnumerable<int> productIds)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var news = await _unitOfWork.NewsRepository.GetByIdAsync(newsId);
			if (news == null)
			{
				_logger.LogError($"Không tìm thấy tin tức với Id {newsId}");
				throw new NewsNotFoundException(newsId);
			}

			var uniqueProductIds = productIds.Distinct().ToList();

			foreach (var productId in uniqueProductIds)
			{
				var product = await _unitOfWork.ProductRepository.GetByIdAsync(productId);
				if (product == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với Id {productId}");
					throw new ProductNotFoundException(productId);
				}
			}

			var existingPairs = await _unitOfWork.NewsDetailRepository
									.FindAsync(nd => nd.NewsId == newsId && uniqueProductIds.Contains(nd.ProductId));

			var existingProductIds = existingPairs.Select(nd => nd.ProductId).ToList();
			var newProductIds = uniqueProductIds.Except(existingProductIds).ToList();

			await _unitOfWork.NewsDetailRepository.AddNewsDetailsAsync(newsId, newProductIds);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Thêm chi tiết tin tức cho NewsId {newsId} thành công");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task RemoveNewsDetailsAsync(int newsId)
	{
		try
		{


			await _unitOfWork.BeginTransactionAsync();

			var news = await _unitOfWork.NewsRepository.GetByIdAsync(newsId);
			if (news == null)
			{
				_logger.LogError($"Không tìm thấy tin tức với Id {newsId}");
				throw new NewsNotFoundException(newsId);
			}

			var newsDetailsWithNewsId = await _unitOfWork.NewsDetailRepository
				.FindByCondition(nd => nd.NewsId == newsId)
				.ToListAsync();

			if (newsDetailsWithNewsId.Count == 0)
			{
				_logger.LogError($"Không tìm thấy chi tiết tin tức cho NewsId {newsId}");
				throw new NewsDetailNotFoundException(newsId);
			}


			

			await _unitOfWork.NewsDetailRepository.RemoveNewsDetailsAsync(newsId);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Xóa chi tiết tin tức cho NewsId {newsId} thành công");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}
}