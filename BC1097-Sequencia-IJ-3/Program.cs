using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j;
            j = 2;

            for (i = 1; i <= 9; i += 2)
            {
                for (j += 5; j - i != 3; j--)
                {
                    Console.Write("I=" + i);
                    Console.WriteLine(" J=" + j);
                }
            }
        }
    }
}