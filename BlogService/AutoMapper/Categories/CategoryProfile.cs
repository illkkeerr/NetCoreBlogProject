using AutoMapper;
using BlogEntity.DTOs.Categories;
using BlogEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogService.AutoMapper.Categories
{
	public class CategoryProfile:Profile
	{
		public CategoryProfile()
		{
			CreateMap<CategoryDto, Category>().ReverseMap();
		}
	}
}
