using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCommunication
{
    public class UserBarrier
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Takes a positive integer from the user and returns it.
        /// </summary>
        /// <param name="userInput">A null string. Value is changed within method. Allows for unit testing.</param>
        /// <returns>A positive integer</returns>
        public static int UserInput(string userInput)
        {
            Console.WriteLine("Please enter a positive integer greater than zero.");
            Console.WriteLine("");
            Console.Write("> ");

            if (userInput == null)
            {
                userInput = Console.ReadLine();
            }
            int userNumber = 0;

            try
            {
                userNumber = Convert.ToInt32(userInput);

                if (userNumber <= 0)
                {
                    throw new ArgumentException("Invalid Input! Cannot enter a number less than or equal to zero.");
                }

            }
            finally
            {
                Console.WriteLine("\nThank You!");
            }

            return userNumber;
        }

        /// <summary>
        /// Takes the original postive integer and its square root and prints it to the screen.
        /// </summary>
        /// <param name="answerToPrint">Square root of the original integer</param>
        /// <param name="userNumber">Positive integer</param>
        public static void PrintAnswer(double answerToPrint, int userNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("The square root of '{0}' is '{1}'", userNumber, answerToPrint);
            Console.Read();
        }
    }
}
