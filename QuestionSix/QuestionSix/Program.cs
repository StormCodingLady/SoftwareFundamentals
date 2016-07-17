using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            Coefficient printVal = UserInput(a, b, c);
            Console.WriteLine("{0}, {1}, {2}", printVal.x, printVal.y, printVal.z);
            Console.ReadLine();
        }

        public static Coefficient UserInput(double a, double b, double c)
        {
            double intInput;
            bool noError = false;

            Console.WriteLine("This program finds all real solutions to the quadratic equation.");

            while (noError == false)
            {
                Console.WriteLine("");
                Console.WriteLine("(Enter coefficients a, b, and c using numbers only.");
                Console.WriteLine("Press 'enter' after typing each coefficient.)");
                string input = Console.ReadLine();
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);
                if (isInt)
                {
                    a = intInput;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                    a = 404;
                }
                bool isInt2 = System.Double.TryParse(input2, out intInput);
                if (isInt2)
                {
                    b = intInput;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                    b = 404;
                }
                bool isInt3 = System.Double.TryParse(input3, out intInput);
                if (isInt3)
                {
                    c = intInput;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                    c = 404;
                }

                if (a == 404 || b == 404 || c == 404)
                {

                }
                else
                {
                    noError = true;
                }
            }

            Coefficient endVal = new Coefficient();
            endVal.x = a;
            endVal.y = b;
            endVal.z = c;
            return endVal;
        }

        public class Coefficient
        {
            public double x;
            public double y;
            public double z;
        }
    }
}
