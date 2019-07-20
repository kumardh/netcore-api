using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamental.Middleware
{
    public class MW2
    {
        private readonly RequestDelegate next;
        public MW2(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<MW1> logger)
        {
            logger.LogInformation("MW-2");
            await context.Response.WriteAsync($"{context.Items["Key-1"]}");
        }
    }

    public static class MW2Extensions
    {
        public static IApplicationBuilder UseMW2(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MW2>();
        }
    }
}
