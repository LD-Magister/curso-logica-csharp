using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int total, anos, meses, dias, resto;

            total = int.Parse(Console.ReadLine());

            anos = total / 365;
            resto = total % 365;
            Console.WriteLine(anos + " ano(s)");

            meses = resto / 30;
            resto = resto % 30;
            Console.WriteLine(meses + " mes(es)");

            dias = resto;
            Console.WriteLine(dias + " dia(s)");
        }
    }
}