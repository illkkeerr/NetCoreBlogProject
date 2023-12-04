﻿using AutoMapper;
using BlogData.UnitOfWorks;
using BlogEntity.DTOs.Categories;
using BlogEntity.Entities;
using BlogService.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogService.Services.Concrete
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

		public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
		{
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}
		public async Task<List<CategoryDto>> GetALlCategoriesNonDeleted()
		{
			var categories= await unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.isDeleted);
			var map=mapper.Map<List<CategoryDto>>(categories);

			return map;
		}
	}
}
