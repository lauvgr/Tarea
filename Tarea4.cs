using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("número de votos por el partido 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("número de votos por el partido 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("número de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("número de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("número total de la población de todas las edades: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("porcentaje (de 0 a 100%) de la población que es mayor de edad: ");
            double p = double.Parse(Console.ReadLine());

            int t = a + b + blancos + anulados;
            Console.Write("total de votantes: ");
            Console.WriteLine(t);
            int m = (int)((p * n) / 100);

            bool A = t > n;
            Console.Write("Condicion 1= ");
            Console.WriteLine(A);
            bool B = (Math.Abs(a - b)) < (t * 0.10);
            Console.Write("Condicion 2= ");
            Console.WriteLine(B);
            bool C = t < (n * 0.30);
            Console.Write("Condicion 3=");
            Console.WriteLine(C);

            if ((A || B) && C)
            {
                Console.WriteLine("las elecciones deben ser realizadas nuevamente");
            }
            else if (a > b)
            {
                Console.WriteLine("las votaciones fueron exitosas");
                Console.WriteLine("Ganador de elecciones: A");
            }
            else if (b > a)
            {
                Console.WriteLine("las votaciones fueron exitosas");
                Console.WriteLine("Ganador de elecciones: B");
            }
            else
            {
                Console.WriteLine("las elecciones deben ser realizadas nuevamente");
            }

        }
    }
}
