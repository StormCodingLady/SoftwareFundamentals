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

        private void Algo(int[] tuples, int currentPosition, int maxPosition, int quantity)
        {
            if (currentPosition <= maxPosition)
            {
                for (int i = 1; i <= quantity; i++)
                {
                    if (currentPosition < maxPosition)
                    {
                        Algo(tuples, currentPosition + 1, maxPosition, quantity);
                    }

                    if (currentPosition == 1)
                    {
                        Print(tuples[0], tuples[1]);
                    }

                    if (tuples[currentPosition] + 1 != quantity + 1)
                    {
                        tuples[currentPosition]++;
                    }
                }
            }
           
            tuples[currentPosition] = 1;

            return;
        }

        public void Solve()
        {
            var tuples = Enumerable
                .Repeat(1, width)
                .ToArray();
            
            Algo(tuples, 0, width - 1, quantity); 
        }

        private void Print(int firstPlace, int secondPlace)
        {
            Console.WriteLine("{0}, {1}", firstPlace, secondPlace);
        }
     }
}
