using System;

namespace csharp_largest_number_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= number2 && number1 >= number3) 
            {
                Console.WriteLine($"The first number was the biggest: {number1}");
            } 
            else if (number2 >= number3) 
            {
                Console.WriteLine($"The second number was the biggest: {number2}");
            }
            else 
            {
                Console.WriteLine($"The third number was the biggest: {number3}");
            }
        }
    }
}
 