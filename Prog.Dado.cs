using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0;
            int total = 0;
            int anterior = 0;
            bool uno = false;
          
            string continuar = "s";

            for (int vidas = 3; vidas > 0; vidas--)
            {
                Console.WriteLine("Te quedan " + vidas + " vidas");
                while (continuar == "s")
                {
                    dado = aleatorio.Next(1, 6);
                    
                    Console.WriteLine("Dado = " + dado);
                    total = total + dado;
                    Console.WriteLine("Total = " + total);
                    
                    if (dado == 1)
                    {
                        if (uno)
                        {
                            total = total - 10;
                            Console.WriteLine("Pierde una vida (-10 puntos)");
                            Console.WriteLine("Tu nuevo total es = " + total);
                            continuar = "l";
                        }
                        else
                        {
                            uno = true;
                        }
                    }
                    if ((dado == 6)&&(anterior == 6))
                    {
                          
                        if (vidas < 3)
                        {
                            Console.WriteLine("Gana 1 vida");
                            vidas++;
                            Console.WriteLine("Te quedan " + vidas + " vidas");
                        }
                    }
                    if (total >= 100)
                    {
                        Console.WriteLine("Ha Ganado");
                        break;
                    }
                    else if (continuar == "s")
                    {
                        Console.WriteLine("Desea continuar? (s/n): ");
                        continuar = Console.ReadLine();
                        if (continuar == "n")
                        {
                            
                            break;
                        }
                        anterior = dado;
                    }
                    

                }
                if (continuar == "n")
                {
                    Console.WriteLine("La partida ha finalizado");
                    break;
                }
                continuar = "s";
                uno = false;
                
            }
            Console.WriteLine("Su total fue: " + total + "puntos");
            Console.WriteLine("Gracias por participar!");
        }
    }
}
