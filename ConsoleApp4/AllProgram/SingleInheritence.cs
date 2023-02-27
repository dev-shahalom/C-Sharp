using System;
namespace SIngleInheritence
{
    public class a
    {
        public string name = "Name: Shah Alom ";
        public string roll = "Roll: 577944 ";
    }
    class program : a
    {
        static void Main(string[] args)    
        {
            program obj = new program();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.roll);
        }
    }
}