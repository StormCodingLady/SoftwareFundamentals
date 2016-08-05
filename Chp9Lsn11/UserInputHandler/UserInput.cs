using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputHandler
{
    public class UserInput
    {
        static void Main(string[] args)
        {
        }

        public static string UserString()
        {
            int isInput;
            bool resolved = false;
            string answer = "Error";
            Console.WriteLine("Enter in a positive integer that ranges from 1 to 50,000,000. The digits will be returned in");
            Console.WriteLine("reverse order.");
            Console.WriteLine("");

            while (resolved == false)
            {
                string input = Console.ReadLine();
                bool isDouble = System.Int32.TryParse(input, out isInput);

                if (isDouble && isInput >= 1 && isInput <= 50000000)
                {
                    answer = input;
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("Invalid Input!");
                }
            }

            return answer;
        }

        public static double[] UserArray()
        {
            double isInput;
            bool resolved = false;
            double[] userSeries = new double[1];
            int i = 0;
            Console.WriteLine("Please enter a series of numbers. When finished enter the word 'done'. The average will then");
            Console.WriteLine("be calculated. The sequence of numbers cannot be empty.");
            Console.WriteLine("");

            while (resolved == false)
            {
                int numColumns = userSeries.GetLength(0);
                string input = Console.ReadLine();
                bool isDouble = System.Double.TryParse(input, out isInput);

                if (isDouble)
                {
                    if (i + 1 > numColumns)
                    {
                        Array.Resize(ref userSeries, i + 1);
                    }
                    userSeries[i] = isInput;
                    i++;
                }
                else if (input == "done")
                {
                    resolved = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            return userSeries;
        }

        public static TwoDouble UserDoubles()
        {
            double a = -21;
            double b = -21;
            string current = "a";
            double intInput;
            int m = 0;

            Console.WriteLine("For the linear equation 'ax + b = 0', please enter the variables 'a' and 'b'. Any number can");
            Console.WriteLine("be entered as long as 'a != 0'. After entering each variable press enter.");
            Console.WriteLine("");

            while (m < 2)
            {
                string input = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);

                /*This switch establishes both the success and error
                response, and which is used is decided later.*/
                switch (m)
                {
                    case 0:
                        current = "a";
                        a = intInput;
                        break;
                    case 1:
                        current = "b";
                        b = intInput;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                if (isInt)
                {
                    m++;
                }
                else
                {
                    Console.WriteLine("Invalid input! Enter an appropriate value for '{0}'.", current);
                    Console.WriteLine("");
                }
            }

            TwoDouble aPlusB = new TwoDouble();
            aPlusB.a = a;
            aPlusB.b = b;
            return aPlusB;
        }

        public class TwoDouble
        {
            public double a;
            public double b;
        }
    }
}
