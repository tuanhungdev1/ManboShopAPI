using AutoMapper;
using ManboShopAPI.Application.DTOs.CategoryDtos;
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

			// CATEGORY
			CreateMap<Category, CategoryDto>();
			CreateMap<CategoryForCreateDto, Category>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			CreateMap<CategoryForUpdateDto, Category>()
				.ForMember(dest => dest.Id, opt => opt.Ignore());
			//CATEGORY
		}
	}
}
