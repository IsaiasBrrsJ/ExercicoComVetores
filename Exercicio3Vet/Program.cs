using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino4Vet
{
    class Program
    {
        static void Main(string[] args)
        {

            //    11.Faça um algoritmo para ler um vetor de 30 números.Após isto, ler
            //        mais um número qualquer
            //        calcular e escrever quantas vezes esse número aparece no vetor.




            int[] numero = new int[15];
            int novoNum = 0;
            int contador = 0;
        
           
            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° Número: ");
                numero[i] = int.Parse(Console.ReadLine());


                if(i.Equals(numero.Length - 1))
                {
                    Console.Write($"\nDigite Mais Um Número: ");
                   novoNum = int.Parse(Console.ReadLine());
                }

            }


            for (int i = 0; i < numero.Length; i++)
            {
                foreach (var num in numero)
                {
                    if (num == novoNum)
                    {
                        contador++;

                    }

                }

                if (numero[i] == novoNum)
                {
                    Console.WriteLine($"O número {novoNum}º se repete {contador} vez(es) no vetor");
                    break;
                }
                else
                {
                    Console.WriteLine("\nO vetor não possui números repetidos....");
                    break;
                }



            }








            Console.ReadKey();




       }
    }
}
