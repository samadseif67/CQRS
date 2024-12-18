using App.Web.StructureCqrs.Request.Command;
using Entites.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task< ActionResult> Save(ProductDto productDto)
        {
            SaveProductRequest saveProductRequest = new SaveProductRequest();
            saveProductRequest.ProductDto = productDto;
            var result =await mediator.Send(saveProductRequest);
            return Ok(result);
        }



    }
}
