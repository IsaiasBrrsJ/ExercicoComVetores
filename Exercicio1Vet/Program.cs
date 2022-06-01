using System;
using System.Collections.Generic;
using System.Linq;

namespace Treinoasd_a
{
    class Program
    {
        static void Main(string[] args)
        {

            //9.Faça um algoritmo para ler um vetor de 20 números.Após isto, deverá ser lido mais 
            //    um número qualquer e verificar se esse número existe no
            //    vetor ou não. Se existir, o algoritmo deve gerar um novo vetor sem esse número. (
            //        Considere que não haverá números repetidos no vetor).


            int[] vet = new int[20];
            int cont = 0;
            int novoNum = 0;

            for(int i = 0; i < vet.Length; i++)
            {

                Console.Write($"Digite o {i + 1}° Numero: "); // Digita os 20 numeros;
                vet[i] = int.Parse(Console.ReadLine());

                if(i == vet.Length - 1) // se o i for igual ao vetor - 1; pede pra digitar mais um número;
                {
                    Console.Write("Digite mais um numero: ");
                    novoNum = int.Parse(Console.ReadLine());


                 
                }
              
            }
            foreach (var num in vet)
            {
                if (novoNum != num)
                    Console.WriteLine($" {num}");

            }




            while (cont < vet.Length )
            {
              
                if (vet[cont].Equals(novoNum))
                {
                    
                    List<int> lis = new List<int>();

                    for (int j = 0; j < vet.Length; j++)
                    {
                        lis.Add(vet[j]); //adciona o vetor na lista;
                        lis.RemoveAll(num => num.Equals(novoNum)); //remove o ultimo digitado se for igual o do vetor;
                        lis.Sort(); // Organiza a lista;


                        int[] novoVet = lis.ToArray();
                        
                        if (novoVet.Contains(novoNum))
                        {
                            
                            foreach (var ArraySemRepetidos in novoVet)
                            {
                               
                                Console.WriteLine($"{ArraySemRepetidos}");
                            }
                        }
                        

                    }

                }
                
                cont++;
            }
            Console.ReadKey();


           
        }
    }
}
