using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, cont;
            double soma, media;
            int[] seq;
            string[] aux;

            N = int.Parse(Console.ReadLine());
            seq = new int[N];
            soma = 0;
            cont = 0;

            //Leitura Sequência
            aux = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++)
            {                
                seq[i] = int.Parse(aux[i]);
            }

            //Média Aritmética dos Pares            
            for (i = 0; i < N; i++)
            {                
               if (seq[i] % 2 == 0)
                {
                    soma += seq[i];
                    cont++;
                }                
            }
            media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));           
        }
    }
}

