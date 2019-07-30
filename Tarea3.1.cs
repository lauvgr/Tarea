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
            double smmlv = 828116;

            if (sal < (smmlv * 2))
            {
                Console.WriteLine("Le corresponde la tarifa A");

            }
            else if ((smmlv * 2) <= sal && sal < (smmlv * 4))

            {
                Console.WriteLine("Le corresponde la tarifa B");

            }
            else if (sal > (smmlv * 4))
            {
                Console.WriteLine("Le corresponde la tarifa C");

            }
        }
    }
}
