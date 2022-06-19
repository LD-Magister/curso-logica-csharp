using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, M, N, girarFila;            
            int[,] pelotao;
            string[] aux;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            pelotao = new int[M, N];

            //Leitura do Pelotão
            for (i = 0; i < M; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {
                    pelotao[i, j] = int.Parse(aux[j]);
                }
            }

            //Girar Pelotao
            girarFila = int.Parse(Console.ReadLine());

            for (i = 0; i < M; i++)
            {                
                for (j = 0; j < N; j++)
                {
                    if (i == girarFila - 1)
                    {
                        if (j == 0)
                        {
                            Console.Write(pelotao[i, (N - 1)] + " ");
                        }
                        else
                        {
                            Console.Write(pelotao[i, (j - 1)] + " ");
                        }
                                                
                    }                    
                    else
                    {
                        Console.Write(pelotao[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }                        
        }
    }
}

