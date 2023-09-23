using System;
namespace ProblemsCSharp
{
    public class FizzBuzzLeetcode
    {
        public IList<string> FizzBuzz(int n)
        {

            IList<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}

