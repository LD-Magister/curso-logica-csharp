using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int x, n1, n2, n3, n4, n5, n6;

            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                n1 = x + 1;
            }
            else
            {
                n1 = x;
            }

            n2 = n1 + 2;
            n3 = n2 + 2;
            n4 = n3 + 2;
            n5 = n4 + 2;
            n6 = n5 + 2;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
        }
    }
}