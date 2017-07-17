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
        
        public Kofm (int k = 2, int m = 3)
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
                VariableVariations(tuples, placeValue);
            }
            else if (m == 1 && placeValue > 0)
            {
                placeValue -= 1;
                tuples[placeValue] = m;
                VariableVariations(tuples, placeValue);
            }
        }
    }
}
