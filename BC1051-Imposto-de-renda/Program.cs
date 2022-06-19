using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            imposto = 0.0;

            if (salario > 4500.0)
            {
                imposto = (salario - 4500) * 0.28;
            }

            if (salario > 3000 && salario <= 4500)
            {
                imposto = imposto + ((salario - 3000) * 0.18);
            }
            else if (salario > 4500)
            {
                imposto = imposto + (1500 * 0.18);
            }

            if (salario > 2000 && salario <= 3000)
            {
                imposto = imposto + ((salario - 2000) * 0.08);
            }
            else if (salario > 3000)
            {
                imposto = imposto + (1000 * 0.08);
            }

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}