using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.2;
            double b = 1.4;
            double c = 1.6;

            NumArrange(a, b, c);
        }

        public static double[] AlphaSort(double a, double b, double c)
        {
            //do a lot of work.
            return new double[] { a, b, c };
        }

        public class Numbers
        {
            public double a;
            public double b;
            public double c;
        }

        public static Numbers BravoSort(double a, double b, double c)
        {
            Numbers retVal = new Numbers();
            retVal.a = 5.0;
            retVal.b = 7.0;
            retVal.c = 10.0;
            return retVal;
        }

        public static double NumArrange(double a, double b, double c)
        {
            if (a <= b && a <= c) 
            {
                return a;

                if (b <= c)
                {
                    return b;
                    return c;
                }
                else
                {
                    return c;
                    return b;
                }
            }
            else if (b <= c && b <= a)
            {
                return b;

                if (a <= c)
                {
                    return a;
                    return c;
                }
                else
                {
                    return c;
                    return a;
                }
            }
            else if (c <= b && c <= a)
            {
                return c;

                if (b <= a)
                {
                    return b;
                    return a;
                }
                else
                {
                    return a;
                    return b;
                }
            }
        }
    }
}
