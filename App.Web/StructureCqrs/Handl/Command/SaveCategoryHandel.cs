using App.Web.StructureCqrs.Request.Command;
using Entites.Entites;
using Entites.Repository;
using Entites.ViewModel;
using MediatR;

namespace App.Web.StructureCqrs.Handl.Command
{
    public class SaveCategoryHandel : IRequestHandler<SaveCategoryRequest, ResultDto<CategoryDto>>
    {
        private readonly ICategoryRepository categoryRepository;
        public SaveCategoryHandel(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }


        public async Task<ResultDto<CategoryDto>> Handle(SaveCategoryRequest request, CancellationToken cancellationToken)
        {
            Category category = new Category();
            category.ID= request.CategoryDto.ID;
            category.Name= request.CategoryDto.Name;

            if(category.ID==0)
            {
                await categoryRepository.AddAsync(category);
                await categoryRepository.SaveChangeAsync();
            }
            else
            {
                categoryRepository.Update(category);
                categoryRepository.SaveChange();
            }

            var result= ResultDto<CategoryDto>.ResultSuccess(request.CategoryDto);
            return result;
        }
    }
}
