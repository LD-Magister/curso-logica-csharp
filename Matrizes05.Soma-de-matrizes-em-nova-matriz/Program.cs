using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, M, N;
            int[,] A, B, C;
            string[] aux;

            aux = Console.ReadLine().Split(' ');
            M = int.Parse(aux[0]);
            N = int.Parse(aux[1]);

            A = new int[N, N];
            B = new int[N, N];
            C = new int[N, N];            

            //Leitura da Matriz A
            for (i = 0; i < M; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(aux[j]);                    
                }
            }

            //Leitura da Matriz B
            for (i = 0; i < M; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {                    
                    B[i, j] = int.Parse(aux[j]);
                }
            }

            //Geração e Apresentação da Matriz C
            for (i = 0; i < M; i++)
            {                
                for (j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

