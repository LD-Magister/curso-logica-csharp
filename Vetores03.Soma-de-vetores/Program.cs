using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N;
            int[] seqA, seqB, seqC;
            string[] aux;

            N = int.Parse(Console.ReadLine());
            seqA = new int[N];
            seqB = new int[N];
            seqC = new int[N];

            //Leitura Sequência A
            aux = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++)
            {                
                seqA[i] = int.Parse(aux[i]);
            }

            //Leitura Sequência B
            aux = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++)
            {                
                seqB[i] = int.Parse(aux[i]);
            }

            //Montagem e apresentação de Sequência C
            for (i = 0; i < N; i++)
            {
                seqC[i] = seqA[i] + seqB[i];
                Console.Write(seqC[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

