﻿using BlogEntity.DTOs.Articles;

namespace BlogService.Services.Abstraction
{
    public interface IArticleService
    {
		Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
		Task CreateArticleAsync(ArticleAddDto articleAddDto);


	}
}
