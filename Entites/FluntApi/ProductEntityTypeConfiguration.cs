using Entites.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.FluntApi
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.Title).IsRequired();
            builder.Property(x=>x.Price).IsRequired();
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryID);
        }
    }
}
