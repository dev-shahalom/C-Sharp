using System;
namespace MultipleInheritence
{
    interface a
    {
        void methord1();
    }
    interface b
    {
        void methord2();
    }
    public class methord3 : a, b
    {
        public void methord1()
        {
            Console.WriteLine("This is Methord 1");
        }
        public void methord2()
        {
            Console.WriteLine("This is Methord 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            methord3 obj = new methord3();
            obj.methord1();
            obj.methord2();
        }
    }
}