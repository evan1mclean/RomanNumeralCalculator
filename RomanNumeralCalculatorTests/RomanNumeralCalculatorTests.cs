using RomanNumeralCalculator;
using System;
using Xunit;

namespace RomanNumeralCalculatorTests
{
    public class RomanNumeralTests
    {
        [Fact]
        public void Does_Roman_Numeral_Convert_To_Integer()
        {
            //ARRANGE
            var romanNumeralCalc = new Calculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralToInteger("MMCDLXXXVIII");

            //ASSERT
            Assert.Equal(2488, answer);
        }

        [Fact]
        public void Does_Integer_Convert_To_Roman_Numeral()
        {
            //ARRANGE
            var romanNumeralCalc = new Calculator();

            //ACT
            var answer = romanNumeralCalc.IntegerToRomanNumeral(53);

            //ASSERT
            Assert.Equal("LIII", answer);
        }

        [Fact]
        public void Is_Exception_Thrown_If_Value_Is_Over_3999()
        {
            //ARRANGE
            var romanNumeralCalc = new Calculator();

            //ACT
            var ex = Assert.Throws<InvalidOperationException>(() =>romanNumeralCalc.IntegerToRomanNumeral(4000));

            //ASSERT
            Assert.Equal("Roman numeral notation cannot exceed 3999", ex.Message);
        }
    }
}
