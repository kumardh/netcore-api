using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Fundamental.Middleware
{
    public class MW1
    {
        private readonly RequestDelegate next;
        public MW1(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<MW1> logger, IConfiguration config, IOptions<S1> s1)
        {
            var t1 = s1.Value.T1;
            logger.LogInformation("MW-1");
            await next(context);
        }
    }

    public static class MW1Extensions
    {
        public static IApplicationBuilder UseMW1(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MW1>();
        }
    }

    public class S1
    {
        public string T1 { get; set; }
        public string T2 { get; set; }
    }
}
