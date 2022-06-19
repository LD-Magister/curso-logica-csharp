using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j;
            j = 7;

            for (i = 1; i <= 9; i += 2)
            {
                for (j = 7; j >= 5; j--)
                {
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + j);
                }
            }
        }
    }
}