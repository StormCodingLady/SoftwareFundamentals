using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            int userInput = UserInput(a);
            string verbFeed = EngRet(userInput);
            Console.WriteLine();
            Console.WriteLine("Your number in written form is '{0}'.", verbFeed);
            Console.ReadLine();
        }
        
        public static int UserInput(int a)
        {

            int intInput;
            bool noError = false;

            while (noError == false)
            {
                Console.WriteLine("Enter an integer that ranges from 0-9.");
                Console.WriteLine(" ");
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out intInput);
                if (isInt && intInput <= 9 && intInput >= 0)
                {   
                    a = intInput;
                    noError = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }

            }
            return a;   
        }

        public static string EngRet(int userInput)
        {
           string givBak;

           switch (userInput)
            {
                case 0:
                    givBak = "Zero";
                    break;

                case 1:
                    givBak = "One";
                    break;

                case 2:
                    givBak = "Two";
                    break;

                case 3:
                    givBak = "Three";
                    break;

                case 4:
                    givBak = "Four";
                    break;

                case 5:
                    givBak = "Five";
                    break;

                case 6:
                    givBak = "Six";
                    break;

                case 7:
                    givBak = "Seven";
                    break;

                case 8:
                    givBak = "Eight";
                    break;

                case 9:
                    givBak = "Nine";
                    break;

                default:
                    givBak = "Error";
                    break;
            }

            return givBak;
        }
    }
}
