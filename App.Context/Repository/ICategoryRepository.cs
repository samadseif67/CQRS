using App.Context;
using Entites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Repository
{
    public interface ICategoryRepository: IGenericRepository<Category>
    {

    }

    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(App.Context.AppContext appContext):base(appContext) 
        {
                
        }



    }

}
