using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductSql.API.Handlers;
using ProductSql.API.Domain;


namespace ProductSql.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoHandler _handler;
        public ProdutoController()
        {
            _handler = new ProdutoHandler();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(_handler.GetbyID(id));
        }

        [HttpGet]
        [Route("List")]
        public IActionResult GetAll()
        {
            return Ok(_handler.GetAll);
        }

        [HttpPost]
        [Route ("New")]
        public IActionResult Post([FromBody] Produto produto)
        {
            _handler.Post(produto);
            return Ok();
        }


    }
}
