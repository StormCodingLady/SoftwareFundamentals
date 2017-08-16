using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp13Lsn3
{
    public class Expression
    {
        /// <summary>
        /// Checks whether the parentheses are placed correctly in an arithmetic expression.
        /// </summary>
        /// <param name="expression">A string that contains an expression.</param>
        /// <returns>Boolean</returns>
        public bool CheckParens(string expression)
        {
            int marker = 0;
            bool retVal = false;

            for(int i = 0; i < expression.Length && marker >= 0; i++)
            {
                if (expression[i] == '(')
                {
                    marker++;
                }
                else if (expression[i] == ')')
                {
                    marker--;
                }

                if (expression.Length - 1 == i && marker == 0)
                {
                    retVal = true;
                }
            }

            return retVal;
        }
    }
}
