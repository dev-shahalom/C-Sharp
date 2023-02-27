using System;
namespace MultiLevel_Inheritence
{
    interface IA
    {
        void MethodA();
    }
    interface IB
    {
        void MethodB();
    }

    class C : IA, IB
    {
        public void MethodA()
        {
            Console.WriteLine("Method A");
        }

        public void MethodB()
        {
            Console.WriteLine("Method B");
        }
    }

    class Test:C
    {
        static void Main(string[] args)
        {
            Test c = new Test();
            c.MethodA();
            c.MethodB();
        }
    }

}