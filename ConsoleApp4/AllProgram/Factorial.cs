using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                num = num * i;
            }
            Console.WriteLine("The factorial of {0} is: {1}", n, num);
        }
    }
}