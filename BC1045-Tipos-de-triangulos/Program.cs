using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] lados;
            double lado1, lado2, lado3, A, B, C;

            lados = Console.ReadLine().Split(' ');
            lado1 = double.Parse(lados[0], CultureInfo.InvariantCulture);
            lado2 = double.Parse(lados[1], CultureInfo.InvariantCulture);
            lado3 = double.Parse(lados[2], CultureInfo.InvariantCulture);

            A = 0.0;
            B = 0.0;
            C = 0.0;

            if (lado1 >= lado2 && lado1 >= lado3)
            {
                A = lado1;
                if (lado2 >= lado3)
                {
                    B = lado2;
                    C = lado3;
                }
                else
                {
                    B = lado3;
                    C = lado2;
                }
            }
            else if (lado2 >= lado1 && lado2 >= lado3)
            {
                A = lado2;
                if (lado1 >= lado3)
                {
                    B = lado1;
                    C = lado3;
                }
                else
                {
                    B = lado3;
                    C = lado1;
                }
            }
            else if (lado3 >= lado1 && lado3 >= lado2)
            {
                A = lado3;
                if (lado1 >= lado2)
                {
                    B = lado1;
                    C = lado2;
                }
                else
                {
                    B = lado2;
                    C = lado1;
                }
            }

            if (A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                if (Math.Pow(A, 2) > (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }

                if (Math.Pow(A, 2) < (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && A == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}