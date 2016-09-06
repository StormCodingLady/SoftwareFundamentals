using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp9Lsn5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = UserInput();
            int[] randomArray = { 2, 5, 2, 3, 4, 2, 8, 9, 7, 9 };

            bool greaterLesser = IsLargerThan(randomArray, i);
            UserAnswer(greaterLesser);
        }

        /// <summary>
        /// Takes an index number from user.
        /// </summary>
        /// <returns>number 0-9</returns>
        public static int UserInput()
        {
            int isInput = 10;
            bool resolved = false;
            Console.WriteLine("Please enter an index number (0-9). This will check if it is larger than both its neighbors in a number circle.");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt && isInput >= 0 && isInput < 10)
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
        /// Discovers if the number within the index is larger than its neighbors.
        /// </summary>
        /// <param name="randomArray">Given Array</param>
        /// <param name="i">Index</param>
        /// <returns>true or false</returns>
        public static bool IsLargerThan(int[] randomArray, int i)
        {
            int innerValue = (i - 1) % 10;
            int outerValue = (i + 1) % 10;

            if( i > randomArray[innerValue] && i > randomArray[outerValue])
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gives the user the answer as to whether or not the selected number is greater than its neighbors.
        /// </summary>
        /// <param name="greaterLesser">IsLargerThan final evaluation</param>
        public static void UserAnswer(bool greaterLesser)
        {
            Console.WriteLine("Is larger than neighbors? {0}!", greaterLesser);
            Console.Read();
        }
    }
}
