using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Request.Query
{
    public class GetAllCategoryRequest:IRequest<List<CategoryDto>>
    {

    }
}
