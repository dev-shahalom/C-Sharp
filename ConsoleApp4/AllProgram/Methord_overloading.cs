using System;
namespace MethordOverloading
{
    class Program
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int a = obj.add(5, 5);
            int b = obj.add(5, 5, 5);
            Console.WriteLine("Adding two Number: " + a);
            Console.WriteLine("Adding three Number: " + b);
        }
    }
}