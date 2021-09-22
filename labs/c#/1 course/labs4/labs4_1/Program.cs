using System;

namespace labs4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Дiагональ квадрата = ") ;
            double d = Convert.ToDouble(Console.ReadLine());
            double a = d / Math.Sqrt(2);
            Console.WriteLine("Периметр квадрата = {0}\nПлоща квадрата = {1}", 4 * a, a*a);
        }
    }
}
