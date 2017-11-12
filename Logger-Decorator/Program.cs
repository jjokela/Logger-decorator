using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger_Decorator.Decorators;
using Logger_Decorator.Loggers;
using Logger_Decorator.Loggers.Adapters;

namespace Logger_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLoggers();

            TestDecoratorWithLogger();

            Console.ReadLine();
        }

        private static void TestDecoratorWithLogger()
        {
            ILogger logger = new FileLogAdapter(new FileLogger());

            var calculator = new ConcreteCalculator();
            var loggerCalculator = new DecoratorLogCalculator(calculator, logger);

            calculator.Add(3, 4);
            loggerCalculator.Add(1, 2);
        }

        private static void TestLoggers()
        {
            ILogger logger = new FileLogAdapter(new FileLogger());

            logger.LogInfo("Message 1");
            logger.LogError("Message 2");

            logger = new DbLogAdapter(new DbLogger());

            logger.LogInfo("Message 3");
            logger.LogError("Message 4");
        }
    }
}
