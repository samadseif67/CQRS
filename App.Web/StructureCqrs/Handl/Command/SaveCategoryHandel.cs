using App.Web.StructureCqrs.Request.Command;
using Entites.Entites;
using Entites.Repository;
using MediatR;

namespace App.Web.StructureCqrs.Handl.Command
{
    public class SaveCategoryHandel : IRequestHandler<SaveCategoryRequest, uint>
    {
        private readonly ICategoryRepository categoryRepository;
        public SaveCategoryHandel(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }


        public async Task<uint> Handle(SaveCategoryRequest request, CancellationToken cancellationToken)
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
            
            return 1;
        }
    }
}
