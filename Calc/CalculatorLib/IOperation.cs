using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public interface IOperation
    {
        string Code { get; }

        int Apply(int result, int newNumber);
    }

    public abstract class AbstractOperation
    {
        string Code { get; }

        public abstract int Apply(int result, int newNumber);
    }
}
