using RomanNumeralCalculator;
using System;
using Xunit;

namespace RomanNumeralCalculatorTests
{
    public class RomanNumeralTests
    {
        [Fact]
        public void Does_RomanNumeral_Convert_To_Integer()
        {
            //ARRANGE
            var romanNumeralCalc = new Calculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralToInteger("MMCDLXXXVIII");

            //ASSERT
            Assert.Equal(2488, answer);
        }


    }
}
