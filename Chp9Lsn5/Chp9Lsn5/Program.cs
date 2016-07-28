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

            IsLargerThan(randomArray, i);
        }

        public static int UserInput()
        {
            int isInput = 10;
            bool resolved = false;
            Console.WriteLine("Please enter an index number (0-9). This will check if it is larger than both its neighbors in a number circle.");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt && isInput > -1 && isInput < 10)
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
