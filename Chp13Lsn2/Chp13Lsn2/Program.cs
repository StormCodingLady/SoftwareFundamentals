using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp13Lsn2
{
    class Program
    {
        static void Main(string[] args)
        {
            string backwardsIntro = Reverse(Hello.x);
            Print(backwardsIntro);
        }

        public class Hello
        {
            public static string x = "introduction";
        }

        public static string Reverse(string x)
        {
            string xOutput = "";

            for (int i = x.Length - 1; i >= 0; i--)
            {
                xOutput += x[i];
            }

            return xOutput;
        }

        public static void Print(string intro)
        {
            Console.WriteLine(intro);
            Console.ReadLine();
        }
    }
}
