using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims_14
{
    public class DistributionClass
    {
        private  Random rnd = new Random();

        public double exp(double l)
        {
            return -(Math.Log(rnd.NextDouble()) / l);
        }


        //public double SND1(double fi, double a)
        //{
        //    double sig = 0;

        //    for (int j = 1; j <= 12; j++)
        //    {
        //        sig += rnd.NextDouble();
        //    }
        //    sig -= 6;
        //    return (fi * sig + a);
        //}

        public double PPPD(int a, int b, double t)
        {
            double t_next = t;
            double l = a + b;
            double u;

            do
            {
                t_next += exp(l);
                u = rnd.NextDouble() * l;
            }
            while (Math.Abs(a * Math.Sin(t_next) + b) < u);

            return t_next - t;
        }

        public double uniform(double min, double max)
        {
            return (min + (max - min) * rnd.NextDouble());
        }
    }
}
