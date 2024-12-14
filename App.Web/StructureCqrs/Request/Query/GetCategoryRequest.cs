using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Request.Query
{
    public class GetCategoryRequest:IRequest<CategoryDto>
    {
        public int CategoryId { get; set; }
    }
}
