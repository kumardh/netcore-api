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
            var projectDir = Directory.GetCurrentDirectory();
            var configPath = Path.Combine(projectDir, "appsettings.json");
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>().ConfigureAppConfiguration((context, conf) =>
            {
                conf.AddJsonFile(configPath);
            }));
            Client = server.CreateClient();
        }
    }
}
