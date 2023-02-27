using System;
namespace Delegate
{
    public delegate int calculation(int a, int b);  //delegate

    class Program
    {
        public static int AddNum(int a, int b)
        {
            int num = a + b;
            return num;
        }
        public static int MultiNum(int a, int b)
        {
            int num = a * b;
            return num;
        }
        public static void Main(string[] args)
        {
            calculation obj1 = new calculation(AddNum);
            calculation obj2 = new calculation(MultiNum);
            int print1 = obj1.Invoke(10, 20);
            int print2 = obj2.Invoke(10, 20);
            Console.WriteLine("Addition is : " + print1);
            Console.WriteLine("Multiplication is : " + print2);
        }
    }
}