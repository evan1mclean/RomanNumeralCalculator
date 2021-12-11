using System;

namespace RomanNumeralCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanNumeralCalc = new Calculator();
            Console.WriteLine(romanNumeralCalc.IntegerToRomanNumeral(78));
        }
    }
}
