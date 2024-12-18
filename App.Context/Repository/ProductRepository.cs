using Entites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Context.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly App.Context.AppContext Context;
        public ProductRepository(App.Context.AppContext Context) : base(Context)
        {
            this.Context = Context;
        }
    }
}
