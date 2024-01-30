using AutoMapper;
using BlogProject.Entity.DTOs.Article;
using BlogProject.Entity.Entity;

namespace BlogProject.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
        }
    }
}
