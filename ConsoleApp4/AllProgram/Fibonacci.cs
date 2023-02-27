using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n3, n1, n2, num, i;
            n1 = 0;
            n2 = 1;
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} {1}", n1, n2);
            for (i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(" " + n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}