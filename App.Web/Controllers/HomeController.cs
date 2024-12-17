using App.Web.StructureCqrs.Request.Command;
using Entites.Attribute;
using Entites.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 

namespace App.Web.Controllers
{
    [Route("api/[controller]/[action]")]  
    [ApiController]   
    public class HomeController : ControllerBase
    {
        private readonly IMediator mediator;
        public HomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SaveCategory(CategoryDto categoryDto)
        {
            SaveCategoryRequest saveCategoryRequest=new SaveCategoryRequest();
            saveCategoryRequest.CategoryDto = categoryDto;
            var result= await mediator.Send(saveCategoryRequest);
            return Ok(result);
        }





    }
}
