using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N;
            double soma, media;
            double[] seq;
            string[] aux;

            N = int.Parse(Console.ReadLine());
            seq = new double[N];
            soma = 0;

            //Leitura Sequência
            aux = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++)
            {                
                seq[i] = double.Parse(aux[i], CultureInfo.InvariantCulture);
            }

            //Média Aritmética            
            for (i = 0; i < N; i++)
            {                
               soma += seq[i];
            }
            media = soma / N;
            Console.WriteLine(media.ToString(CultureInfo.InvariantCulture));

            //Apresentação abaixo da média
            for (i = 0; i < N; i++)
            {
                if (seq[i] < media)
                {
                    Console.WriteLine(seq[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}

