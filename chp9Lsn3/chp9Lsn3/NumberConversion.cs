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

        public static int CaptureLastDigit(int number)
        {
            number %= 10;
            return number; 
        }

        public static string NameOfDigit(int digit)
        {
            string digitName = "Error";

            switch (digit)
            {
                case 0:
                    digitName = "Zero";
                    break;
                case 1:
                    digitName = "One";
                    break;
                case 2:
                    digitName = "Two";
                    break;
                case 3:
                    digitName = "Three";
                    break;
                case 4:
                    digitName = "Four";
                    break;
                case 5:
                    digitName = "Five";
                    break;
                case 6:
                    digitName = "Six";
                    break;
                case 7:
                    digitName = "Seven";
                    break;
                case 8:
                    digitName = "Eight";
                    break;
                case 9:
                    digitName = "Nine";
                    break;
                default:
                    digitName = "Error";
                    break;
            }

            return digitName;
        }

        public static void PrintWord(string numberWord)
        {
            Console.Write("The English name of the last digit is '{0}'", numberWord);
            Console.Read();
        }
    }
}
