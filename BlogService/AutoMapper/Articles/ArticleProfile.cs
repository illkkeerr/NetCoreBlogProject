using AutoMapper;
using BlogEntity.DTOs.Articles;
using BlogEntity.Entities;

namespace BlogService.AutoMapper.Articles
{
    public class ArticleProfile:Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
        }
    }
}
