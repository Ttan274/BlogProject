using AutoMapper;
using BlogProject.Data.UnitOfWorks;
using BlogProject.Entity.DTOs.Article;
using BlogProject.Entity.Entity;
using BlogProject.Service.Service.Abstraction;

namespace BlogProject.Service.Service.Concrete
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

        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}
