using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, M, N;
            int[,] mat;
            string[] aux;

            aux = Console.ReadLine().Split(' ');
            M = int.Parse(aux[0]);
            N = int.Parse(aux[1]);

            mat = new int[M, N];

            //Leitura de Números da Matriz
            for (i = 0; i < M; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(aux[j]);
                }
            }

            //Apresentação de Números Negativos
            Console.WriteLine("VALORES NEGATIVOS:");
            for (i = 0; i < M; i++)
            {                
                for (j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
        }
    }
}