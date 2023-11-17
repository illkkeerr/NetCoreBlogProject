using BlogData.Context;
using BlogData.Repositories.Abstractions;
using BlogData.Repositories.Concrete;
using BlogData.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogData.DataExtensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration config)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));


			return services;
		}
	}
}
