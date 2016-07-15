using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double intInput;
            bool noError = false;
            bool noError2 = false;
            bool noError3 = false;

            while (noError == false)
            {
                Console.WriteLine("Number 'a' equals...");
                Console.WriteLine("(Enter a real number from the number pad)");
                string input = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);
                if (isInt)
                {
                    a = intInput;
                    noError = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }

            }

            while (noError2 == false)
            {
                Console.WriteLine("Number 'b' equals...");
                Console.WriteLine("(Enter a real number from the number pad)");
                string input = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);
                if (isInt)
                {
                    b = intInput;
                    noError2 = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }

            }

            while (noError3 == false)
            {
                Console.WriteLine("Number 'c' equals...");
                Console.WriteLine("(Enter a real number from the number pad)");
                string input = Console.ReadLine();
                bool isInt = System.Double.TryParse(input, out intInput);
                if (isInt)
                {
                    c = intInput;
                    noError3 = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input.");
                    Console.WriteLine();
                }
            }

            Numbers givAn = NumSort(a, b, c);
            Console.WriteLine();
            Console.WriteLine("The numbers you have given written from least to greatest are...");
            Console.WriteLine("{0} {1} {2}", givAn.x, givAn.y, givAn.z);
            Console.ReadLine();
        }

        public class Numbers
        {
            public double x;
            public double y;
            public double z;
        }

        public static Numbers NumSort(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                if (b < c)
                {

                }
                else
                {
                    double e;
                    e = b;
                    b = c;
                    c = e;
                }
            }
            else if (a > b && a < c)
            {
                double f;
                f = a;
                a = b;
                b = f;
            }
            else if (a < b && a > c)
            {
                double g;
                g = a;
                a = c;
                c = g;

                if (b > c)
                {
                    double e;
                    e = b;
                    b = c;
                    c = e;
                }
            }
            else if (a > b && a > c)
            {
                double g;
                g = a;
                a = c;
                c = g;

                if (a < b)
                {

                }
                else
                {
                    double f;
                    f = a;
                    a = b;
                    b = f;
                }
            }

            Numbers retVal = new Numbers();
            retVal.x = a;
            retVal.y = b;
            retVal.z = c;
            return retVal;
        }    
    }
}
