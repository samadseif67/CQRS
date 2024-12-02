using Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Context
{
    public class AppContext:DbContext
    {
        public AppContext(DbContextOptionsBuilder<AppContext> options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
    }
}
