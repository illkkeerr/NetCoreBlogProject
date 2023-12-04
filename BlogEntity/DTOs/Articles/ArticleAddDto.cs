using BlogEntity.DTOs.Categories;
using BlogEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntity.DTOs.Articles
{
	public class ArticleAddDto
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public Guid CategoryId { get; set; }
		public IList<CategoryDto> Categories { get; set; }
	}
}
