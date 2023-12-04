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

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

		public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
		{
            var userId = Guid.Parse("70D1ACAE-20A4-41BF-A054-A7B9B8B4EA5F");
            var article = new Article
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryId,
                UserId= userId,
            };
            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
		}

		public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {        
            var articles=await unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.isDeleted,x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}
