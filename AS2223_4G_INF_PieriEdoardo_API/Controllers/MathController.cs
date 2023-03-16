using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_PieriEdoardo_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class MathController : Controller
    {
        [HttpGet("PariODispari")]
        public JsonResult PariODispari(int num)
        {
            string output, status;
            if (num % 2 == 0)
            {
                output = "pari";
                status = "OK";
            }
            else if (num % 2 != 0)
            {
                output = "dispari";
                status = "OK";
            }
            else
            {
                output = "";
                status = "KO";
            }
            return Json(new {output, status });
        }
    }
}
