using System;
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prime Number between 1 to 100 are: ");
            for (int i = 1; i <= 100; i++)
            {
                int count = 0;
                if (1 < i)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

        }
    }
}
