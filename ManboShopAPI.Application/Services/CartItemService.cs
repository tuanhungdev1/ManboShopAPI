using AutoMapper;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
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

		

		
	}
}