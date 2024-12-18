using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Request.Command
{
    public class SaveProductRequest:IRequest<ResultDto<ProductDto>>
    {
        public ProductDto ProductDto { get; set; }
    }
}
