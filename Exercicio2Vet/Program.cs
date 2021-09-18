using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //10.Faça um algoritmo para ler dois vetores V1 e V2 de 15 números cada
            //    Calcular e escrever a quantidade de vezes que V1 e V2
            //    possuem os mesmos números e nas mesmas posições.

            int[] v1 = new int[15];
            int[] v2 = new int[15];

            int[] posicaoI = new int[v1.Length];
            int[] posicaoJ = new int[v2.Length];
          
            Console.WriteLine("\n<< Primeiro Vetor >>\n");
            for(int i =0; i < v1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° Número: ");
                v1[i] = int.Parse(Console.ReadLine());

                posicaoI[i] = i;

                if(i.Equals(v1.Length - 1))
                {

                    Console.WriteLine("\n<< Segundo Vetor >>\n");
                    for (int j = 0; j < v2.Length; j++)
                    {
                        Console.Write($"Digite o {j + 1}° Número: ");
                        v2[j] = int.Parse(Console.ReadLine());

                        posicaoJ[j] = j;
                            
                    }

                }

            }

            int contador = 0;

            for (int H = 0; H < v1.Length; H++)
            {
               for (int X = 0; X <v2.Length; X++)
                {

                    if (v1[H] == v2[X] && posicaoI[H] == posicaoJ[X])
                    {
                        contador++;
                    }
                    
               }
            }

            Console.WriteLine($"\nO VETOR 1 E VETOR 2 POSSUI ( {contador}º ) Número(s) Repetido(s) na mesma posição ");
          


            Console.ReadKey();

        }
    }
}
