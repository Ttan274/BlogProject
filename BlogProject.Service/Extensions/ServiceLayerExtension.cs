using BlogProject.Service.Service.Abstraction;
using BlogProject.Service.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlogProject.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();   

            services.AddScoped<IArticleService, ArticleService>();
            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
