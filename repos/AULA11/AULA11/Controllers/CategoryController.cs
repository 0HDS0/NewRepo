using AULA11.Domain;
using AULA11.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AULA11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryHandler handler;

        public CategoryController()
        {
            handler = new CategoryHandler();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByID(long id)
        {
            return handler.GetById(id);
        }
        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            return handler.Post(category);
        }
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            return handler.GetAll();
        }
    }
}
