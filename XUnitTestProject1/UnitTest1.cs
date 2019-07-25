using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private int counter =0 ;
        public UnitTest1()
        {
            
        }

        [Fact]
        public void Test1()
        {
            counter++;
            Assert.Equal("A", "A");
            Assert.Equal(1, counter);
        }

        [Fact]
        public void Test2()
        {
            counter++;
            Assert.Equal("A", "A");
            Assert.Equal(2, counter);
        }
    }
}
