using System;

namespace Euler1
{
    class Program
    {
        static void Main()
        {
            int result = 0;
            string reply = $"The sum of all the multiples of 3 or 5 below 1000 is {result}";
            for (int n = 1; n < 1000; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    result += n;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
