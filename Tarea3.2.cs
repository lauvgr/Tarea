using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double sal = double.Parse(Console.ReadLine());
            double smlmv = 828116;
            double smlmdv = (sal / 30);

            if (sal < (smlmv * 2))
            {
                double a = smlmdv * 0.1170;
                Console.WriteLine("Le corresponde la tarifa A");
                Console.WriteLine(a);

            }
            else if ((smlmv * 2) <= sal && sal < (smlmv * 5))

            {
                Console.WriteLine("Le corresponde la tarifa B");
                double b = smlmdv * 0.4610;
                Console.WriteLine(b);


            }
            else if (sal > (smlmv * 5))
            {
                Console.WriteLine("Le corresponde la tarifa C");
                double c = smlmdv * 1.2150;
                Console.WriteLine(c);

            }
        }
    }
}

