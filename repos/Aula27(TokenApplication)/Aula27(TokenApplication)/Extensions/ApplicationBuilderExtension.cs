using Aula27_TokenApplication_.Auth;

namespace Aula27_TokenApplication_.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseTokenAuth(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenValidationMiddleware>();
        }
    }
}
