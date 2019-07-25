using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tarea2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese b°, z, y: ");
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double a = Math.Atan(y / z);
            double aGrados = Math.Round((a * (180 / Math.PI)), 2);
            
            double ab = aGrados + bGrados;
            double abRadianes = (ab / (180 / Math.PI));
            

            double x = Math.Round(((z * Math.Tan(abRadianes)) - y) ,2);
            Console.Write("x es: ");
            Console.WriteLine(x);

         



        }
    }
}
