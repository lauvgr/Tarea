using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese w, t, c°: ");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double cRadianes = (c / (180 / Math.PI));

            double z = t * Math.Sin(cRadianes);
            double y = t * Math.Cos(cRadianes);
            //Console.Write(z);
            //Console.Write(y);

            double x = Math.Round((Math.Sqrt((w * w) - (z * z)) - y),1);
            Console.Write("x es: ");
            Console.WriteLine(x);


        }
    }
}
