using System;
namespace MethordOverriding
{
    class a
    {
        public int add(int x, int y)
        {
            int sum = x - y;
            return sum;
        }
    }
    class Program : a
    {
        public int add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int a = obj.add(5, 5);
            Console.WriteLine("Overriding first Methord: " + a);
        }
    }
}