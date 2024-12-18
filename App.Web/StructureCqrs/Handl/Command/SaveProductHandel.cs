using App.Context.Repository;
using App.Web.StructureCqrs.Request.Command;
using AutoMapper;
using Entites.Entites;
using Entites.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.StructureCqrs.Handl.Command
{
    public class SaveProductHandel : IRequestHandler<SaveProductRequest, ResultDto<ProductDto>>
    {
        private readonly IProductRepository productRepository;
        public SaveProductHandel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<ResultDto<ProductDto>> Handle(SaveProductRequest request, CancellationToken cancellationToken)
        {
            Product product= MapperConfig.InitializeAutomapper<ProductDto, Product>(request.ProductDto);

            if (product.ID == 0)
            {
               await productRepository.AddAsync(product);
               await productRepository.SaveChangeAsync();
            }
            else
            {
                productRepository.Update(product);
                productRepository.SaveChange();                 
            }

            return ResultDto<ProductDto>.ResultSuccess(request.ProductDto);
        }
    }
}
