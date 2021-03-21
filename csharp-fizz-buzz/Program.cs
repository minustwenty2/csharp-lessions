using System;

namespace csharp_fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz....");

            for (int number = 1; number <= 100; number++)
            {
                bool isDivisibleBy3 = (number % 3) == 0;
                bool isDivisibleBy5 = (number % 5) == 0;

                if (isDivisibleBy3 && isDivisibleBy5)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (isDivisibleBy3)
                {
                    Console.WriteLine("fizz");
                }
                else if (isDivisibleBy5)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine($"{number}");
                }
            }
        }
    }
}
