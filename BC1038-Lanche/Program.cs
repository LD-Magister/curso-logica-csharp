using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            string[] item;
            int cod, qtde;
            double preco, total;

            item = Console.ReadLine().Split(' ');
            cod = int.Parse(item[0]);
            qtde = int.Parse(item[1]);

            preco = 0.0;

            switch (cod)
            {
                case 1:
                    preco = 4.0;
                    break;
                case 2:
                    preco = 4.5;
                    break;
                case 3:
                    preco = 5.0;
                    break;
                case 4:
                    preco = 2.0;
                    break;
                case 5:
                    preco = 1.5;
                    break;

            }

            total = qtde * preco;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}