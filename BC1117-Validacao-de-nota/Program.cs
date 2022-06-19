using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            double nota, soma, media;
            int cont;

            cont = 0;
            soma = 0;

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota >= 0 && nota <= 10)
                {
                    soma = soma + nota;
                    cont = cont + 1;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            media = soma / 2;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}