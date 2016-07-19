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
            double numSol = SoluEval(printVal.x, printVal.y, printVal.z);

            Console.WriteLine("");
            Console.WriteLine("Your problem has '{0}' real solution(s).", numSol);
            Console.WriteLine("");

            Coefficient finAn = SolveQuadratic(printVal.x, printVal.y, printVal.z);
            UserView(finAn);

            Console.ReadLine();
        }

        /// <summary>
        /// Fetch user input for coefficients of the quadratic equation.
        /// </summary>
        /// <param name="a">Quadratic coefficient</param>
        /// <param name="b">Quadratic coefficient</param>
        /// <param name="c">Quadratic coefficient</param>
        /// <returns>A tuple of quadratic coefficients</returns>
        public static Coefficient UserInput(double a, double b, double c)
        {
            string current = "a";
            double intInput;
            int m = 0;

            Console.WriteLine("This program finds all REAL solutions to the quad-");
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
                    case 2:
                        current = "c";
                        c = intInput;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                if (isInt)
                {
                    m++;
                }else
                {
                    Console.WriteLine("Invalid input! Enter an appropriate value for '{0}'.", current);
                    Console.WriteLine("");
                }
            }

            Coefficient endVal = new Coefficient();
            endVal.x = a;
            endVal.y = b;
            endVal.z = c;
            return endVal;
        }

        /// <summary>
        /// Test the number of real solutions, given a set of coefficients for the quadratic formula.
        /// </summary>
        /// <param name="a">Quadratic coefficient</param>
        /// <param name="b">Quadratic coefficient</param>
        /// <param name="c">Quadratic coefficient</param>
        /// <returns>The number of real solutions.</returns>
        public static double SoluEval(double a, double b, double c)
        {
            double numSolTest = (b * b) - 4 * a * c;

            if (numSolTest == 0)
            {
                numSolTest = 1;
            }
            else if (numSolTest > 0)
            {
                numSolTest = 2;
            }
            else
            {
                numSolTest = 0;
            }

            return numSolTest;
        }

        /// <summary>
        /// Utilizes the quadratic formula to generate solutions.
        /// </summary>
        /// <param name="a">Quadratic coefficient</param>
        /// <param name="b">Quadratic coefficient</param>
        /// <param name="c">Quadratic coefficient</param>
        /// <returns>Either one real root, two real roots, or two complex solutionis, as well as the discriminant.</returns>
        public static Coefficient SolveQuadratic(double a, double b, double c)
        {
            double discriminant = (b * b) - 4 * a * c;
            double sqrt = Math.Sqrt(discriminant);
            double twoA = 2 * a;
            double anOne = (-(b) + (sqrt)) / twoA;
            double anTwo = (-(b) - (sqrt)) / twoA;

            if (anOne == anTwo)
            {
                Coefficient oneVal = new Coefficient();
                oneVal.z = anOne;
                oneVal.w = discriminant;
                return oneVal;
            }

            Coefficient twoVal = new Coefficient();
            twoVal.x = anOne;
            twoVal.y = anTwo;
            twoVal.w = discriminant;
            return twoVal;
        }

        /// <summary>
        /// Presents the final answer(s) to the user.
        /// </summary>
        /// <param name="finAn">feeds in the the real or complex solutions as well as the discriminant.</param>
        public static void UserView(Coefficient finAn)
        {
            if (finAn.w < 0)
            {
            }
            else if (finAn.z == 0)
            {
                Console.WriteLine("{0} or {1}", finAn.x, finAn.y);
            }
            
            if (finAn.x == 0 && finAn.y == 0)
            {
                Console.WriteLine("{0}", finAn.z);
            }
        }

        /// <summary>
        /// A class that handles the coefficients as well as the discriminant.
        /// </summary>
        public class Coefficient
        {
            public double w;
            public double x;
            public double y;
            public double z;
        }
    }
}
