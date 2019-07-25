using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace WebApi.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public async Task ValuesController_GetAll()
        {
            // Arrange
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/api/values");

            // Act
            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("[\"value1\",\"value3\"]", result);            
        }

        [Fact]
        public async Task ValuesController_GetValueById()
        {
            // Arrange
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/api/values/5");

            // Act
            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("value", result);
        }
    }
}
