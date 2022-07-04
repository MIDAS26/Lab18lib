using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab18Lib
{
    public class MyLib
    {
        public static double A(double x, double y)
        {
            double result = (2*Math.Cos(x-Math.PI/6))/0.5+Math.Pow(Math.Sin(y), 2);
            return result;
        }

        public static double B(double z)
        {
            double result = 1 + (Math.Pow(z, 2) / (3 + Math.Pow(z, 2) / 5));
            return result;
        }
    }
}