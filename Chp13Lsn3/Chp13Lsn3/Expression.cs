using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp13Lsn3
{
    class Expression
    {
        char openBrkt;
        char closedBrkt;
        int brktCounter = 0;

        //The difference between a string and a char is the qouting:
        //  "("   -- Wee! Look at me!  I am a string of length 1!
        //  '('   -- Wee! Look at me!  I am a char!
        Expression(char openBrkt = '(', char closedBrkt = ')')
        {
            openBrkt = this.openBrkt;
            closedBrkt = this.closedBrkt;
        }

        public void Check(string problem)
        {
            problem = "(3 + 1)(6 * q)";

            foreach(openBrkt in problem)
            {

            }
        }
    }
}
