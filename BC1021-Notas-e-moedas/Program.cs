using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            double N;
            int quantidade, nota, moeda, resto;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)((N * 100.0) + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quantidade = resto / (nota * 100);
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % (nota * 100);

            nota = 50;
            quantidade = resto / (nota * 100);
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % (nota * 100);

            nota = 20;
            quantidade = resto / (nota * 100);
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % (nota * 100);

            nota = 10;
            quantidade = resto / (nota * 100);
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % (nota * 100);

            nota = 5;
            quantidade = resto / (nota * 100);
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % (nota * 100);

            nota = 2;
            quantidade = resto / (nota * 100);
            Console.WriteLine(quantidade + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quantidade = (resto / moeda);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + (moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture));
            resto = (resto % moeda);

            moeda = 50;
            quantidade = (resto / moeda);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + (moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture));
            resto = (resto % moeda);

            moeda = 25;
            quantidade = (resto / moeda);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + (moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture));
            resto = (resto % moeda);

            moeda = 10;
            quantidade = (resto / moeda);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + (moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture));
            resto = (resto % moeda);

            moeda = 5;
            quantidade = (resto / moeda);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + (moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture));
            resto = (resto % moeda);

            moeda = 1;
            quantidade = (resto / moeda);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + (moeda / 100.0).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}