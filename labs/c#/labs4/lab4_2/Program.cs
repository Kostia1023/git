using System;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(((a > b) ? b : a) + Math.Pow((b > c) ? c : b, 2));
        }
    }
}
