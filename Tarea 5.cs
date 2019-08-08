using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de contrato (  dependiente: 1    independiente: 2  ): ");
            int con = int.Parse(Console.ReadLine());

            double smlmv = 828116;
            double bc;
            double arl = 0;
            double eps;
            double pension;
            double deduccion = 0;
            double bonificacion = 0;
            int risk;

            if ((sal * 0.4)>= smlmv)
            {
                bc = sal * 0.4;
            }
            else
            {
                bc = smlmv;
            }


            switch (con) 
            {
                case 1:

                pension = bc * 0.04;
                eps = bc * 0.04;
                deduccion = pension + eps + arl;
                bonificacion = sal;
                    break;


                case 2:
            
                Console.WriteLine("Ingrese su clase de riesgo ( de 1 a 5) : ");
                risk = int.Parse(Console.ReadLine());

                pension = bc * 0.16;
                eps = bc * 0.12;

                switch(risk)
                {
                    case 1:
                        arl = bc * 0.00522;
                        break;
                    case 2:
                        arl = bc * 0.01044;
                        break;
                    case 3:
                        arl = bc * 0.02436;
                        break;
                    case 4:
                        arl = bc * 0.04350;
                        break;
                    case 5:
                        arl = bc * 0.06960;
                        break;
                }
                deduccion = pension + eps + arl;
                    break;
            }


            double salreal = sal - deduccion;
            double salanual = (salreal * 12) + bonificacion;

            Console.WriteLine("Su salario real es: ");
            Console.WriteLine(salreal);
            Console.WriteLine("Su salario anual real con bonificaciones es: ");
            Console.Write(salanual);

            
        }
    }
}
