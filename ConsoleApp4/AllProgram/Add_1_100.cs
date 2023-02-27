using System;
namespace Add_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                num = num + i;
            }
            Console.WriteLine("Addition of 1-100 is: " + num);
        }
    }
}