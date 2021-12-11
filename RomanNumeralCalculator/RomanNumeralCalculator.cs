using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralCalculator
{
    public class Calculator
    {
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

        public string[] OnesDigits = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        public string[] TensDigits = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        public string[] HundredsDigits = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        public string[] ThousandsDigits = { "", "M", "MM", "MMM" };

        public string IntegerToRomanNumeral(int x)
        {
            if (x >= 4000)
            {
                throw new InvalidOperationException("Roman numeral notation cannot exceed 3999");
            }

            string romanNumeralValue = "";

            //thousands place
            int num;
            num = x / 1000;
            romanNumeralValue += ThousandsDigits[num];
            x %= 1000;

            //hundreds place
            num = x / 100;
            romanNumeralValue += HundredsDigits[num];
            x %= 100;

            //tens place
            num = x / 10;
            romanNumeralValue += TensDigits[num];
            x %= 10;

            //ones place
            romanNumeralValue += OnesDigits[x];

            return romanNumeralValue;
        }
    }
}
