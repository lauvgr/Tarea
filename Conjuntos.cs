using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 15, 12, 18, 6, 3, 12, 6, 9 };
            int[] b = { 0, 4, 18, 6, 16, 10, 2, 6, 14, 12, 2, 8 };
            int[] interseccion;
            int[] union;
            int index = 0;
            

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int aordenado = a[i];
                        a[i] = a[j];
                        a[j] = aordenado;

                    }
                }
            }
            


            for (int i = 0; i < b.Length; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i] > b[j])
                    {
                        int bordenado = b[i];
                        b[i] = b[j];
                        b[j] = bordenado;

                    }
                }
            }

            if (a.Length > b.Length)
            {
                interseccion = new int[b.Length];

                for (int i = 0; i<b.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (b[i] == a[j])
                        {
                            if (index == 0 || interseccion[index - 1] != b[i])
                            {
                                interseccion[index] = b[i];
                                index++;
                            }
                        }
                    }
                }
            }
            else
            {
                interseccion = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (b[j] == a[i])
                        {
                            if (index == 0 || interseccion[index - 1] != b[j])
                            {
                                interseccion[index] = b[j];
                                index++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("intersección: ");

            for (int i =0; i < index; i++)
            {
                Console.WriteLine(interseccion[i]);
            }

            union = new int[a.Length + b.Length];
            int indexu = 0;

           for (int i = 0; i < a.Length; i++)
           {
                if (indexu == 0 || union[indexu - 1] != a[i])
                {
                    union[indexu] = a[i];
                    indexu++;
                }
                
           }

            for (int i = 0; i < b.Length; i++)
            {
                bool intersectado = false;
                for (int j = 0; j<index; j++)
                {
                    if (b[i] == interseccion[j])
                    {
                        intersectado = true;
                    }
                }
                if (indexu == 0 || union[indexu - 1] != b[i])
                {
                    if (!intersectado)
                    {
                        union[indexu] = b[i];
                        indexu++;
                    }
                   
                }

            }
            Console.WriteLine("union: ");
            for (int i = 0; i < indexu; i++)
            {
                Console.WriteLine(union[i]);
            }
            Console.WriteLine("complemento: ");
            for (int i = 0; i <= 30; i++)
            {
                bool complementado = false;
                for (int j = 0; j < indexu; j++)
                {
                    if ( i == union[j])
                    {
                        complementado = true;

                    }
                }
                if (!complementado)
                {
                    Console.WriteLine(i);

                }

            }
        }
    }
}
