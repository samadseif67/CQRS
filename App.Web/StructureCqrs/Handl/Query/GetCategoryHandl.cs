using App.Web.StructureCqrs.Request.Query;
using Entites.Repository;
using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Handl.Query
{
    public class GetCategoryHandl : IRequestHandler<GetCategoryRequest, ResultDto<CategoryDto>>
    {
        private readonly ICategoryRepository categoryRepository;
        public GetCategoryHandl(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<ResultDto<CategoryDto>> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
        {
            CategoryDto categoryDto = new CategoryDto();
            int CategoryId = request.CategoryId;
            var FindCategorey = await categoryRepository.GetAsync(CategoryId);

            categoryDto.ID = FindCategorey.ID;
            categoryDto.Name = FindCategorey.Name;

            var result = ResultDto<CategoryDto>.ResultSuccess(categoryDto);
            return result;
        }
    }
}
