using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula_1_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenacController : ControllerBase
    {
        [HttpGet]
        [Route("OlaMundo")]
        public string GetOlaMundo()
        {
            return "Hello World!";
        }
    }
}
