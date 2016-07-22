using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp6Lsn3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int initialValue = 0;
            int[] N = UsesrInput(initialValue);
            int[] endValues = SmallestAndLargest(N);
            PrintSequence(endValues);
        }

        /// <summary>
        /// Takes in a series of values provided by the user.
        /// </summary>
        /// <param name="iV">Initial value for initial values sake.</param>
        /// <returns>An array created by the user.</returns>
        public static int[] UsesrInput(int iV)
        {
            int isInput;
            bool resolved = false;
            int[] userSeries = new int[2];
            int i = 0;
            int m = 1;
            Console.WriteLine("Please enter a series of positive integers. When finished enter the word 'done'.");

            while (resolved == false)
            {
                int numColumns = userSeries.GetLength(0);
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt)
                {
                    if (m > numColumns)
                    {
                        Array.Resize(ref userSeries, i + 1);
                    }
                    userSeries[i] = isInput;
                    i++;
                    m++;
                }
                else if (input == "done")
                {
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            return userSeries;
        }

        /// <summary>
        /// Finds the smallest and largest integers in the given array.
        /// </summary>
        /// <param name="N">Provided Array</param>
        /// <returns>Smallest and largest integers inside of a new array.</returns>
        public static int[] SmallestAndLargest(int[] N)
        {
            int[] endValues = new int[2];
            int minInt = N[0];
            int maxInt = N[0];

            foreach (int i in N)
            {
                if (i < minInt) minInt = i;
                if (i > maxInt) maxInt = i;
            }

            endValues[0] = minInt;
            endValues[1] = maxInt;

            return endValues;
        }

        /// <summary>
        /// Prints the given array to the console.
        /// </summary>
        /// <param name="N">Array containing the largest and smallest integers.</param>
        public static void PrintSequence(int[] N)
        {
            string foo = String.Join(", ", N);
            Console.WriteLine(foo);

            Console.ReadLine();
        }
    }
}
