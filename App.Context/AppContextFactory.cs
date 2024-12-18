using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Context
{
    //public class AppContextFactory : IDesignTimeDbContextFactory<AppContext>
    //{
    //    public AppContext CreateDbContext(string[] args)
    //    {
    //        var configuration = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettings.json")
    //            .Build();

    //        var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
    //        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));

    //        return new AppContext(optionsBuilder.Options);
    //    }
    //}
}
