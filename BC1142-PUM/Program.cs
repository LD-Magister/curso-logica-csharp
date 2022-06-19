using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, j, N;
            j = 1;
            string res;
            res = "";

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                for (j = j;res != "PUM" ; j++)
                {
                    if (j % 4 == 0)
                    {
                        res = "PUM";
                        Console.WriteLine(res);
                    }
                    else
                    {                        
                        Console.Write(j + " ");
                    }                    
                }
                res = "POM";
            }
        }
    }
}