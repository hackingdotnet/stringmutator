using System;
using Xunit;
using StringMutator.Extension;

namespace StringMutator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string welcome = "Welcome to the\nString Mutator.";

            Assert.Equal(2, welcome.Lines().Length);
        }
    }
}
