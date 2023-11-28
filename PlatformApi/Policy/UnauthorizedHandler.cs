using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;

namespace PlatformApi.Policy
{
    public class UnauthorizedHandler : IAuthorizationMiddlewareResultHandler
    {
        public async Task HandleAsync(RequestDelegate next, HttpContext context, AuthorizationPolicy policy, PolicyAuthorizationResult authorizationResult)
        {
            if (context.User.Identity?.IsAuthenticated != true)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("You need to login");
                return;

            }
            await next(context);
        }
    }


}