using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREINO5vet
{
    class Program
    {
        static void Main(string[] args)
        {

            //12.Faça um algoritmo para ler 50 números e armazenar em um vetor VET
            //verificar e escrever se existem números repetidos no vetor VET
            //    e em que posições se encontram.

            int[] numVet = new int[5];
            int[] posicao = new int[numVet.Length];
            for (int i = 0; i <numVet.Length;  i++)
            {
                Console.Write($"Digite o {i + 1}º Número: ");
                numVet[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            for (int a = 0; a < numVet.Length; a++)
            {

                for (int b = a + 1 ; b < numVet.Length; b++)
                {
        
                    if (numVet[a] == numVet[b])
                    {
                       posicao[b] = b;

                        
                        Console.Beep();
                      Console.WriteLine($"{numVet[b]} repete na posição:> {posicao[b]}");
                        break;
                    }
                }

                if (a == numVet.Length - 1)
                {
                    Console.WriteLine(" ");
                    foreach (var num in numVet)
                    {
                       
                        Console.Write($"{num} |");
                    }
                }

            }
  
            Console.ReadKey();
        }
    }
}
