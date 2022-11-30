using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hajos_gyak.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route ("questions/all")]
        public IActionResult adjad()
        {
            Models.HajosContext hajosContext = new Models.HajosContext();
            var list = from x in hajosContext.Questions
                       select x.Question1;
            return new JsonResult(list);
        }
    }
}
