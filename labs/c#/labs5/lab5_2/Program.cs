using System;

namespace lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int theWholePart = n;
            int fractionalPart;
            int m = 0;
            while (theWholePart != 0)
            {
                theWholePart = Math.DivRem(theWholePart, 10, out fractionalPart);
                m = m * 10 + fractionalPart;
            }
            Console.WriteLine("m = {0}", m);
        }
    }
}
