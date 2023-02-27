using System;
namespace QuiardicEquation
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = 5, f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of {0} is: {1}", n, f);
        }
    }
}