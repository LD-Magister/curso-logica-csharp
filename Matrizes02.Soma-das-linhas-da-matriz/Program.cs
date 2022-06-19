using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, N, soma;
            int[,] mat;
            string[] aux;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            //Leitura da Matriz
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(aux[j]);
                }
            }

            //Soma das Linhas
            for (i = 0; i < N; i++)
            {
                soma = 0;
                for (j = 0; j < N; j++)
                {
                    soma+= mat[i, j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}

