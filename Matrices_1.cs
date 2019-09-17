using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";

                }

            }

            Console.WriteLine("\nENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {


                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }



            




            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < n-2 && tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j])
                    {
                        if ((tablero[i, j] == "x") && (tablero[i + 1, j] == "x") && (tablero[i + 2, j] == "x"))
                        {
                            salida[i, j] = "1";
                            salida[i + 1, j] = "1";
                            salida[i + 2, j] = "1";
                        }
                        if ((tablero[i, j] == "o") && (tablero[i + 1, j] == "o") && (tablero[i + 2, j] == "o"))
                        {
                            salida[i, j] = "0";
                            salida[i + 1, j] = "0";
                            salida[i + 2, j] = "0";
                        }
                       
                        
                    }
                    if (j < m-2 && tablero[i,j] == tablero[i,j+1] && tablero[i, j] == tablero[i, j + 2])
                    {
                        if ((tablero[i, j] == "x") && (tablero[i, j + 1] == "x") && (tablero[i, j + 2] == "x"))
                        {
                            salida[i, j] = "1";
                            salida[i , j + 1] = "1";
                            salida[i , j + 2] = "1";
                        }
                        if ((tablero[i, j] == "o") && (tablero[i , j + 1] == "o") && (tablero[i , j + 2] == "o"))
                        {
                            salida[i, j] = "0";
                            salida[i , j + 1] = "0";
                            salida[i, j + 2] = "0";
                        }
                    }
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("\n");


            double contadorX = 0;
            double contadorO = 0;
            double contadorG = 0;
            double total = n * m;


            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {

                    if(tablero[i,j] == "x")
                    {
                        contadorX++;
                    }
                    if (tablero[i, j] == "o")
                    {
                        contadorO++;
                    }
                    if (tablero[i, j] == "-")
                    {
                        contadorG++;
                    }

                }
                
            }
          
            Console.WriteLine("X: " + contadorX + "  =  " + Math.Round((contadorX * 100 / total), 2) + "%");
            Console.WriteLine("O: " + contadorO + "  =  " + Math.Round((contadorO * 100 / total), 2) + "%");
            Console.WriteLine("-: " + contadorG + "  =  " + Math.Round((contadorG * 100 / total), 2) + "%");

        }
    }
}
