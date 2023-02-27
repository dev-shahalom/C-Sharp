//Single Inheritence
using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 3;
            b = 4;
            c = 5;

            if ((a + b > c) & (a + c > b) & (b + c > a))
            {
                double s = (a + b + c) / 2;
                double area;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine(area);
            }
            else
            {
                Console.WriteLine("Triangle imposiiible");
            }
        }
    }
}