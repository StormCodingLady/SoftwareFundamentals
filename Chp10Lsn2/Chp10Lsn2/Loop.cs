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

        public Loop(int quantity = 3, int width = 2)
        {
            this.quantity = quantity;
            this.width = width;
        }

        private void Algo(int[] tuples, int position)
        {
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
     }
}
