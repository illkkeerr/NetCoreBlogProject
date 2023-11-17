using BlogEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogService.Services.Abstraction
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticlesAsync();
    }
}
