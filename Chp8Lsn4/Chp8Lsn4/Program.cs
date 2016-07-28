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
            int convertNumber = UserInput();
            int[] binaryNumber = DecimalToBinary(convertNumber);
            DisplayBinaryNumber(binaryNumber, convertNumber);
        }

        /// <summary>
        /// Accepts an integer from the user.
        /// </summary>
        /// <returns>integer</returns>
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

        /// <summary>
        /// Converts an integer to a binary value.
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns>An array of 1's and 0's.</returns>
        public static int[] IntegerToBinary(int decimalNumber)
        {
            if(decimalNumber < 0)
            {
                decimalNumber *= -1; 
            }

            int[] binaryHolder = new int[1];
            int i = 0;

            while(decimalNumber >= 1)
            {
                int numColumns = binaryHolder.GetLength(0);
                
                if(i + 1 > numColumns)
                {
                    Array.Resize(ref binaryHolder, i + 1);
                }

                int remainder = decimalNumber % 2; // 1 or 0
                binaryHolder[i] = remainder;
                decimalNumber = (int)Math.Floor(decimalNumber / 2.0);
                i++;
            }

            Array.Reverse(binaryHolder);
            return binaryHolder;
        }

        /// <summary>
        /// Displays to the user their integer in binary form.
        /// </summary>
        /// <param name="binaryNumber">Array of 1's and 0's</param>
        /// <param name="signIndicator">Users decimal number</param>
        public static void DisplayBinaryNumber(int[] binaryNumber, int signIndicator)
        {
            string numberBinary = string.Join("", binaryNumber);
            int arrayLength = binaryNumber.GetLength(0);
            int increment = 4 - arrayLength % 4;

            if (signIndicator < 0)
            {
                Console.Write("-");
            }

            if (arrayLength % 4 != 0)
            {
                numberBinary = numberBinary.PadLeft(arrayLength + increment, '0');
            }

            for (int i = numberBinary.Length; i > 0; i = i - 4)
            {
                numberBinary = numberBinary.Insert(i, " ");  
            }
            
            Console.Write(numberBinary);
            Console.ReadLine();
        }
    }
}
