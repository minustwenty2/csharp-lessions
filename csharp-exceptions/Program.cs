using System;

namespace csharp_exceptions_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            while (true)
            {
                Console.Write($"The current value is: {calc.CurrentValue}.  Press '+' to add, '-' to subtract, '*' to multiply, '/' to divide or 'q' to exit: ");
                var operation = Console.ReadLine().Trim().ToLower();
                if (operation.Equals("q", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }

                if (!calc.SetOperator(operation))
                    continue;

                Console.Write($"Please enter a number to '{calc.CalculationOperator}' {calc.CurrentValue} with, or 'q' to exit: ");

                var value = Console.ReadLine();
                if (value.Equals("q", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }

                calc.Calculate(value);
            }
        }

    }
}
