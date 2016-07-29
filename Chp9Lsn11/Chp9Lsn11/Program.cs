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
            UserInput(userCommand);
        }

        public static string TextMenu()
        {
            Console.WriteLine("This program has three options. Option 'reverse' allows you to enter a series of numbers ");
            Console.WriteLine("that are returned in reverse order. Option 'average' calculates the average of a series of");
            Console.WriteLine("numbers. Option 'equation' calculates x of the linear equation. Type the name of the option");
            Console.WriteLine("you desire and press enter.");
        }

        public static string UserInput()
        {
        }

        public static string ReverseArray()
        {
        }

        public static string CalculateAverage()
        {
        }

        public static string SolveLinear()
        {
        }
    }
}
