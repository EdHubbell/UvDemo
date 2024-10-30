using System.Drawing;
using FluentAssertions;

namespace xUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }


        [Theory]

        // Test conditions
        [InlineData(@"A", @"A", true)]
        [InlineData(@"A", @"B", false)]

        public void ProcessScannedDataTest_ValidData(string sVal1, string sVal2, bool areEqual)
        {
            // Arrange 

            // Act

            // Assert

            bool bAreEqual = sVal1 == sVal2;

            bAreEqual.Should().Be(areEqual);

        }


    }
}