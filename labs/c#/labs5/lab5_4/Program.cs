using System;

namespace lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x0, x1, x2;
            x0 = 0;
            x1 = 9;
            x2 = 9;
            int x3 = 0;
            for (int i = 3; i <= n; i++)
            {
                x3 = x2 + 4 * x0;
                x0 = x1;
                x1 = x2;
                x2 = x3;
            }
            Console.WriteLine("x{0} = {1}", n, x3);
        }
    }
}
