using AutoMapper;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Application.Mappings.MapperResolver
{
	public class ProductVariantsResolver : IValueResolver<Product, ProductDto, ICollection<ProductVariantDto>>
	{
		private readonly IVariantRepository _variantRepository;
		private readonly IMapper _mapper;

		public ProductVariantsResolver(IVariantRepository variantRepository, IMapper mapper)
		{
			_variantRepository = variantRepository;
			_mapper = mapper;
		}

		public ICollection<ProductVariantDto> Resolve(Product source, ProductDto destination, ICollection<ProductVariantDto> destMember, ResolutionContext context)
		{
			// Lấy danh sách các variantValueId từ tất cả SKU của ProductVariantValues
			var variantValueIds = source.ProductVariantValues
				.SelectMany(pvv => pvv.Sku.Split('-').Select(int.Parse))
				.Distinct();

			// Lấy tất cả VariantValue và Variant tương ứng
			var variants = _variantRepository.GetVariantsWithValuesByValueIds(variantValueIds);

			return variants.Select(v => new ProductVariantDto
			{
				Id = v.Id,
				Name = v.Name,
				Values = _mapper.Map<ICollection<VariantValueDto>>(v.VariantValues),
				CreatedAt = v.CreatedAt,
				UpdatedAt = v.UpdatedAt
			}).ToList();
		}
	}
}
