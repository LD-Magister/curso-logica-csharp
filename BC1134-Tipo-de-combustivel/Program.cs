using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int comb, alc, gas, diesel;

            comb = 0;
            alc = 0;
            gas = 0;
            diesel = 0;

            while (comb != 4)
            {
                comb = int.Parse(Console.ReadLine());

                switch (comb)
                {
                    case 1:
                        alc += 1;
                        break;
                    case 2:
                        gas += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alc);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}