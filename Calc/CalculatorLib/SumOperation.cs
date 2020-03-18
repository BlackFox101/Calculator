using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public class SumOperation : IOperation
    {
        public string Code => "+";

        public int Apply(int result, int newNumber)
        {
            return result + newNumber;
        }
    }
}
