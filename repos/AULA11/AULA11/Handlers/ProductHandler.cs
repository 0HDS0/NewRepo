using AULA11.Domain;
using AULA11.Handlers;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace AULA11.Handlers
{
    public class ProductHandler : ControllerBase
    {
        //Para utilizar as outras formas de uso dos códigos consulte Slides aula 14
        //Ps: Se você não lembra pra que isso serve a culpa é sua mesmo você devia ter copiado
        //PSS:O único código diferente é o redirect
        private static List<Product> products = new List<Product>();
        public IActionResult GetById(long id)
        {
            Product product = products.Where(X => X.ID == id).FirstOrDefault(); 
            if (product == null)
            {
                return NotFound("Este produto não existe");
            }
            return Ok(product);
        }
        public IActionResult Post(Product product)
        {
            Category? Value = CategoryHandler.categories.Where(X => X.ID == product.IDCategory).FirstOrDefault();
            if (Value == null)
            {
                return NotFound("A categoria informada não existe!");
            }


            Product? conflict = products.Where(X => X.ID == product.ID).FirstOrDefault();
            if (conflict != null)
            {
                return Conflict("O produto já existe!");
            }


            product.Category = Value;
            products.Add(product);
            return Created($"api/product/{product.ID}", "Produto cadastrado com sucesso!");
            
        }
        public IActionResult GetNaoVencidos()
        {
            List <Product> Verification = new List<Product>();
            //Tambem podemos usar .Today no lugar do .Now onde Today cosidera somente a data e o Now as horas
            Verification = products.Where(X => X.Validity >= DateTime.Today).ToList();
            if (Verification.Count == 0)
            {
                return NoContent();
            }
            return Ok(Verification);
        }
    }
}
