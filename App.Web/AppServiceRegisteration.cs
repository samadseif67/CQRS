using Entites.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace App.Web
{
    public static class AppServiceRegisteration
    {

        public static IServiceCollection RegisterService(this IServiceCollection services,[FromServices] IConfiguration configuration)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddDbContext<App.Context.AppContext, App.Context.AppContext>(options => { options.UseNpgsql(configuration.GetConnectionString("DefaultPostgresql")); }) ;
            return services;    
        }

        
    }
}
