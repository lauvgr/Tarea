using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Digite a en grados: ");
            double a = double.Parse(Console.ReadLine());
            double aRadianes = Math.Round(((Math.PI * a)/180), 2);
            
            double y = Math.Round((t * Math.Sin(aRadianes)),2);
            Console.Write("El lado y es: ");
            Console.WriteLine(y);

            double z = Math.Round((t * Math.Cos(aRadianes)), 2);
            Console.Write("El lado z es: ");
            Console.WriteLine(z);

            double c = Math.Asin(z / t);
            Console.Write("El ángulo c es: ");
            double cGrados = Math.Round((c * (180 / Math.PI)), 2);
            Console.WriteLine(cGrados);




        }
    }
}
