using System;

namespace RomanNumeralCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanNumeralCalc = new RomanNumeralCalculator();
            Console.WriteLine("This is a program that adds Roman numerals. Please enter your roman numerals separated by spaces.");
            Console.WriteLine("The program will run until you type 'close'." + "\n");
            Console.WriteLine("Enter inputs: ");
            string inputLine = Console.ReadLine();
            while (inputLine != "close")
            {
                string[] romanNumerals = inputLine.Split(' ');
                Console.WriteLine(romanNumeralCalc.RomanNumeralAdd(romanNumerals) + "\n");
                Console.WriteLine("Enter another value");
                Console.WriteLine("To close the program, type 'close'. " + "\n");
                Console.WriteLine("Enter inputs: ");
                inputLine = Console.ReadLine();
            }
        }
    }
}
