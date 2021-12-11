using System;

namespace RomanNumeralCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanNumeralCalc = new RomanNumeralCalculator();
            Console.WriteLine(romanNumeralCalc.IntegerToRomanNumeral(232));
        }
    }
}
