using System;
using System.Collections.Generic;
using Xunit;

namespace WebApi.Tests.SharedContextTests
{
    // xUnit.net creates a new instance of the test class for every test that is run, so any code 
    // which is placed into the constructor of the test class will be run for every single test. 

    public class CtorDisposeTests : IDisposable
    {
        private Stack<int> stack;

        public CtorDisposeTests()
        {
            stack = new Stack<int>();
        }

        public void Dispose()
        {
            stack = null;
        }

        [Fact]
        public void WithNoItems_CountShouldReturnZero()
        {
            var count = stack.Count;

            Assert.Equal(0, count);
        }

        [Fact]
        public void AfterPushingItem_CountShouldReturnOne()
        {
            stack.Push(42);

            var count = stack.Count;

            Assert.Equal(1, count);
        }
    }
}
