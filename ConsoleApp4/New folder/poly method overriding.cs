using System;
namespace Polymorphism_MtethodOverRiding
{
    class A
    {
        public int sum(int x, int y)
        {
            return x + y;
        }
    }
    class Program : A
    {
        public int sum(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.sum(10, 20));
        }
    }
}