using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2.Services
{
    internal class MyMath
    {
        private static Tuple<double, bool> GetX(double a, double b, double z)
        {
            double x = 0;
            bool branch = true;
            if (z < a * b)
            {
                branch = false;
                x = Math.Sqrt(z * b * b + a * a);
            }
            else if (z >= a * b)
            {
                x = Math.Pow(Math.Sin(z), 2) + Math.Abs(z * a * b);
            }
            return Tuple.Create(x,branch);
        }

        public static Tuple<double, bool> GetValue(double a, double b, double z)
        {
            Tuple<double, bool> tuple = GetX(a, b, z);

            double x = tuple.Item1;

            double y = (a * x + b * x * Math.Cos(Math.Sqrt(x)) / (x + a * b));

            return Tuple.Create(y,tuple.Item2);
        }

    }
}
