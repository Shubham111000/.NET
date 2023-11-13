namespace WebApplication1.Models
{
    public class CustomeModelwareDemo : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
           // await next(context);
            await context.Response.WriteAsync("hello world");
            
        }
    }
}
