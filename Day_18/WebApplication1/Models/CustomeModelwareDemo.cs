namespace WebApplication1.Models
{
    public class CustomeModelwareDemo : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
          await context.Response.WriteAsync("Abhya Maji Bayko");
            await next(context);
        }
    }
}
