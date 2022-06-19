using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int N, i, posicao;
            double maior;
            double[] numeros;
            string[] aux;

            N = int.Parse(Console.ReadLine());            
            numeros = new double[N];
            
            //Leitura dos Números:
            aux = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(aux[i], CultureInfo.InvariantCulture);
            }

            //Maior Número e Posição
            maior = numeros[0];
            posicao = 0;

            for (i = 0; i < N; i++)
            {
                if (numeros[i] >= maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}

