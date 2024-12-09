using App.Web.StructureCqrs.Request;
using Entites.Entites;
using Entites.Repository;
using MediatR;

namespace App.Web.StructureCqrs.Handl
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
            await categoryRepository.AddAsync(category);
            await categoryRepository.SaveChangeAsync();
            return 1;
        }
    }
}
