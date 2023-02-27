using System;
namespace MultilevelInheritence
{
    public class a
    {
        public string name = "Name: Shah Alom ";
    }
    public class b : a
    {
        public string roll = "Roll: 577944 ";
    }
    class program : b
    {
        static void Main(string[] args)
        {
            program obj = new program();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.roll);
        }
    }
}