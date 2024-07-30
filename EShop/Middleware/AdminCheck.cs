using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EShop.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AdminCheck
    {
        private readonly RequestDelegate _next;

        public AdminCheck(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var user=(context.User.FindFirst("IsAdmin"));
            if (context.Request.Path.StartsWithSegments("/Admin"))
            {
                if (!context.User.Identity.IsAuthenticated)
                {
                    context.Response.Redirect("/Account/Login");
                    return; // Ensure we don't call the next middleware
                }
                else if (bool.Parse(context.User.FindFirstValue("IsAdmin")!) == false)
                {
                    context.Response.Redirect("/Product");
                }
            }
            await _next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AdminCheckExtensions
    {
        public static IApplicationBuilder UseAdminCheck(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<AdminCheck>();
        }
    }
}
