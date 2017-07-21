using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp10Lsn4
{
    class Subset
    {
        private string[] game;
        private int length;

        public Subset(int length = 2)
        {
            this.length = length;
        }

        public void Solve()
        {
            game = new string[] { "rock", "paper", "scissors" };
            string[] presentor = Enumerable
                .Repeat("empty", length)
                .ToArray();

            Recurse(game, presentor, 0, length - 1);
        }

        public void Recurse(string[] game, string[] outcome, int myPosition, int max)
        {
            if (myPosition <= max)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (myPosition < max)
                    {
                        Recurse(game, outcome, myPosition + 1, max);
                    }

                    outcome[myPosition] = game[i];

                    if (myPosition == 1)
                    {
                        Print(outcome[0], outcome[1]);
                    }

                    if (myPosition < max)
                    {
                        myPosition++;
                    }
                }
            }
        }

        private void Print<T>( T firstPlace, T secondPlace)
        {
            Console.WriteLine("{0}, {1}", firstPlace, secondPlace);
        }
    }
}
