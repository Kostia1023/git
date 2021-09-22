using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs15_1
{
    class ArithmeticProgression : Interface1
    {
        private double A;
        private double D;

        public ArithmeticProgression(double a, double d)
        {
            A = a;
            D = d;
        }

        public double ElProgression(int n)
        {
            return A + D * (n - 1);
        }

        public double Sum(int n)
        {
            return ((2 * A + D * (n - 1)) / 2) * n;
        }
    }
}
