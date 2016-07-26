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
            Console.Write(UserInput());
            Console.ReadLine();
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
    }
}
