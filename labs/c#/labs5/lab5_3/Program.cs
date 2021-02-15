using System;

namespace lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            double n = Convert.ToDouble(Console.ReadLine());
            double cos = 1;
            int pow = -1;
            long denominator = 1;
            for (int i = 2; i <= 2 * n; i += 2)
            {
                denominator = denominator * i * (i - 1);
                cos += pow * Math.Pow(x, i) / denominator;
                pow *= -1;
            }
            Console.WriteLine("cosx = {0}", cos);
        }
    }
}
