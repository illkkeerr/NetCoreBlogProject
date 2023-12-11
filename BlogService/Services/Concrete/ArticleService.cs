using AutoMapper;
using BlogData.UnitOfWorks;
using BlogEntity.DTOs.Articles;
using BlogEntity.Entities;
using BlogService.Services.Abstraction;

namespace BlogService.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("70D1ACAE-20A4-41BF-A054-A7B9B8B4EA5F");
            var imageId = Guid.Parse("DC03ADDB-368F-467D-B9EE-44B3FF55690C");
            var article = new Article(articleAddDto.Title,articleAddDto.Content,userId,articleAddDto.CategoryId,imageId);
            
            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.isDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.isDeleted && x.Id == articleId, x => x.Category);
            var map = mapper.Map<ArticleDto>(article);
            return map;
        }

        public async Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.isDeleted && x.Id == articleUpdateDto.Id, x => x.Category);

            article.Title = articleUpdateDto.Title;
            article.Content = articleUpdateDto.Content;
            article.CategoryId = articleUpdateDto.CategoryId;



            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

        }

        public async Task SafeDeleteAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.isDeleted = true;
            article.DeletedDate = DateTime.Now;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);

            await unitOfWork.SaveAsync();
        }
    }
}
