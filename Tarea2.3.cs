using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w, d°, x: ");
            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double dRadianes = (dGrados / (180 / Math.PI));
            double y = Math.Round(((w * Math.Cos(dRadianes)) - x),2);
            Console.Write("y es: ");
            Console.WriteLine(y);
        }
    }
}
