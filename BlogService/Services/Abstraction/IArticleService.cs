using BlogEntity.DTOs.Articles;

namespace BlogService.Services.Abstraction
{
    public interface IArticleService
    {
		Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
		Task CreateArticleAsync(ArticleAddDto articleAddDto);
		Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
		Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task SafeDeleteAsync(Guid articleId);




    }
}
