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
        [HttpGet("Fattoriale")]
        public JsonResult Fattoriale(int num)
        {
            int output = 1;
            string status;
            for(int c = num; c > 1; c--)
            {
                output = output * c;
            }
            status = "OK";
            return Json(new {output, status});
        }
        [HttpGet("CalcolaParabola")]
        public JsonResult CalcolaParabola(int a, int b, int c)
        {
            double sol1, sol2;
            string status, tipoParabola;
            int nSoluzioni;
            int d = (b * b) - 4 * (a * c);
            
            if(d < 0)   //se l equazione e impossibile
            {
                sol1 = 0;
                sol2 = 0;
                nSoluzioni = 0;
                status = "OK";
                tipoParabola = "impossibile calcolare le radici";
            } else if(d >= 0)   //se ha una o due soluzioni (nSoluzioni indica il numero di soluzioni)
            {
                sol1 = ((b * -1) + Math.Sqrt(d)) / (a * 2);
                sol2 = ((b * -1) - Math.Sqrt(d)) / (a * 2);
                if (sol1 == sol2) nSoluzioni = 1;
                else nSoluzioni = 2;
                if (a > 0) tipoParabola = "convessa";
                else if (d == 0) tipoParabola = "due radici coincidenti";
                else tipoParabola = "concava";
                status = "OK";
            } else
            {
                sol1 = 0;
                sol2 = 0;
                status = "KO";
                tipoParabola = "";
                nSoluzioni = 0;
            }
            return Json(new { sol1, sol2, status, tipoParabola, a, b, c, nSoluzioni});
        }
        [HttpGet("CalcolaAliquota")]
        public JsonResult CalcolaAliquota(int reddito)
        {
            string output;
            if(reddito >= 35000) { }
        }
    }
}
