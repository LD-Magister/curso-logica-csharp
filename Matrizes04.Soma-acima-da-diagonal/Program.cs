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
            soma = 0;

            //Leitura da Matriz
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(aux[j]);
                }
            }

            //Apresentação do Maior Número
            for (i = 0; i < N; i++)
            {                
                for (j = 0; j < N; j++)
                {
                    if (j > i)
                    {
                        soma += mat[i, j];
                    }
                }                
            }
            Console.WriteLine(soma);
        }
    }
}

