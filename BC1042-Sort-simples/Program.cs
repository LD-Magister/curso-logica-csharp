using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] numeros;
            int n1, n2, n3, A, B, C;

            numeros = Console.ReadLine().Split(' ');
            n1 = int.Parse(numeros[0]);
            n2 = int.Parse(numeros[1]);
            n3 = int.Parse(numeros[2]);

            A = 0;
            B = 0;
            C = 0;

            if (n1 >= n2 && n1 >= n3)
            {
                A = n1;
                if (n2 >= n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                A = n2;
                if (n1 >= n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                A = n3;
                if (n1 >= n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            Console.WriteLine(C);
            Console.WriteLine(B);
            Console.WriteLine(A);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}