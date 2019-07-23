using System;
using Xunit;

namespace WebApi.Tests.SharedContextTests
{
    // Sometimes test context creation and cleanup can be very expensive. If you were 
    // to run the creation and cleanup code during every test, it might make the tests 
    // slower than you want. You can use the class fixture feature of xUnit.net to 
    // share a single object instance among all tests in a test class.

    // We already know that xUnit.net creates a new instance of the test class for 
    // every test.When using a class fixture, xUnit.net will ensure that the fixture 
    // instance will be created before any of the tests have run, and once all the 
    // tests have finished, it will clean up the fixture object by calling Dispose, if present.

    public class ClassFixtureTests : IClassFixture<DatabaseFixture>
    {
        DatabaseFixture fixture;

        public ClassFixtureTests(DatabaseFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, fixture.Counter);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, fixture.Counter);
        }
    }
}
