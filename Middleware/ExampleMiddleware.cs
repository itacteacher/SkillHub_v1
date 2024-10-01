namespace SkillHub.Middleware;
// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
public class ExampleMiddleware
{
    private readonly RequestDelegate _next;

    public ExampleMiddleware (RequestDelegate next)
    {
        _next = next;
    }

    public Task Invoke (HttpContext httpContext)
    {
        //Do some actions here
        return _next(httpContext);
    }
}

// Extension method used to add the middleware to the HTTP request pipeline.
public static class ExampleMiddlewareExtensions
{
    public static IApplicationBuilder UseExampleMiddleware (this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExampleMiddleware>();
    }
}
