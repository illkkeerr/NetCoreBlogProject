using BlogService.Services.Abstraction;
using BlogService.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlogService.Extensions
{
	public static class ServiceLayerExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services, IConfiguration config)
		{
			var assembly=Assembly.GetExecutingAssembly();
			services.AddAutoMapper(assembly);

			services.AddScoped<IArticleService,ArticleService>();
			return services;
		}
	}
}
