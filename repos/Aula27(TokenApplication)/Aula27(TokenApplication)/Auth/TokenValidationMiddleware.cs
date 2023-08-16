using Microsoft.Extensions.Configuration;
using System.Net;

namespace Aula27_TokenApplication_.Auth
{
    public class TokenValidationMiddleware
    {

        //Token - é sua senha de acesso à API, como não é algo que o usuário terá que ficar lembrando e digitando, pode ser bem grande(100 caracteres) e complexo.
        //Também carrega informações extras que podem ajudar na autorização.

        //Readonly - equivale a uma constante(const)
        private readonly RequestDelegate _next;
        //Tem as informamações do appsettings.json
        private readonly IConfiguration _configuration;

        public TokenValidationMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;   
            _configuration = configuration;
        }
        public async Task Invoke(HttpContext context)
        {
            string token = _configuration.GetValue<string>("ApiToken");
            if (context.Request.Headers["Token"] == token)
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Token inválido!");
            }
        }
    }
}
