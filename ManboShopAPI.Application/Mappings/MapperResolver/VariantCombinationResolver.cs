using AutoMapper;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Application.DTOs.VariantValueDto;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Application.Mappings.MapperResolver
{
	public class VariantCombinationResolver : IValueResolver<ProductVariantValue, ProductVariantValueDto, ICollection<ProductVariantDetailDto>>
	{
		private readonly IVariantValueRepository _variantValueRepository;
		private readonly IVariantRepository _variantRepository;

		public VariantCombinationResolver(
			IVariantValueRepository variantValueRepository,
			IVariantRepository variantRepository)
		{
			_variantValueRepository = variantValueRepository;
			_variantRepository = variantRepository;
		}

		public ICollection<ProductVariantDetailDto> Resolve(
			ProductVariantValue source,
			ProductVariantValueDto destination,
			ICollection<ProductVariantDetailDto> destMember,
			ResolutionContext context)
		{
			var variantDetailDtos = new List<ProductVariantDetailDto>();
			var variantValueIds = source.Sku.Split('-').Select(int.Parse).ToList();

			foreach (var id in variantValueIds)
			{
				var variantValue = _variantValueRepository.FindByCondition( v => v.Id == id).FirstOrDefault();
				if (variantValue != null)
				{
					var variant = _variantRepository.FindByCondition(v => v.Id == variantValue.VariantId).FirstOrDefault();

					variantDetailDtos.Add(new ProductVariantDetailDto
					{
						VariantName = variant.Name,
						Value = variantValue.Value
					});
				}
			}

			return variantDetailDtos;
		}
	}
}
