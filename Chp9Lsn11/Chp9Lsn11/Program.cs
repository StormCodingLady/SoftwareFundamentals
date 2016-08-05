using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInputHandler;

namespace Chp9Lsn11
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userCommand = TextMenu();
            MultipleType FinalAnswer = CallOption(userCommand);
            PrintAnswer(userCommand, FinalAnswer);
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

        public static MultipleType CallOption(string optionSelect)
        {
            MultipleType userInput = new MultipleType();

            if (optionSelect == "reverse")
            {
                userInput.integer = UserInput.UserString();
                userInput.integer = ComputerCalculate(userInput.integer);
            }

            if (optionSelect == "average")
            {
                userInput.numberSequence = UserInput.UserArray();
                userInput.numberSequence = ComputerCalculate(userInput.numberSequence);
            }

            if (optionSelect == "equation")
            {
                userInput.twoDouble = UserInput.UserDoubles();
                userInput.x = ComputerCalculate(userInput.twoDouble.a, userInput.twoDouble.b);
            }

            return userInput;
        }

        public static string ComputerCalculate(string integer)
        {
            char[] integerArray = integer.ToCharArray();
            Array.Reverse(integerArray);
            return new string(integerArray);
        }

        public static double[] ComputerCalculate(double[] numberSequence)
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

        public static double ComputerCalculate(double a, double b)
        {
            double x = -b / a;
            return x;
        }

        public static void PrintAnswer(string optionSelect, MultipleType FinalAnswer)
        {
            if (optionSelect == "reverse")
            {
                Console.WriteLine("");
                Console.WriteLine("Result: {0}", FinalAnswer.integer);
            }

            if (optionSelect == "average")
            {
                Console.WriteLine("");
                Console.WriteLine("Result: {0}", FinalAnswer.numberSequence);
            }

            if (optionSelect == "equation")
            {
                Console.WriteLine("");
                Console.WriteLine("Result: {0}", FinalAnswer.x);
            }
        }

        public class MultipleType
        {
            public string integer;
            public double[] numberSequence;
            public double x;
            public UserInput.TwoDouble twoDouble;
        }
    }
}
