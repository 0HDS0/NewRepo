using AULA11.Domain;
using AULA11.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AULA11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductHandler handler;

        public ProductController()
        {
            handler = new ProductHandler();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByID(long id)
        {
            return handler.GetById(id);
        }
        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            return handler.Post(product);
        }
        [HttpGet]
        [Route("nao_vencidos")]
        public async Task<IActionResult> GetNaoVencidos()
        {
            return handler.GetNaoVencidos();
        }

    }
}
