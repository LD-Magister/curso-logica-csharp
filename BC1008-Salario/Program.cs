using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {

        int idFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = (horasTrabalhadas * valorHora);

        Console.WriteLine("NUMBER = " + idFuncionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

    }
}