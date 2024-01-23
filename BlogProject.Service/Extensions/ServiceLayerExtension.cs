using BlogProject.Service.Service.Abstraction;
using BlogProject.Service.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace BlogProject.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
