using AutoMapper;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.DTOs.BrandDtos;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
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
			CreateMap<Product, ProductDto>()
				.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(p => p.Category.Name))
				.ForMember(dest => dest.BrandName, opt => opt.MapFrom(p => p.Brand.Name));
			CreateMap<ProductForCreateDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<ProductForUpdateDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//PRODUCT

			//USER
			CreateMap<User, UserDto>();
			CreateMap<UserForCreateDto, User>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<UserForUpdateDto, User>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//USER

			//ADDRESS
			CreateMap<Address, AddressDto>();
			CreateMap<AddressForCreateDto, Address>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<AddressForUpdateDto, Address>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//ADDRESS

			//ORDER

			CreateMap<Order, OrderDto>();
			CreateMap<OrderForCreateDto, Order>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<OrderForUpdateDto, Order>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());

			//ORDER
		}
	}
}
