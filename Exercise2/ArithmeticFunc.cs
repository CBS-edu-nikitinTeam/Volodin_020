using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    delegate double Operation(double operand1, double operand2);
    class ArithmeticFunc
    {
        public static Dictionary<char, Operation> AllOperations
        {
            get
            {
                return new Dictionary<char, Operation>()
                {
                    { '+', (double o1, double o2) => o1 + o2 },
                    { '-', (double o1, double o2) => o1 - o2 },
                    { '*', (double o1, double o2) => o1 * o2 },
                    { '/', (double o1, double o2) => { return o2 != 0 ? o1 / o2 : throw new DivideByZeroException(); } }
                };
            }
        }
    }
}
