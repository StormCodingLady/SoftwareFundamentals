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
            int m = 0;

            Console.WriteLine("This program finds all real solutions to the quad-");
            Console.WriteLine("ratic equation (ax^2 + bx + c = 0). If any are to");
            Console.WriteLine("be found.");
            Console.WriteLine("");
            Console.WriteLine("(Enter coefficients a, b, and c using numbers only.");
            Console.WriteLine("Press 'enter' after typing each coefficient. Start-");
            Console.WriteLine("ing with coefficient 'a'.)");

            while (m < 3)
            {
                string input = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);
                if (isInt)
                {
                    switch (m)
                    {
                        case 0:
                            a = intInput;
                            break;
                        case 1:
                            b = intInput;
                            break;
                        case 2:
                            c = intInput;
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    m++;
                }
                else
                {
                    switch (m)
                    {
                        case 0:
                            Console.WriteLine("Invalid input! Enter an appropriate value for 'a'.");
                            break;
                        case 1:
                            Console.WriteLine("Invalid input! Enter an appropriate value for 'b'.");
                            break;
                        case 2:
                            Console.WriteLine("Invalid input! Enter an appropriate value for 'c'.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
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
