using System;
using Xunit;

namespace cicd_sample.Tests
{
    public class CalculationTest
    {
        [Fact(DisplayName ="足し算が正しく行われること")]
        public void Test1()
        {
            var testTarget = new Calculation(1, 2);
            Assert.Equal(3, testTarget.Add());
        }
    }
}
