﻿using System;
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

        public static string GetUserInput()
        {
            string answer = "Error";
            bool resolved = false;

            Console.WriteLine("This program has three options. Option 'reverse' allows you to enter a series of numbers ");
            Console.WriteLine("that are returned in reverse order. Option 'average' calculates the average of a series of");
            Console.WriteLine("numbers. Option 'equation' calculates x of the linear equation. Type the name of the option");
            Console.WriteLine("you desire and press enter.");
            Console.WriteLine("");

            while (resolved == false)
            {
                string input = Console.ReadLine();

                if (input != "reverse" && input != "average" && input != "equation")
                {
                    Console.WriteLine("");
                    Console.Write("Invalid Input!");
                }
                else
                {
                    answer = input;
                    resolved = true;
                }
            }
            return answer;
        }

        public static string GetUserStringOfNumbers()
        {
            int isInput;
            bool resolved = false;
            string answer = "Error";
            Console.WriteLine("");
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
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("");
                }
            }

            return answer;
        }

        public static double[] GetUserArrayOfNumbers()
        {
            double isInput;
            bool resolved = false;
            double[] userSeries = new double[1];
            int i = 0;
            Console.WriteLine("");
            Console.WriteLine("Please enter a series of numbers. After typing a nummber press 'enter'. When finished enter the");
            Console.WriteLine("word 'done'. The average will then be calculated. The sequence of numbers cannot be empty.");
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
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("");
                }
            }

            return userSeries;
        }

        public static ThreeDouble GetUserLinearEquNumbers()
        {
            double a = -21;
            double b = -21;
            double c = 0;
            string current = "a";
            double intInput;
            int m = 0;

            Console.WriteLine("");
            Console.WriteLine("For the linear equation 'ax + b = 0' with '0' being the translation value,");
            Console.WriteLine("please enter for the variables 'a', 'b', and the 'translation value'. Any");
            Console.WriteLine("number can be entered as long as 'a != 0'. After entering each variable");
            Console.WriteLine("press enter.");
            Console.WriteLine("");

            while (m < 3)
            {
                string input = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);

                /*This switch establishes both the success and error
                response, and which is used is decided later.*/
                switch (m)
                {
                    case 0:
                        current = "'a'";
                        a = intInput;
                        break;
                    case 1:
                        current = "'b'";
                        b = intInput;
                        break;
                    case 2:
                        current = "the 'translation value'";
                        c = intInput;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                if (isInt && a != 0)
                {
                    m++;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input! Enter an appropriate value for {0}.", current);
                    Console.WriteLine("");
                }
            }

            ThreeDouble values = new ThreeDouble();
            values.a = a;
            values.b = b;
            values.c = c;
            return values;
        }

        public class ThreeDouble
        {
            public double a;
            public double b;
            public double c;
        }
    }
}
