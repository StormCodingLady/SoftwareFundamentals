using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp9Lsn11
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userCommand = TextMenu();
            //CallOption(userCommand);
            double[] numberSequence = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(ReverseNumbers());
            Console.WriteLine(CalculateAverage(numberSequence));
            Console.WriteLine(SolveLinear());
            Console.ReadLine();
        
        }

        public static string TextMenu()
        {
            bool resolved = false;
            string answer = "Error";
            Console.WriteLine("This program has three options. Option 'reverse' allows you to enter a series of numbers ");
            Console.WriteLine("that are returned in reverse order. Option 'average' calculates the average of a series of");
            Console.WriteLine("numbers. Option 'equation' calculates x of the linear equation. Type the name of the option");
            Console.WriteLine("you desire and press enter.");

            while (resolved)
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

        //public static void CallOption(string optionSelect)
        //{
        //    if(optionSelect == "reverse")
        //    {
        //        int[] reverseArray = UserInput(optionSelect);
        //    }

        //    if (optionSelect == "average")
        //    {
        //        int[] averageArray = UserInput(optionSelect);
        //    }

        //    if (optionSelect == "equation")
        //    {
        //        int[] equationArray = new int[2];
        //        equationArray = UserInput(optionSelect);
        //    }
        //}

        public static string ReverseNumbers(string integer = "12345689")
        {
            char[] integerArray = integer.ToCharArray();
            Array.Reverse(integerArray);
            return new string(integerArray);
        }

        public static double[] CalculateAverage(double[] numberSequence)
        {
            double sum = 0;
            int numColumns = numberSequence.GetLength(0);

            for(int i = 0; i < numColumns; i++)
            {
                sum += numberSequence[i];
            }

            double average = sum / numColumns;
            double[] averageArray = { average };
            return averageArray;
        }

        public static double SolveLinear(double a = 5, double b = 5)
        {
            double x = -b / a;
            return x;
        }
    }
}
