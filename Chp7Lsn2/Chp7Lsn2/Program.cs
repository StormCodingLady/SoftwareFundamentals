using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp7Lsn2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[2][];
            int[][] toCompare = UsesrInput(jaggedArray);
            bool isEqual = EquivalentCheck(toCompare);
            ReadOut(toCompare, isEqual);
        }

        public static int[][] UsesrInput(int[][] jaggedArray)
        {
            int isInput;
            bool resolved = false;
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[1];
            int i = 0;
            int index = 0;
            Console.WriteLine("Please enter a series of integers for your first array. When finished enter");
            Console.WriteLine("the word 'done'. Repeat for the second Array.");

            while (resolved == false)
            {
                int numColumns = jaggedArray[index].GetLength(0);
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt)
                {
                    if (i + 1 > numColumns)
                    {
                        Array.Resize(ref jaggedArray[index], i + 1);
                    }
                    jaggedArray[index][i] = isInput;
                    i++;
                }
                else if (input == "done" && index == 1)
                {
                    resolved = true;
                }
                else if (input == "done")
                {
                    i = 0;
                    index++;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            return jaggedArray;
        }

        public static bool EquivalentCheck(int[][] toCompare)
        {
            int lengthZero = toCompare[0].GetLength(0);

            if(toCompare[0].GetLength(0) == toCompare[1].GetLength(0))
            {
                for (int i = 0; i < lengthZero; i++)
                {
                    bool isEqual = toCompare[0][i] == toCompare[1][i];
                    if(isEqual == false)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static void ReadOut(int[][] toRead, bool isEqual)
        {
            int index = 0;

            while (index < 2) {
                for (int i = 0; i < toRead[index].GetLength(0); i++)
                {
                    Console.Write("{0} ", toRead[index][i]);
                }
                index++;
                Console.WriteLine("");
            }

            Console.WriteLine("Is Equal? {0}.", isEqual);
            Console.ReadLine();
        }
    }
}
