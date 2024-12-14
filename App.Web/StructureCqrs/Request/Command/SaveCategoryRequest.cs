using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Request.Command
{
    public class SaveCategoryRequest : IRequest<uint>
    {
        public CategoryDto CategoryDto { get; set; }
    }
}
