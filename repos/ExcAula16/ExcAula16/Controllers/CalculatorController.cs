using ExcAula16.Domain;
using ExcAula16.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ExcAula16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private CalculatorHandler handler;
        public CalculatorController() 
        { 
            handler = new CalculatorHandler();
        }
        [HttpPost]
        [Route("Execute")]
        public async Task<IActionResult> Calculation([FromBody] Parameters parameter)
        {
            return handler.Calculation(parameter);
        }

    }
}
