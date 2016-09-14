using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCommunication;

namespace Chp12Lsn7
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;

            try
            {
                userNumber = UserBarrier.UserInput();
            }
            catch (ArgumentException lessThanZero)
            {
                Console.WriteLine(lessThanZero.Message);
                throw;
            }

            double finalAnswer = CalculateSquareRoot(userNumber);

            UserBarrier.PrintAnswer(finalAnswer, userNumber);
        }

        public static double CalculateSquareRoot(int numberToSqrt)
        {
            if (numberToSqrt <= 0)
            {
                throw new ArgumentException("Invalid Input! Cannot enter a number less than or equal to zero.");
            }

            double finalAnswer = Math.Sqrt(numberToSqrt);
            return finalAnswer;
        }
    }
}
