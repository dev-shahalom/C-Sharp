using System;
namespace Constructor
{
    class User
    {
        public string name;
        public int id;
        public User()
        {
            name = "Muhib";
            id = 1010;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine(u.name);
            Console.WriteLine(u.id);

        }
    }
}