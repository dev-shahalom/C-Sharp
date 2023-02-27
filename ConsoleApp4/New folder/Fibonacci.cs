using System;
namespace Program
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int a, b, c, i, n;
            a = 0;
            b = 1;
            n = 10;
            Console.Write("{0} {1}", a, b);
            for (i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }
    }
}