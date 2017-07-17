using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp10Lsn2
{
    public class Kofm
    {
        private int k;
        private int m;

        public Kofm(int k = 2, int m = 3)
        {
            this.k = k;
            this.m = m;
        }

        /// <summary>
        /// This seeds the recursion.
        /// </summary>
        public void Solve()
        {
            var tuples = Enumerable
                .Repeat(m, k)
                .ToArray();

            int placeValue = k - 1;

            foreach (int number in tuples)
            {
                string myString = string.Format("{0}", number);
                Console.Write("{0} ", myString);
            }
            
            Console.WriteLine();

            VariableVariations(tuples, placeValue);
        }

        /// <summary>
        /// This performs the actual recursion.
        /// </summary>
        /// <param name="tuples"></param>
        /// <returns></returns>
        private void VariableVariations(int[] tuples, int placeValue)
        {
            if (m > 1)
            {
                m -= 1;
                tuples[placeValue] = m;

                foreach (int number in tuples)
                {
                    string myString = string.Format("{0}", number);
                    Console.Write("{0} ", myString);
                }

                Console.WriteLine();

                VariableVariations(tuples, placeValue);
            }
            else if (placeValue == 0 && tuples[placeValue] == 1 && m == 1)
            {
                foreach (int number in tuples)
                {
                    string myString = string.Format("{0}", number);
                    Console.Write("{0} ", myString);
                }

                Console.WriteLine();

                return;
            }
            else if (m == 1 && placeValue > 0)
            {
                placeValue -= 1;
                int temp = tuples[placeValue];

                if (tuples[placeValue] != 0)
                {
                    temp = m - 1;
                    tuples[placeValue] = temp;
                    placeValue += 1;
                }
                else if(tuples[placeValue] == 4)

                if (tuples[placeValue] == 0)
                {
                    return;
                }

                foreach (int number in tuples)
                {
                    string myString = string.Format("{0}", number);
                    Console.Write("{0} ", myString);
                }

                Console.WriteLine();

                VariableVariations(tuples, placeValue);
            }
            //else if (m == 1 && placeValue == 0)
            //{

            //}
        }
    }
}
