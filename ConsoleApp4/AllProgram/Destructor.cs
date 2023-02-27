using System;
namespace Destructor
{
    class Program
    {
        public string name;
        public int id;
        public Program(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        ~Program()
        {
            Console.WriteLine("Destructor Invoked !");
        }
        static void Main(string[] args)
        {
            Program m = new Program("Muhib", 1010);
            Console.WriteLine(m.name);
            Console.WriteLine(m.id);
        }
    }
}