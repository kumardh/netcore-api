using Fundamental.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;

namespace WebApi
{
    public class Startup
    {
        private readonly IConfiguration config;
        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Below is an example of how to add a service with reads UrlSettings section of appsetting json and bind to UrlSettings type.
            services.AddSingleton<UrlSettings>(config.GetSection("UrlSettings").Get<UrlSettings>());

            // You can also achive this using Options patterns as below.
            services.Configure<UrlSettings>(config.GetSection("UrlSettings"));

            // This is being used in MW1 middlware
            services.Configure<S1>(config.GetSection("S1"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger, UrlSettings urlSettings, IOptions<UrlSettings> options)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Add below middleware if you want to expose static content from App. Once add you can access img.jpg inside images folder.
            app.UseStaticFiles();

            // Below is middle to handle exception globally.
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Something went wrong: {contextFeature.Error}");

                        await context.Response.WriteAsync("ror");
                    }
                });
            });

            // Below is example of passing an item from one middleware to another.
            app.Use(async (context, next) =>
            {
                // Reading appsetting.json section.
                var key1Value = config.GetValue<string>("Key-1");

                // Read value of the binded UrlSettings.
                var productSvcUrl = urlSettings.ProductServiceUrl;
                var customerSvcUrl = options.Value.CustomerServiceUrl;
                context.Items["ABC"] = "abc";
                await next();
            });

            app.Run(async (context) =>
            {
                // Uncomment below line of code to prove InProcess hosting (iisexpress/w3wp) or OutOfprocess (dotnet).
                // await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                await context.Response.WriteAsync(context.Items["ABC"].ToString());
            });

            // Above two middleware can be added to separate class and can be add as below.
            app.UseMW1();
            app.UseMW2();
        }
    }

    public class UrlSettings
    {
        public string ProductServiceUrl { get; set; }
        public string CustomerServiceUrl { get; set; }
    }
}
