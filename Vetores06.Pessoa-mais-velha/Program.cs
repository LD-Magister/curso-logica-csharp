using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, maiorIdade, iMaisVelha;
            string[] pessoa, aux;
            int[] idade;

            N = int.Parse(Console.ReadLine());
            pessoa = new string[N];
            idade = new int[N];
            maiorIdade = 0;
            iMaisVelha = 0;

            //Leitura de Pessoa e Idade
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                pessoa[i] = aux[0];
                idade[i] = int.Parse(aux[1]);
            }

            //Seleção e Apresentação de pessoa mais velha
            for (i = 0; i < N; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    iMaisVelha = i;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + pessoa[iMaisVelha]);
        }
    }
}

