using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int N, i, qtdPares;            
            int[] numeros;
            string[] aux;

            N = int.Parse(Console.ReadLine());            
            numeros = new int[N];
            
            //Leitura dos Números:
            aux = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(aux[i], CultureInfo.InvariantCulture);
            }

            //Pares & Quantidade de Pares
            qtdPares = 0;

            for (i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(aux[i], CultureInfo.InvariantCulture);
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    qtdPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(qtdPares);
        }
    }
}

