using System;
namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Enter a Character: ");
            c = Convert.ToChar(Console.ReadLine());

            switch (char.ToLower(c))
            {
                case 'a':
                    Console.WriteLine("A is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine("E is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine("I is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine("O is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("U is a Vowel");
                    break;
                default:
                    Console.WriteLine("{0} is Consonent", c);
                    break;
            }
        }
    }
}