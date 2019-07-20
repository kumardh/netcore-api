using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace webApi.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public async Task ValuesController_GetAll()
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/api/values");
            var x = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
    }
}
