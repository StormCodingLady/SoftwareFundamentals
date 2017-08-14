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

        public Subset(int length = 6)
        {
            this.length = length;
        }

        public void Solve()
        {
            game = new string[] { "rock", "paper", "scissors" };

            int[] presentor = Enumerable
                .Repeat(length, length)
                .ToArray();

            Recurse(game, presentor, 0, length - 1);
        }

        public void Recurse(string[] game, int[] outcome, int myPosition, int max)
        {
            if (myPosition <= max)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (myPosition < max)
                    {
                        Recurse(game, outcome, myPosition + 1, max);
                    }

                    outcome[myPosition] = i;

                    if (myPosition == 1)
                    {
                        Print(game[outcome[0]], game[outcome[1]]);
                    }
                }
            }
        }

        private void Print(string firstPlace, string secondPlace)
        {
            Console.WriteLine("{0}, {1}", firstPlace, secondPlace);
        }
    }
}
