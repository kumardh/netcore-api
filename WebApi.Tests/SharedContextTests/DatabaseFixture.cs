using System;

namespace WebApi.Tests.SharedContextTests
{
    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            Counter++;
            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }

        public int Counter { get; private set; } = 0;
    }
}
