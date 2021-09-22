using System;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= 2*n; i += 2)
                sum += (int) (Math.Pow(i, 2) + Math.Pow(i + 1, 3));
            Console.WriteLine("s = {0}", sum);
        }
    }
}
