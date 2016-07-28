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
            int[] firstArray = { 2, 5, 2, 3, 4, 2, 8, 9, 7, 9 };
        }

        public static bool IsLargerThan(int[] randomArray, int i)
        {
            if(i == 0 || i == 9)
            {
                return OutsideCase(randomArray, i);
            }

            if (randomArray[i] > randomArray[i + 1] && randomArray[i] > randomArray[i - 1])
            {
                return true;
            }

            return false;
        }

        public static bool OutsideCase(int[] randomArray, int i)
        {
            int innerValue = 8;
            int outerValue = 0;
            if (i == 0)
            {
                innerValue = 9;
                outerValue = 1;
            }

            if (randomArray[i] > randomArray[innerValue] && randomArray[i] > randomArray[outerValue])
            {
                return true;
            }

            return false;
        }
    }
}
