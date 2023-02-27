using System;
namespace Program1
{
    //5+10+15...+N Series Equation
    /*class series
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Enter N: ");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=5; i<n; i= i+5)
            {
                sum=sum+i;
            }
            Console.WriteLine("5+10+15+...+" + n + " = " + sum);
        }
    }*/

    /*class Traingle
     {
         static void Main(string[] args)
         {
             int a = 15, b = 21, c = 27;
             double s, area;
             if ((a + b > c) && (b + c > a) && (c + a > b))
             {
                 s = (a + b + c) / 2;
                 area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                 Console.WriteLine("The Triangle is" + area);
             }
             else
             {
                 Console.WriteLine("The Triangle isn't Possible");
             }
         }
     }*/

    /*class Defination
    {
        static void Main(string[] args)
        {
            double a = 30, b = 40, c = 10, d, x1, x2;
            d=Math.Sqrt(b*b-4*a*c);
            x1= (-b+d)/(2*a);
            x2= (-b-d)/(2*a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }*/

    /*class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Are: ");
            for(int i=1;i<=100;i++)
            {
                int count = 0;
                if (1 < i)
                {
                    for(int j = 2; j < i; j++)
                    {
                        if(i%j==0)
                        {
                            count=1; 
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
        }
    }*

    //Single Inheritence
    /*class SwitchStatement
    {
        static void Main(string[] args)
        {
            Char ch;
            Console.Write("Enter any letter: ");
            ch=Convert.ToChar(Console.ReadLine());
            switch(char.ToLower(ch))
            {
                case'a':
                case'e':
                case'i':
                case'o':
                case'u':
                    Console.WriteLine("The letter is Vowels");
                    break;
                default:
                    Console.WriteLine("The Letter is Consonent");
                    break;
            }

        }
    }*/


    //MultiLevel Inheritence
    /*public class developer
    {
        public float salary = 30000;
    }

    public class programmer : developer
    {
        public float bonus = 20000;
    }

    class Program
    {
        static void Main(string[] args)
        {
            programmer p1 = new programmer();
            Console.WriteLine("Salary : " + p1.salary);
            Console.WriteLine("Bonus : " + p1.bonus);
        }
    }*/
    /*public class developer
    {
        public float salary = 30000;
    }
    public class programmer : developer
    {
        public float bonus = 20000;
    }
    public class designer : programmer
    {
        public float gift = 5000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            designer d1 = new designer();
            Console.WriteLine("Salary : " + d1.salary);
            Console.WriteLine("Bonus : " + d1.bonus);
            Console.WriteLine("Gift : " + d1.gift);
        }
    }*/

    //Multiple Inheritence
    /*interface calc1
    {
        int add(int a, int b);
    }

    interface calc2
    {
        int sub(int x, int y);
    }

    class Calculation : calc1, calc2
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }

        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Calculation c = new Calculation();
                c.add(8, 2);
                c.sub(30, 10);
                Console.WriteLine("Multiple Inheritance Calculator :\n ");
                Console.WriteLine("Addition: " + c.result1);
                Console.WriteLine("Substraction: " + c.result2);
                Console.ReadKey();
            }
        }
    }*/

    //Array Max Value
    /*class program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int n = 10, i, max, loc = 0;

            Console.WriteLine("Enter your Elements : ");
            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = array[0];

            for (i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    loc = i + 1;
                }
            }

            Console.WriteLine("Maximum Value : " + max);
            Console.WriteLine("Max Value Location : " + loc);
        }
    }*/

    //Array sorting
    /*class program
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int[] array = new int[5];

            Console.WriteLine("Enter 5 Element: ");
            for (i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending order : ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Desending order : ");
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }*/


    //Methord Overloading
    /*class Program
    {
        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public int Add(int x, int y, int z)
        {
            int sum = x + y + z;
            return sum;
        }

        static void Main(string[]args)
        {
            Program obj = new Program();    //object with class

            int num1 = obj.Add(10, 20);
            int num2 = obj.Add(10, 20, 30); // set value to a new int

            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);
        }
    }*/

    //Factorial 
    class factorial
    {
        static void Main(string[] args)
        {
            int n, i, fact = 1;
            Console.Write("Enter a Even Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of " + n + " = " + fact);
            }
            else
            {
                Console.WriteLine("You Didn't Enter an Even Number");
            }

        }
    }

}