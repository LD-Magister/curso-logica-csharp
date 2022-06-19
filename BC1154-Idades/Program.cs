using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int idade, soma, cont;
            double media;

            idade = int.Parse(Console.ReadLine());
            soma = 0;
            cont = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont += 1;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double)soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}