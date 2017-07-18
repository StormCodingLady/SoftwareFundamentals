using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chp10Lsn2;

namespace Chp10Lsn2
{
    class Program
    {
        static void Main(string[] args, Loop stoof)
        {
            Kofm Program = new Kofm();
            Program.Solve();
            Console.ReadLine();
            //Loop gong = new Loop();
            Console.WriteLine(stoof.width);
        }
    }
}
