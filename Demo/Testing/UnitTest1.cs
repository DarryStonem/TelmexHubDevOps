using System;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void SumTest()
        {
            var sum = 1 + 1;
            Assert.True(sum == 2);
        }
    }
}