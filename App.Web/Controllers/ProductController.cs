using App.Web.StructureCqrs.Request.Command;
using Entites.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;

namespace App.Web.Controllers
{
    /// <summary>
    /// شسیتنشستینسشی
    /// </summary>
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Description("این کنترلر برای مدیریت کاربران استفاده می‌شود.")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// ذخیره محصولات
        /// </summary>
        /// <param name="productDto"></param>
        /// <returns></returns>
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
