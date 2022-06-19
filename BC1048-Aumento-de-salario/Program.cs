using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            double salario, valorReajuste;
            int percReajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            percReajuste = 0;

            if (salario <= 400.0)
            {
                percReajuste = 15;
            }
            else if (salario < 800.01)
            {
                percReajuste = 12;
            }
            else if (salario < 1200.01)
            {
                percReajuste = 10;
            }
            else if (salario < 2000.01)
            {
                percReajuste = 7;
            }
            else
            {
                percReajuste = 4;
            }

            valorReajuste = salario * (percReajuste / 100.0);

            Console.WriteLine("Novo salario: " + (salario + valorReajuste).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percReajuste + " %");
        }
    }
}