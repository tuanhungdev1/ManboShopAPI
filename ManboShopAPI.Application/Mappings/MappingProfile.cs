using AutoMapper;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.DTOs.AttributeDtos;
using ManboShopAPI.Application.DTOs.BannerDetailDtos;
using ManboShopAPI.Application.DTOs.BannerDtos;
using ManboShopAPI.Application.DTOs.BrandDtos;
using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.CartItemDtos;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.FeedbackDtos;
using ManboShopAPI.Application.DTOs.NewsDetailDto;
using ManboShopAPI.Application.DTOs.NewsDtos;
using ManboShopAPI.Application.DTOs.OrderDetailDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.ProductImageDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Application.Mappings.MapperResolver;
using ManboShopAPI.Application.Services;
using ManboShopAPI.Domain.Entities;

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
				.ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
	.ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand))
				.ForMember(dest => dest.Variants, opt =>
				opt.MapFrom<ProductVariantsResolver>())
			.ForMember(dest => dest.VariantValues, opt =>
				opt.MapFrom(src => src.ProductVariantValues))
			.ForMember(dest => dest.ProductImages, opt =>
				opt.MapFrom(src => src.ProductImages))
			.ForMember(dest => dest.Attributes, opt =>
				opt.MapFrom(src => src.ProductAttributeValues))
			.ForMember(dest => dest.VariantValues, opt =>
				opt.MapFrom(src => src.ProductVariantValues));

			CreateMap<ProductAttributeValue, ProductAttributeValueDto>()
			.ForMember(dest => dest.Name, opt =>
				opt.MapFrom(src => src.Attribute.Name))
			.ForMember(dest => dest.Value, opt =>
				opt.MapFrom(src => src.Value));

			CreateMap<Variant, ProductVariantDto>();
			CreateMap<VariantValue, VariantValueDto>();

			CreateMap<ProductVariantValue, ProductVariantValueDto>()
			.ForMember(dest => dest.VariantCombination, opt =>
				opt.MapFrom<VariantCombinationResolver>())
			.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
			.ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.Sku))
			.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
			.ForMember(dest => dest.OldPrice, opt => opt.MapFrom(src => src.OldPrice))
			.ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
			.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
			.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

			CreateMap<Variant, ProductVariantDto>();
			CreateMap<VariantValue, VariantValueDto>();
			CreateMap<ProductVariantValue, ProductVariantValueDto>();

			CreateMap<VariantValueImage, VariantValueImageDto>();

			CreateMap<ProductForCreateDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<ProductForUpdateDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//PRODUCT

			//

			//USER
			CreateMap<User, UserDto>();
			CreateMap<UserForCreateDto, User>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<UserForUpdateDto, User>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<UserForRegistrationDto, User>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//USER

			//ADDRESS
			CreateMap<Address, AddressDto>();
			CreateMap<AddressForCreateDto, Address>()
				.ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
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

			//ORDER DETAIL
			CreateMap<OrderDetail, OrderDetailDto>();
			//ORDER DETAIL

			//FAVORITE
			CreateMap<FavoriteForCreateDto, Favorite>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());

			//FAVORITE

			//NEWS

			CreateMap<News, NewsDto>();
			CreateMap<NewsForCreateDto, News>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<NewsForUpdateDto, News>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());

			//NEWS


			//NEWS DETAIL

			CreateMap<NewsDetail, NewsDetailDto>();
			CreateMap<NewsDetailForCreateDto, NewsDetail>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<NewsDetailForUpdateDto, NewsDetail>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//NEWS DETAIL


			//BANNER

			CreateMap<Banner, BannerDto>();
			CreateMap<BannerForCreateDto, Banner>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<BannerForUpdateDto, Banner>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//BANNER

			//BANNER DETAIL

			CreateMap<BannerDetail, BannerDetailDto>();
			CreateMap<BannerDetailForCreateDto, BannerDetail>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<BannerDetailForUpdateDto, BannerDetail>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//BANNER DETAIL

			//PRODUCT IMAGE

			CreateMap<ProductImage, ProductImageDto>();

			//PRODUCT IMAGE


			//CART

			CreateMap<CartForCreateDto, Cart>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<Cart, CartDto>()
				.ForMember(dest => dest.CartItems, opt => opt.MapFrom(c => c.CartItems));
			//CART

			// CART ITEM

			// Ví dụ sử dụng AutoMapper
			CreateMap<CartItem, CartItemDto>()
				.ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductVariantValue.ProductId))
				.ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ProductVariantValue.Sku))
				.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.ProductVariantValue.Price))
				.ForMember(dest => dest.OldPrice, opt => opt.MapFrom(src => src.ProductVariantValue.OldPrice))
				.ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.ProductVariantValue.Stock))
				.ForMember(dest => dest.ProductVariantValue, opt => opt.MapFrom(src => src.ProductVariantValue))
				.ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.ProductVariantValue.Product));
			CreateMap<CartItemForCreateDto, CartItem>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//CART ITEM


			//FEEDBACK

			CreateMap<Feedback, FeedbackDto>();
			CreateMap<FeedbackForCreateDto, Feedback>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<FeedbackForUpdateDto, Feedback>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());

			//FEEDBACK


			//ADDRESS
			CreateMap<Address, AddressDto>().ReverseMap();
			CreateMap<AddressForCreateDto, Address>()
				.ForMember(dest => dest.Id, opt => opt.Ignore())
				.ReverseMap();
			CreateMap<AddressForUpdateDto, Address>()
				.ForMember(dest => dest.Id, opt => opt.Ignore())
				.ReverseMap();
			//ADDRESS


			// FEEDBACK LIKE
			CreateMap<FeedbackLike, FeedbackLikeDto>().ReverseMap();

			// FEEDBACK LIKE
		}
	}
}
