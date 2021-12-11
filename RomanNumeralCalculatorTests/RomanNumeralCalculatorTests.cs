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
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralToInteger("MMCDLXXXVIII");

            //ASSERT
            Assert.Equal(2488, answer);
        }

        [Fact]
        public void Does_Integer_Convert_To_Roman_Numeral()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.IntegerToRomanNumeral(53);

            //ASSERT
            Assert.Equal("LIII", answer);
        }

        [Fact]
        public void Is_Exception_Thrown_If_Value_Is_Over_3999()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var ex = Assert.Throws<InvalidOperationException>(() =>romanNumeralCalc.IntegerToRomanNumeral(4000));

            //ASSERT
            Assert.Equal("Roman numeral notation cannot exceed 3999 or represent 0", ex.Message);
        }

        [Fact]
        public void Does_Function_Add_Roman_Numerals()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralAdd(53, 88, 120, 10);

            //ASSERT
            Assert.Equal("CCLXXI", answer);
        }

        [Fact]
        public void Does_Function_Subtract_Roman_Numerals()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralSubtract(120, 3, 14);

            //ASSERT
            Assert.Equal("CIII", answer);
        }

        [Fact]
        public void Does_Function_Multiply_Roman_Numerals()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralMultiply(15, 7, 2);

            //ASSERT
            Assert.Equal("CCX", answer);
        }
    }
}
