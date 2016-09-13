using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp12Lsn7
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput();
            Console.ReadLine();
        }

        public static int UserInput()
        {
            Console.WriteLine("Please enter a positive integer greater than zero.");
            Console.WriteLine("");
            Console.Write("> ");
            string userInput = Console.ReadLine();
            int userNumber = 0;

            try
            {
                userNumber = Convert.ToInt32(userInput);
                
                if(userNumber <= 0)
                {
                    throw new ArgumentException();
                }

                if (userNumber > Int32.MaxValue || userNumber < Int32.MinValue)
                {
                    throw new OverflowException();
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Input! Cannot enter a number less than or equal to zero.");
                throw;
            }
            catch(FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Input! Cannot enter non-numbers or non-integers.");
                throw;
            }
            catch(OverflowException)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Input! Cannot enter integers larger than or less then computers max/min value.");
                throw;
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Thank You! Press any key to continue.");
                Console.Read();
            }

            return userNumber;
        }

        public static void CalculateSquareRoot()
        {

        }
    }
}
