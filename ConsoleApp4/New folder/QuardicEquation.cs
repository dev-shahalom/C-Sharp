using System;
namespace QuiardicEquation
{
    class Equation
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            double x, x1, x2;
            a = 1;
            b = 4;
            c = 3;
            d = (b * b) - (4 * a * c);//b_square-4ac
            if (d == 0)
            {
                x = -b / (2 * a);//-b/2a
                Console.WriteLine("Roots are equal and real and are: " + x);
            }
            else if (d > 0)
            {
                x1 = -b + (Math.Sqrt(d) / (2 * a));//-b+root_d/2a
                x2 = -b - (Math.Sqrt(d) / (2 * a));//-b-root_d/2a
                Console.WriteLine("Roots are not equal and real and are: {0} {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Roots are imaginary");
            }
        }
    }
}