using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1asa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Введите внутренний радиус кольца:");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите внешний радиус кольца:");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double s = pi * (Math.Pow(r2, 2) - Math.Pow(r1, 2));
            Console.WriteLine(s);
        }
    }
}
