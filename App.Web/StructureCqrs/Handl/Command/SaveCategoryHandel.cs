using App.Web.StructureCqrs.Request.Command;
using Entites.Entites;
using Entites.Repository;
using Entites.Valiotions;
using Entites.ViewModel;
using FluentValidation;
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

            CategoryValidation validationRules = new CategoryValidation();
            var validateInput = await validationRules.ValidateAsync(request.CategoryDto, cancellationToken);
            if (!validateInput.IsValid)
            {
                var lstError = validateInput.Errors.Select(x => x.ErrorMessage).ToList();
                return ResultDto<CategoryDto>.ResultLstError(lstError);
            }


            Category category = new Category();
            category.ID = request.CategoryDto.ID;
            category.Name = request.CategoryDto.Name;

            if (category.ID == 0)
            {
                await categoryRepository.AddAsync(category);
                await categoryRepository.SaveChangeAsync();
            }
            else
            {
                categoryRepository.Update(category);
                categoryRepository.SaveChange();
            }

            var result = ResultDto<CategoryDto>.ResultSuccess(request.CategoryDto);
            return result;
        }
    }
}
