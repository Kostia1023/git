using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs15_1
{
    class GeometricProgression : Interface1
    {
        private double B;
        private double Q;

        public GeometricProgression(double b, double q)
        {
            B = b;
            Q = q;
        }

        public double ElProgression(int n)
        {
            return B * Math.Pow(Q, n - 1);
        }

        public double Sum(int n)
        {
            return (B * (1 - Math.Pow(Q, n))) / (1 - Q);
        }
    }
}
