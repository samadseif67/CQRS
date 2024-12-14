using App.Web.StructureCqrs.Request.Query;
using Entites.Repository;
using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Handl.Query
{
    public class GetAllCategoryHandel : IRequestHandler<GetAllCategoryRequest, ResultDto<List<CategoryDto>>>
    {
        private readonly ICategoryRepository categoryRepository;
        public GetAllCategoryHandel(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public Task<ResultDto<List<CategoryDto>>> Handle(GetAllCategoryRequest request, CancellationToken cancellationToken)
        {
            List<CategoryDto> lst = new List<CategoryDto>();
            lst = categoryRepository.GetAll().Select(x => new CategoryDto { ID = x.ID, Name = x.Name }).ToList();
            var result = ResultDto<List<CategoryDto>>.ResultSuccess(lst);
            return Task.FromResult(result);
        }
    }
}
