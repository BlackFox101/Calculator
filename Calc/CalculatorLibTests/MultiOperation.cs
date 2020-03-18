using CalculatorLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibTests
{
    public class MultiOperation : IOperation
    {
        public string Code => "*";

        public int Apply(int result, int newNumber)
        {
            return result * newNumber;
        }
    }
}
