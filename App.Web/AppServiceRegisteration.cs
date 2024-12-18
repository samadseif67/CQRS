using App.Context.Repository;
using Entites.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace App.Web
{
    public static class AppServiceRegisteration
    {

        public static IServiceCollection RegisterService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();



            services.AddDbContext<App.Context.AppContext>(options => { options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")); }) ;
            
            return services;    
        }

        
    }
}
