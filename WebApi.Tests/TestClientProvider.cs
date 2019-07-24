using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http;

namespace WebApi.Tests
{
    public class TestClientProvider
    {
        public HttpClient Client { get; set; }
        public TestClientProvider()
        {
            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            // ASP.NET Core includes a TestServer class in the Microsoft.AspNetCore.TestHost 
            // library which can be used to simulate ASP.NET Core applications for testing 
            // purposes. We can use this to test the whole ASP.NET Core pipeline, without 
            // having to worry about spinning up an actual test website in a different process 
            // to test against.

            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>().ConfigureAppConfiguration((context, conf) =>
            {
                conf.AddJsonFile(configPath);
            }));
            Client = server.CreateClient();
        }
    }
}
