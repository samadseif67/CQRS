using Entites.Attribute;
using Entites.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 

namespace App.Web.Controllers
{
    [Route("api/[controller]/[action]")]  
    [ApiController]   
    public class HomeController : ControllerBase
    {
        [HttpPost]  
        public ActionResult TestPerson(CategoryDto categoryDto)
        {


            return Ok();
        }
    }
}
