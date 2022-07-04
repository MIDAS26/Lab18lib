using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Input x: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Input y: ");
                double y = double.Parse(Console.ReadLine());
                double a = Lab18Lib.MyLib.A(x, y);
                Console.WriteLine("a = " + a);
                Console.WriteLine("Input z: ");
                double z = double.Parse(Console.ReadLine());
                double b = Lab18Lib.MyLib.B(z);
                Console.WriteLine("b = " + b);
        }
    }
}