using System;

namespace lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            int res;
            if (x < 0)
                res = 3;
            else
                if (x < 5)
                res = 1;
            else
                    if (x < 8)
                res = 2;
            else
                res = 4;
            Console.WriteLine("y = {0}", res);

        }
    }
}
