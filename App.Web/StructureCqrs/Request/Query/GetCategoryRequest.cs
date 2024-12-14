using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Request.Query
{
    public class GetCategoryRequest:IRequest<ResultDto<CategoryDto>>
    {
        public int CategoryId { get; set; }
    }
}
