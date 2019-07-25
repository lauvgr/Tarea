using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese d°, b°, y: ");
            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double aGrados = (180 - 90 - dGrados - bGrados);
            double aRadianes = (aGrados / (180 / Math.PI));

            double z = (y / (Math.Tan(aRadianes)));
            Console.WriteLine(z);
        }
    }
}
