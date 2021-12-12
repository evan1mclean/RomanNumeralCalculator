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
        public void Is_Exception_Thrown_If_Character_Is_Repeated_More_Than_Three_Times()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var ex = Assert.Throws<InvalidOperationException>(() => romanNumeralCalc.RomanNumeralToInteger("IIII"));

            //ASSERT
            Assert.Equal("Please use proper subtractive notation. A character can only be repeated a maximum of 3 times in a row. e.g. 'IIII' should be 'IV'.", ex.Message);
        }

        [Fact]
        public void Is_Exception_Thrown_If_Improper_Character_Is_Used()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var ex = Assert.Throws<InvalidOperationException>(() => romanNumeralCalc.RomanNumeralToInteger("IVtr"));

            //ASSERT
            Assert.Equal("Please input proper Roman numeral values. i.e. I, V, X, L, C, D, and M", ex.Message);
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
            Assert.Equal("Roman numeral notation cannot exceed 3999 or represent 0 and negative numbers", ex.Message);
        }

        [Fact]
        public void Does_Function_Add_Roman_Numerals()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralAdd("V", "X", "III", "V");

            //ASSERT
            Assert.Equal("XXIII", answer);
        }

        [Fact]
        public void Does_Function_Subtract_Roman_Numerals()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralSubtract("CXX", "III", "XIV");

            //ASSERT
            Assert.Equal("CIII", answer);
        }

        [Fact]
        public void Does_Function_Multiply_Roman_Numerals()
        {
            //ARRANGE
            var romanNumeralCalc = new RomanNumeralCalculator.RomanNumeralCalculator();

            //ACT
            var answer = romanNumeralCalc.RomanNumeralMultiply("XV", "VII", "II");

            //ASSERT
            Assert.Equal("CCX", answer);
        }
    }
}
