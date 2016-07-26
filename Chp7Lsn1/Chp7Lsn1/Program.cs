using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp7Lsn1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayEmpty = new int[20];

            int [] displayArray = FillArray(arrayEmpty);
            DisplayArray(displayArray);
        }

        public static int[] FillArray(int[] numbers)
        {
            for(int i = 0; i < 20; i++)
            {
                numbers[i] = i * 5;
            }
            return numbers;
        }

        public static void DisplayArray(int[] displayArray)
        {
            for (int multiplyNumber = 0; multiplyNumber < 20; multiplyNumber++)
            {
                Console.Write("{0} ", displayArray[multiplyNumber]);
            }

            Console.ReadLine();
        }
    }
}
