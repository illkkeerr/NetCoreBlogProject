using BlogService.Services.Abstraction;
using BlogService.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogService.Extensions
{
	public static class ServiceLayerExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped<IArticleService,ArticleService>();
			return services;
		}
	}
}
