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
            PrintSequence(N);
        }

        public static int[] UsesrInput(int iV)
        {
            int isInput;
            bool resolved = false;
            int[] userSeries = new int[2];
            int i = 0;
            Console.WriteLine("Please enter a series of positive integers. When finished enter the word 'done'.");

            while (resolved == false)
            {
                int numColumns = userSeries.GetLength(0);
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt)
                {
                    userSeries[i] = isInput;
                    i++;

                    if (i > numColumns - 1)
                    {
                        Array.Resize(ref userSeries, i + 1);
                    }
                }
                else if (input == "done")
                {
                    i++;
                    Array.Resize(ref userSeries, i - 1);
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            return userSeries;
        }

        public static void PrintSequence(int[] N)
        {
            string foo = String.Join(", ", N);
            Console.WriteLine(foo);

            Console.ReadLine();
        }
    }
}
