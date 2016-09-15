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
                Console.WriteLine("");
                Console.WriteLine("Thank You!");
            }

            return userNumber;
        }

        public static void PrintAnswer(double answerToPrint, int userNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("The square root of '{0}' is '{1}'", userNumber, answerToPrint);
            Console.Read();
        }
    }
}
