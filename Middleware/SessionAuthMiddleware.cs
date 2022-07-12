using Intro.Services;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Intro.Middleware
{
    public class SessionAuthMiddleware
    {
        // обяательное поле (для Middleware)
        private readonly RequestDelegate next;

        // обязательная форма конструктора 
        public SessionAuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, IAuthService authService)
        {
            string userId = context.Session.GetString("userId");
                if(userId != null)
            {
                authService.Set(userId);
            }
            context.Items.Add("fromAuthMiddleware", "Hello !!!");
            await next(context);
        }
    }
}
