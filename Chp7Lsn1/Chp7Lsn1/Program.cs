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

        public static int[] FillArray(int[] arrayEmpty)
        {
            for(int i = 0; i < 20; i++)
            {
                arrayEmpty[i] = i * 5;
            }

            int[] arrayFull = arrayEmpty;
            return arrayFull;
        }

        public static void DisplayArray(int[] displayArray)
        {
            for (int mulFive = 0; mulFive < 20; mulFive++)
            {
                Console.Write("{0} ", displayArray[mulFive]);
            }

            Console.ReadLine();
        }
    }
}
