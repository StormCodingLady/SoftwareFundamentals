using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshKetchum
{
    class BackPack //the program.
    {
        static void Main(string[] args)
        {
            int attack = 5;
            ThunderBolt(attack);
            Console.Read();
        }

        static int ThunderBolt(int x)
        {
            Console.Write(x + 2);
            return x;
        }
    }
}

