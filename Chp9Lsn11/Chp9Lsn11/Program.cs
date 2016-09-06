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
            string userCommand = UserInput.GetUserInput();
            MultipleType FinalAnswer = CallOption(userCommand);
            PrintAnswer(userCommand, FinalAnswer);
            Console.ReadLine();
        }

        public static MultipleType CallOption(string optionSelect)
        {
            MultipleType userInput = new MultipleType();
            
            if (optionSelect == "Error")
            {
                userInput.noError = false;
            }

            if (optionSelect == "reverse")
            {
                userInput.integer = UserInput.GetUserStringOfNumbers();
                userInput.integer = ReverseIntegerOrder(userInput.integer);
            }

            if (optionSelect == "average")
            {
                userInput.numberSequence = UserInput.GetUserArrayOfNumbers();
                userInput.numberSequence = CalculateAverage(userInput.numberSequence);
            }

            if (optionSelect == "equation")
            {
                userInput.threeDouble = UserInput.GetUserLinearEquNumbers();
                userInput.x = SolveLinearEquation(userInput.threeDouble.a, userInput.threeDouble.b, userInput.threeDouble.c);
            }

            return userInput;
        }

        public static string ReverseIntegerOrder(string integer)
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
            return averageArray; //The purpose of returning an array is to make easy use of the class MultipleType.
        }

        public static double SolveLinearEquation(double a, double b, double c)
        {
            double x = (c - b) / a;
            return x;
        }

        public static void PrintAnswer(string optionSelect, MultipleType FinalAnswer)
        {
            if (FinalAnswer.noError == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Result: There was an error with the user input.");
            }

            if (optionSelect == "reverse")
            {
                Console.WriteLine("");
                Console.WriteLine("Result: {0}", FinalAnswer.integer);
            }

            if (optionSelect == "average")
            {
                Console.WriteLine("");
                Console.WriteLine("Result: {0}", FinalAnswer.numberSequence[0]);
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
            public UserInput.ThreeDouble threeDouble;
            public bool noError;
        }
    }
}
