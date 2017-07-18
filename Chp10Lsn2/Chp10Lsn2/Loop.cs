using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp10Lsn2
{
    public class Loop
    {
        private int quantity;
        private int width;
        private static int foo;

        public Loop(int quantity = 3, int width = 2)
        {
            this.quantity = quantity;
            this.width = width;
            //Action foo = Solve;
            //Action<int[]> boo = Sets;
            //Func<string, int> goo = Woof;

            //int oooh = goo("hey");
        }

        //public int Woof(string bark)
        //{
        //    return 0;
        //}

        public void Algo(int[] tuples, int position)
        {
            //I am a generic "single digit incrementor" that will
            //increment the stated 'digit' AFTER the prior digit
            //has had opportunity to increment
            //itself to an overflow point.  If only there were
            //a "single digit incrementor" routine I could call
            //to help me!

            for (int i = 1; i <= quantity; i++)
            {
                if (position > 0)
                {
                    Algo(tuples, position - 1);
                }
                tuples[position]++;
            }
            tuples[position] = 1;

            return;
        }

        public void Solve()
        {
            quantity++;
            var tuples = Enumerable
                .Repeat(1, width)
                .ToArray();


            Algo(tuples, width); 
        }

        private void Sets(int[] tuples)
        {
            int seed = 1;
            int placement = 0;

            while (placement <= width - 1)
            { 
                while (seed < quantity)
                {
                    seed++;
                    tuples[placement] = seed;
                }

                seed = 1;
                placement++;
            }
        }

        private void Count(int maxNum)
        {
            for(int i = 1; i <= maxNum; i++)
            {

            }
            //i = 1;

            Console.WriteLine("done");
        }

        //private void Count(int[] tuples)
        //{
        //    int digit = 0;
        //    int step = 0;

        //    while ( !(digit == width && step == quantity) ) {
        //        tuples[digit] = ++step;
        //        if (digit )
        //        if (step == quantity)
        //        {
        //            step = 0;
        //            digit++;
        //        }
        //    }

        //}
     }
}
