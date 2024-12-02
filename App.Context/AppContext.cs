﻿using App.Context.Validations;
using Entites.Entites;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityTypeConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Category> Categories { get; set; }
    }
}
