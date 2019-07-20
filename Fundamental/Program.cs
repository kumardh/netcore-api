using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {

            /* 
            CreateDefaultBuilder performs the following tasks:

            1. Configures Kestrel server as the web server using the app's hosting configuration providers. For the Kestrel server's default options, see Kestrel web server implementation in ASP.NET Core.
            2. Sets the content root to the path returned by Directory.GetCurrentDirectory.
            3. Loads host configuration from:
                Environment variables prefixed with ASPNETCORE_ (for example, ASPNETCORE_ENVIRONMENT).
                Command-line arguments.
            4. Loads app configuration in the following order from:
                appsettings.json.
                appsettings.{Environment}.json.
                Secret Manager when the app runs in the Development environment using the entry assembly.
                Environment variables.
                Command-line arguments.
            5. Configures logging for console and debug output. Logging includes log filtering rules specified in a Logging configuration section of an appsettings.json or appsettings.{Environment}.json file.
            6. When running behind IIS with the ASP.NET Core Module, CreateDefaultBuilder enables IIS Integration, which configures the app's base address and port. IIS Integration also configures the app to capture startup errors. For the IIS default options, see Host ASP.NET Core on Windows with IIS.
            7. Sets ServiceProviderOptions.ValidateScopes to true if the app's environment is Development. For more information, see Scope validation.
            
            Code Url: https://github.com/aspnet/AspNetCore/blob/master/src/DefaultBuilder/src/WebHost.cs
            */
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }
    }
}
