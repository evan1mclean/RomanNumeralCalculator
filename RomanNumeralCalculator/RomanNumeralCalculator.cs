using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralCalculator
{
    public class Calculator
    {

        //public string[] OnesDigits = { };

        Dictionary<char, int> RomanValues = new Dictionary<char, int>();

        public int RomanNumeralToInteger(string RomanNumeral)
        {
            //note to self: add does not work outside of a function
            RomanValues.Add('I', 1);
            RomanValues.Add('V', 5);
            RomanValues.Add('X', 10);
            RomanValues.Add('L', 50);
            RomanValues.Add('C', 100);
            RomanValues.Add('D', 500);
            RomanValues.Add('M', 1000);

            if (RomanNumeral.Length == 0) return 0;

            //loop through from right to left, if new number is less than previous number, subtract value. Else, add value
            int decimalValue = 0;
            int lastValue = 0;
            for (int i = RomanNumeral.Length - 1; i >= 0; i--)
            {
                int newValue = RomanValues[RomanNumeral[i]];

                if (newValue < lastValue)
                {
                    decimalValue -= newValue;
                }
                else
                {
                    decimalValue += newValue;
                    lastValue = newValue;
                }
            }

            return decimalValue;
        }
    }
}
