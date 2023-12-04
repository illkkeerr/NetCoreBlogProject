using BlogEntity.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogService.Services.Abstraction
{
	public interface ICategoryService
	{
		public Task<List<CategoryDto>> GetALlCategoriesNonDeleted();

	}
}
