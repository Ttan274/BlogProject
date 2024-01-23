using BlogProject.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Service.Abstraction
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticleAsync();
    }
}
