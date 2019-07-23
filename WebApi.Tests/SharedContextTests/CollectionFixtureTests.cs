using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WebApi.Tests.SharedContextTests
{
    // When to use: when you want to create a single test context and share it among tests
    // in several test classes, and have it cleaned up after all the tests in the test 
    // classes have finished.

    [CollectionDefinition("Database collection")]
    public class DatabaseCollection : ICollectionFixture<DatabaseFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

    [Collection("Database collection")]
    public class CollectionFixtureClass1
    {
        DatabaseFixture fixture;

        public CollectionFixtureClass1(DatabaseFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void CollectionFixtureClass1_Test()
        {
            Assert.Equal("A", "A");
        }
    }

    [Collection("Database collection")]
    public class CollectionFixtureClass2
    {
        DatabaseFixture fixture;

        public CollectionFixtureClass2(DatabaseFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void CollectionFixtureClass2_Test()
        {
            Assert.Equal("A", "A");
        }
    }
}
