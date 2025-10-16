public class MyFirstMiddleware(ILogger<MyFirstMiddleware> logger) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        // Before

        logger.LogInformation(context.Request.Path);

        await next(context);

        // After
    }
}