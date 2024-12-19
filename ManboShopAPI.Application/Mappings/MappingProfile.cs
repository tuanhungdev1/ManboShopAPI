using AutoMapper;
using ManboShopAPI.Application.DTOs.BrandDtos;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{

			//CATEGORY
			CreateMap<Category, CategoryDto>();
			CreateMap<CategoryForCreateDto, Category>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<CategoryForUpdateDto, Category>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//CATEGORY

			//BRAND
			CreateMap<Brand, BrandDto>();
			CreateMap<BrandForCreateDto, Brand>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<BrandForUpdateDto, Brand>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//BRAND


			//PRODUCT
			CreateMap<Product, ProductDto>();
			CreateMap<ProductForCreateDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<ProductForUpdateDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//PRODUCT
		}
	}
}
