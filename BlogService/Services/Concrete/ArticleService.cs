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

        public async Task<List<ArticleDto>> GetAllArticlesAsync()
        {        
            var articles=await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}
