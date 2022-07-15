using System;
using MyMaths;

namespace JenkinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath mm = new MyMath();
            int a=mm.Add(2, 3);
            int b = mm.Multiply(3, 5);
            Console.WriteLine($"{a}..........{b}");
        }
    }
}
