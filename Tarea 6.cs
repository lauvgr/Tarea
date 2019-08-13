using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random deal = new Random();
            int card1 = deal.Next(1, 10);
            Console.WriteLine("Primera carta: " + card1);
            int card2 = deal.Next(1, 10);
            Console.WriteLine("Segunda carta: " + card2);
            int sum = card1 + card2;
            int newcard = 0;
            Console.WriteLine("Toal = " + sum);
            String more = "s";

            while (more == "s" && sum < 21)
            {
                Console.WriteLine("pedir otra carta? (s/n)");
                more = Console.ReadLine();
                Console.WriteLine("");
                if (more == "s")
                {
                    newcard = deal.Next(1, 10);
                    Console.WriteLine("Nueva carta = " + newcard);
                    sum += newcard;
                    Console.WriteLine("Nuevo total = " + sum);
                    if (sum > 21)
                    {
                        Console.WriteLine("Ha sido Eliminado");
                        more = "n";

                    }
                }
            }
            Console.WriteLine("Total = " + sum);
        }
    }
}
