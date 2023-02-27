using System;
namespace Polymorphism_OperatorOverRiding // +
{
    class Program
    {
        public string name;
        public int id;

        public static Program operator +(Program obj1, Program obj2)
        {
            Program obj3 = new Program();
            obj3.name = obj1.name + obj2.name;
            obj3.id = obj1.id + obj2.id;
            return obj3;
        }


        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.name = "Shah";
            obj1.id = 1100;

            Program obj2 = new Program();
            obj2.name = "Alom";
            obj2.id = 0011;

            Program obj3 = new Program();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.id);
        }
    }
}