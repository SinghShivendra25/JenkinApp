using System;

namespace JenkinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Console.WriteLine("Hii my name is shivendra");
            Console.WriteLine("I  am working on a jenkins");
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of two given numbers is :{a + b}");
            Console.ReadLine();
        }
    }
}
