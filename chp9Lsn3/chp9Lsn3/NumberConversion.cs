using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp9Lsn3
{
    public class NumberConversion
    {
        static void Main(string[] args)
        {
            int value = UserInput();
            value = CaptureLastDigit(value);
            string englishName = NameOfDigit(value);
            PrintWord(englishName);

        }

        /// <summary>
        /// Takes a value from the user.
        /// </summary>
        /// <returns>Integer</returns>
        public static int UserInput()
        {
            int isInput = 0;
            bool resolved = false;
            Console.WriteLine("Please enter an integer.");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt && isInput > 0)
                {
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    resolved = false;
                }
            }

            return isInput;
        }

        /// <summary>
        /// Gets the remainder of the incoming integer when divided by ten.
        /// </summary>
        /// <param name="number">Integer</param>
        /// <returns>Last digit of the number.</returns>
        public static int CaptureLastDigit(int number)
        {
            number %= 10;
            return number; 
        }

        /// <summary>
        /// Gives the English name of the given number.
        /// </summary>
        /// <param name="digit">Single Digit</param>
        /// <returns>String</returns>
        public static string NameOfDigit(int digit)
        {
            string[] numberWords = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            string numberWord = numberWords[digit];
            return numberWord;
        }

        /// <summary>
        /// Gives the user the English word of the final digit of their number.
        /// </summary>
        /// <param name="numberWord">A word representing a number from 0-9.</param>
        public static void PrintWord(string numberWord)
        {
            Console.Write("The English name of the last digit is '{0}'", numberWord);
            Console.Read();
        }
    }
}
