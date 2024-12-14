using App.Web.StructureCqrs.Request.Query;
using Entites.Repository;
using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Handl.Query
{
    public class GetAllCategoryHandel : IRequestHandler<GetAllCategoryRequest, List<CategoryDto>>
    {
        private readonly ICategoryRepository categoryRepository;
        public GetAllCategoryHandel(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Task<List<CategoryDto>> Handle(GetAllCategoryRequest request, CancellationToken cancellationToken)
        {
            List<CategoryDto> lst = new List<CategoryDto>();
            lst= categoryRepository.GetAll().Select(x => new CategoryDto {ID=x.ID,Name=x.Name }).ToList();          
            return Task.FromResult(lst);
        }
    }
}
