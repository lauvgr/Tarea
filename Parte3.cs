using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Digite c en grados: ");
            double c = double.Parse(Console.ReadLine());
            double cRadianes = Math.Round(((Math.PI * c) / 180), 2);

            double t = Math.Round((z / Math.Sin(cRadianes)),2);
            Console.Write("El lado t es: ");
            Console.WriteLine(t);

            double y = Math.Round((t * Math.Cos(cRadianes)), 2);
            Console.Write("El lado y es: ");
            Console.WriteLine(y);

            double a = Math.Asin(y / t);
            Console.Write("El ángulo a es: ");
            double aGrados = Math.Round((a * (180 / Math.PI)), 2);
            Console.WriteLine(aGrados);

        }
    }
}
