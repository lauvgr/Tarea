using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int jugador = 0;
            
            Console.WriteLine("Ingrese número de jugadores (de 2 a 5 jugadores): ");
            int n = int.Parse(Console.ReadLine());

            //VERIFICACION # DE JUGADORES
            while ((n < 2) || (n > 5))
            {
                Console.WriteLine("Error. Minimo 2, Maximo 5 jugadores: ");
                n = int.Parse(Console.ReadLine());
            }

            while (jugador < n)
            {

                Console.WriteLine("\n\nBienvenido jugador: " + (jugador + 1));

                //INICIO JUEGO
                Random deal = new Random();
                int card1 = deal.Next(1, 11);
                Console.WriteLine("Primera carta: " + card1);
                int card2 = deal.Next(1, 11);
                Console.WriteLine("Segunda carta: " + card2);
                int sum = card1 + card2;
                int newcard = 0;
                Console.WriteLine("\nToal = " + sum);
                String continuar = "s";

                while (continuar == "s" && sum < 21)
                {
                    Console.WriteLine("pedir otra carta? (s/n)");
                    continuar = Console.ReadLine();
                    
                    if (continuar == "s")
                    {
                        newcard = deal.Next(1, 11);
                        Console.WriteLine("Nueva carta = " + newcard);
                        sum += newcard;
                        Console.WriteLine("\nNuevo total = " + sum);
                        if (sum > 21)
                        {
                            Console.WriteLine("\nHa sido Eliminado");
                            continuar = "n";
                        }
                    }
                    else if (continuar == "n")
                    {
                        Console.WriteLine("Gracias por participar");
                    }
                    else
                    {
                        Console.WriteLine("Error. Responda (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
                jugador++;
                Console.WriteLine("Total = " + sum);
                //FINAL JUEGO
            }
        }
    }
}
