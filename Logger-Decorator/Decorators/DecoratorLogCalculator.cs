using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger_Decorator.Loggers.Adapters;

namespace Logger_Decorator.Decorators
{
    public class DecoratorLogCalculator : ICalculator
    {
        private readonly ICalculator _calculator;
        private readonly ILogger _logger;

        public DecoratorLogCalculator(ICalculator calculator, ILogger logger)
        {
            _calculator = calculator;
            _logger = logger;
        }

        public int Add(int i, int j)
        {
            _logger.LogInfo($"Adding {i} and {j}");
            return _calculator.Add(i, j);
        }
    }
}
