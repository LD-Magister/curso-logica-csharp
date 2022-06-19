using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, N, linha, col;
            double soma;
            double[,] mat, matAlt;
            string[] aux;

            N = int.Parse(Console.ReadLine());

            mat = new double[N, N];
            matAlt = new double[N, N];

            soma = 0;

            //Leitura da Matriz
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                for (j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(aux[j], CultureInfo.InvariantCulture);
                }
            }

            //Soma dos Positivos            
            for (i = 0; i < N; i++)
            {                
                for (j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        soma+= mat[i, j];
                    }                    
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            //Linha Escolhida
            linha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (linha == i )
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            //Coluna Escolhida
            col = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (col == j)
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            //Diagonal Principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            //Matriz Alterada
            Console.WriteLine("MATRIZ ALTERADA:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.Write(Math.Pow(mat[i, j], 2).ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    else
                    {
                        Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }                    
                }
                Console.WriteLine();
            }            
        }
    }
}

