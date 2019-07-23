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
            Console.Write("Digite y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Digite z: ");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Round(Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2)),2);
            Console.Write("La hipotenusa es: ");
            Console.WriteLine(t);

            double c = Math.Asin(z / t);
            Console.Write("El ángulo c es: ");
            double cGrados = Math.Round((c * (180 / Math.PI)),2);
            Console.WriteLine(cGrados);

            double a = Math.Asin(y / t);
            Console.Write("El ángulo a es: ");
            double aGrados = Math.Round((a * (180 / Math.PI)), 2);
            Console.WriteLine(aGrados);
        }
    }
}
