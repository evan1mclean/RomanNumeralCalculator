using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralCalculator
{
    public class RomanNumeralCalculator
    {
        Dictionary<char, int> RomanValues = null;

        public int RomanNumeralToInteger(string RomanNumeral)
        {
            //maps roman numeral characters to integer values.
            if (RomanValues == null)
            {
                RomanValues = new Dictionary<char, int>();
                RomanValues.Add('I', 1);
                RomanValues.Add('V', 5);
                RomanValues.Add('X', 10);
                RomanValues.Add('L', 50);
                RomanValues.Add('C', 100);
                RomanValues.Add('D', 500);
                RomanValues.Add('M', 1000);
            }

            //returns 0 if function input is blank string
            if (RomanNumeral.Length == 0) return 0;
            
            //if character is repeated more than 3 times in a row, throws error message
            int counter = 1;
            string prev = "";
            for (int i = 0; i < RomanNumeral.Length; i++)
            {
               string curr = RomanNumeral[i].ToString();
                if (curr == prev)
                {
                    counter += 1;
                    prev = curr;
                }
                else
                {
                    counter = 1;
                    prev = curr;
                }
                if (counter > 3)
                {
                    throw new InvalidOperationException("Please use proper subtractive notation. A character can only be repeated a maximum of 3 times in a row. e.g. 'IIII' should be 'IV'.");
                }
            }

            //loop through from right to left, if new number is less than previous number, subtract value. Else, add value
            int decimalValue = 0;
            int lastValue = 0;
            for (int i = RomanNumeral.Length - 1; i >= 0; i--)
            {
                //throws exception if improper characters are used
                if (!RomanValues.ContainsKey(RomanNumeral[i]))
                {
                    throw new InvalidOperationException("Please input proper Roman numeral values. i.e. I, V, X, L, C, D, and M");
                }

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
            if (x >= 4000 || x <= 0)
            {
                throw new InvalidOperationException("Roman numeral notation cannot exceed 3999 or represent 0 and negative numbers");
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

        //Adds roman numerals
        public string RomanNumeralAdd(params string[] romanNumerals)
        {
            int total = 0;
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                var number = RomanNumeralToInteger(romanNumerals[i]);
                total += number;
            }

            if (total >= 4000)
            {
                throw new InvalidOperationException("Roman numeral notation cannot exceed 3999");
            }

            return IntegerToRomanNumeral(total);
        }

        //Subtracts roman numerals
        public string RomanNumeralSubtract(params string[] romanNumerals)
        {
            int total = RomanNumeralToInteger(romanNumerals[0]);
            for (int i = 1; i < romanNumerals.Length; i++)
            {
                var number = RomanNumeralToInteger(romanNumerals[i]);
                total -= number;
            }

            if (total <= 0)
            {
                throw new InvalidOperationException("Roman numeral notation cannot represent 0 or negative numbers");
            }

            return IntegerToRomanNumeral(total);
        }

        //Multiplies roman numerals
        public string RomanNumeralMultiply(params string[] romanNumerals)
        {
            int total = RomanNumeralToInteger(romanNumerals[0]);
            for (int i = 1; i < romanNumerals.Length; i++)
            {
                total *= RomanNumeralToInteger(romanNumerals[i]);
            }

            if (total >= 4000)
            {
                throw new InvalidOperationException("Roman numeral notation cannot exceed 3999");
            }

            return IntegerToRomanNumeral(total);
        }
    }
}
