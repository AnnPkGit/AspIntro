﻿using Microsoft.AspNetCore.Builder;

namespace Intro.Middleware
{
    public static class SessionAuthExtension
    {
        public static IApplicationBuilder UseSessionAuth(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SessionAuthMiddleware>();
        }
    }
}
