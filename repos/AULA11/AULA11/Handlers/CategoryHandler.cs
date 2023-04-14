using AULA11.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AULA11.Handlers
{
    public class CategoryHandler : ControllerBase
    {
        //Para utilizar as outras formas de uso dos códigos consulte Slides aula 14
        //Ps: Se você não lembra pra que isso serve a culpa é sua mesmo você devia ter copiado
        public static List<Category> categories = new List<Category>();
        public IActionResult GetById(long id)
        {
            Category? category = categories.Where(X => X.ID == id).FirstOrDefault();
            if (category == null)
            {
                return NotFound("Está categoria não existe");
            }
            return Ok(category);
            
        }
        public IActionResult Post(Category category)
        {
            Category? conflict = categories.Where(X => X.ID == category.ID).FirstOrDefault();
            if (conflict != null) 
            {
                return Conflict("Está categoria já existe");
            }
            categories.Add(category);
            return Created($"api/category/{category.ID}", category);
        }

        public IActionResult GetAll()
        {
            return Ok(categories);
        }
    }
}
