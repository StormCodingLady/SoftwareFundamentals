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
            int m = UsesrInput(n);
            int[] N = CalcSequence(m);
            PrintSequence(N, m);
        }

        public static int UsesrInput(int N)
        {
            int isInput;
            bool resolved = false;
            Console.WriteLine("Please enter a positive integer.");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt && isInput > 0)
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

        public static void PrintSequence(int[] N, int n)
        {
            //int i = 0;

            //do
            //{
            //    Console.Write("{0}, ", N[i]);
            //    i++;
            //} while (i < n - 1);
            //Console.Write("{0}", n);

            string foo = String.Join(", ", N);
            Console.WriteLine(foo);

            Console.ReadLine();
        }

        public static int[] CalcSequence(int N)
        {
            int i = 1;
            int[] holdSequence = new int[N];

            do
            {
                holdSequence[i-1] = i;
                i++;
            } while (i <= N);

            return holdSequence;
        }
    }
}
