using Microsoft.Extensions.Options;

namespace Aula26_CORS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var/* <- WebAplicationBuilder*/ builder = WebApplication.CreateBuilder(args);

            //Um API C# é iniciada com a classe WebApplicationBuilder
            //Nele fazemos uso do atributo Services, que é do tipo IServiceCollection, que utilizamos para adicionar configurações e dependências da aplicação

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //AddCors  esse método recebe  uma expressão lambda(=>) do tipo CorsOptions
            //dentro da expressão lambda podemos acessar o método AddPolicy
            //CorsPolicyBuilder - Com esse objeto podemos acessar vários métodos de forma encadeada
            //para configurar a política de CORS.

            //AllowAnyHeader - define a política que permite requisições qualquer header.
            //AllowAnyMethod - define a política que permite requisições qualquer metodo HTTP.
            //AllowAnyOrigin - define a política que permite requisições qualquer origem(Qualquer tipo de site pode acessar a API).

            //WithHeaders - Recebe um vetor de string como parametro, e define que a politica permita o acesso de qualquer header definido no vetor de string 
            //WithMethods - Recebe um vetor de string como parametro, e define que a politica permita o acesso de qualquer método definido no vetor de string
            //WithOrigins - Recebe um vetor de string como parametro, e define que a politica permita o acesso de qualquer origem definido no vetor de string
            builder.Services.AddCors(options => 
            {
                options.AddPolicy("Cors-1", 
                    builder => 
                    { 
                        builder.AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowAnyOrigin();
                    });

                options.AddPolicy("Cors-2", 
                    builder =>
                    {
                        string[] headers = new string[]
                        {
                            "Token",
                            "ContentType"
                        };
                        string[] methods = new string[]
                        {
                            "GET"
                        };
                        string[] origins = new string[]
                        {
                            ""
                        };
                        builder.WithHeaders(headers)
                               .WithMethods(methods)
                               .WithOrigins(origins);
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("Cors-1");
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}