using System;

namespace lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double AB = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double BC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            Console.WriteLine((AB == AC && AC == BC) ? "Трикутник рівностороній" : "Трикутник не рівностороній");
        }
    }
}
