using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_Decorator.Decorators
{
    public class ConcreteCalculator : ICalculator
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
    }
}
