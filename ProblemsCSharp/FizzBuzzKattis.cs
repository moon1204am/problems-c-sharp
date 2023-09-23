using System;
namespace ProblemsCSharp
{
    public class FizzBuzzKattis
    {
        public void FizzBuzz()
        {
            Console.WriteLine("Enter 3 numbers with space in between each other");
            string? numbers = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(numbers) || numbers.Length != 5)
            {
                Console.WriteLine("not right format, try again");
                numbers = Console.ReadLine();
            }

            string[] nums = numbers.Split(" ");
            string n = nums[nums.Length - 1];

            for (int i = 1; i <= int.Parse(n); i++)
            {
                if (i % int.Parse(nums[0]) == 0 && i % int.Parse(nums[1]) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % int.Parse(nums[0]) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % int.Parse(nums[1]) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

