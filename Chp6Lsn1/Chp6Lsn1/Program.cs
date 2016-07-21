using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp6Lsn1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int N = UsesrInput(n);
            Console.ReadLine();
            //PrintSequence(N);
        }

        public static int UsesrInput(int N)
        {
            int isInput;
            bool resolved = false;
            Console.WriteLine("Please enter an integer.");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt)
                {
                    N = isInput;
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    resolved = false;
                }
            }

            return N;
        }

        public static void PrintSequence(int N)
        {
            int i = 1;

            do
            {
                Console.Write(i);
                i++;
            } while (i <= N);
        }
    }
}
