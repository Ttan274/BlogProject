using BlogProject.Entity.DTOs.Article;

namespace BlogProject.Service.Service.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticleAsync();
    }
}
