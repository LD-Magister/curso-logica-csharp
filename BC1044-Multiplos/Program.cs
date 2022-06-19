using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            string[] numeros;
            int num1, num2, maior, menor;

            numeros = Console.ReadLine().Split(' ');
            num1 = int.Parse(numeros[0]);
            num2 = int.Parse(numeros[1]);

            maior = 0;
            menor = 0;

            if (num1 > num2)
            {
                maior = num1;
                menor = num2;
            }
            else
            {
                maior = num2;
                menor = num1;
            }

            if (maior % menor == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}