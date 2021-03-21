using System;

namespace csharp_largest_number
{
    static class Program
    {
        static void Main()
        {
            int[] numbers = new int[3];

            Console.WriteLine("Please enter the first number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            int largestNumber = 0;

            // using for - https://www.tutorialsteacher.com/csharp/csharp-for-loop
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = numbers[index];
                if (number > largestNumber)
                    largestNumber = number;
            }

            Console.WriteLine($"The largest number using 'for' was: {largestNumber}");

            // using foreach - https://www.tutorialsteacher.com/csharp/array-csharp
            largestNumber = 0;
            foreach (int number in numbers)
            {
                if (number > largestNumber)
                    largestNumber = number;
            }

            Console.WriteLine($"The largest number using 'foreach' was: {largestNumber}");

            // using no loop but sort method - https://www.tutorialsteacher.com/articles/sort-array-in-csharp
            Array.Sort(numbers);

            // this sorts smallest to biggest so we want the LAST item in the array
            // remember, arrays are zero (0) based, so 0, 1, 2
            largestNumber = numbers[2];
            Console.WriteLine($"The largest number using 'Array.Sort' was: {largestNumber}");
        }
    }
}