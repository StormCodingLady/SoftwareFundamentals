using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp8Lsn4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = UserInput();
            double[] binaryNumber = DecimalToBinary(decimalNumber);
            DisplayBinaryNumber(binaryNumber, decimalNumber);
        }

        public static int UserInput()
        {
            int isInput = 0;
            bool resolved = false;
            Console.WriteLine("Please enter an integer. The integer will be converted to binary form.");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isInt = System.Int32.TryParse(input, out isInput);

                if (isInt)
                {
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            return isInput;
        }

        public static double[] DecimalToBinary(double numberDecimal)
        {
            double[] binaryHolder = new double[1];
            int i = 0;

            while(numberDecimal >= 1)
            {
                int numColumns = binaryHolder.GetLength(0);
                
                if(i + 1 > numColumns)
                {
                    Array.Resize(ref binaryHolder, i + 1);
                }

                double remainder = numberDecimal % 2; // 1 or 0
                binaryHolder[i] = remainder;
                numberDecimal = Math.Floor(numberDecimal / 2);
                i++;
            }

            Array.Reverse(binaryHolder);
            return binaryHolder;
        }

        public static void DisplayBinaryNumber(double[] binaryNumber, int signIndicator)
        {
            if(signIndicator < 0)
            {
                Console.WriteLine("");
                Console.Write("-");
                String.Join("", binaryNumber);
            }
            else
            {
                Console.WriteLine("");
                String.Join("", binaryNumber);
            }

            Console.ReadLine();
        }
    }
}
