using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCommunication;

namespace Chp12Lsn7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            string emptyValue = null;

            try
            {
                userNumber = UserBarrier.UserInput(emptyValue);
            }
            catch (ArgumentException lessThanZero)
            {
                Console.WriteLine(lessThanZero.Message);
                throw;
            }
            catch (FormatException invalidCharacter)
            {
                Console.WriteLine(invalidCharacter.Message);
                throw;
            }
            catch (OverflowException tooLargeOrSmall)
            {
                Console.WriteLine(tooLargeOrSmall.Message);
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
