using System;
namespace Program
{
    class Swap
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, temp;
            Console.WriteLine("Before swaping A = {0} and B = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swaping A = {0} and B = {1}", a, b);
        }
    }
}