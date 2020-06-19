using System;
using Xunit;
using AddService;

namespace AddServiceTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddTwoNumbers()
        {
            Assert.Equal(8, Adder.Add(3, 5));
        }
    }
}
