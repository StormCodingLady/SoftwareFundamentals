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

        public void Solve()
        {
            var tuples = Enumerable
                .Repeat(quantity, width)
                .ToArray();

            Sets(tuples); 
        }

        private void Sets(int[] tuples)
        {
            foreach (int number in tuples)
            {

            }
        }
     }
}
