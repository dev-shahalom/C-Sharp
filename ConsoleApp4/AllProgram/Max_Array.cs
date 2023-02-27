using System;
namespace Max_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int i, max, loc = 0;
            Console.WriteLine("Enter 5 Elements:");
            for (i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = array[0];
            for (i = 0; i < 5; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    loc = i + 1;

                }
            }
            Console.WriteLine("Max array is: " + max);
            Console.WriteLine("Location is: " + loc);
        }
    }
}