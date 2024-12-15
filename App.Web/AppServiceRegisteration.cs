using Entites.Repository;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace App.Web
{
    public static class AppServiceRegisteration
    {

        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddDbContext<App.Context.AppContext, App.Context.AppContext>(options => { options.UseNpgsql(""); });
            return services;    
        }

        
    }
}
