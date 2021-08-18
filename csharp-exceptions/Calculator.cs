using System;
using System.Collections.Generic;

namespace csharp_exceptions_01
{
    public class Calculator
    {
        public decimal CurrentValue { get; private set; } = 0;
        public string CalculationOperator { get; private set; } = "+";

        public bool SetOperator(string value)
        {
            var validOperators = new List<string> { "+", "-", "*", "/" };
            if (!validOperators.Contains(value))
            {
                Console.WriteLine($"{value} is not a valid operator.");
                return false;
            }

            CalculationOperator = value;
            return true;
        }

        public void Reset()
        {
            CurrentValue = 0;
        }

        public void Calculate(string value)
        {

            switch (CalculationOperator)
            {
                case "+":
                    Add(value);
                    break;

                case "-":
                    Subtract(value);
                    break;

                case "*":
                    Multiply(value);
                    break;

                case "/":
                    Divide(value);
                    break;

                default:
                    break;
            };
        }

        public void Add(string value)
        {
            try
            {
                decimal valueToAdd = decimal.Parse(value);
                CurrentValue += valueToAdd;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please pass a valid integer or decimal value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Subtract(string value)
        {
            try
            {
                decimal valueToAdd = decimal.Parse(value);
                CurrentValue -= valueToAdd;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please pass a valid integer or decimal value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Divide(string value)
        {
            try
            {
                decimal valueToAdd = decimal.Parse(value);
                CurrentValue /= valueToAdd;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero, please enter a non-zero number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Multiply(string value)
        {
            try
            {
                decimal valueToAdd = decimal.Parse(value);
                CurrentValue *= valueToAdd;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
