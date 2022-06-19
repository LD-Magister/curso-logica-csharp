using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, lucroMenos10p, lucroEntre10e20p, lucroMais20p;
            double lucroP, somaCompra, somaVenda, lucroTotal;
            string[] produto, aux;
            double[] compra, venda;

            N = int.Parse(Console.ReadLine());
            produto = new string[N];
            compra = new double[N];
            venda = new double[N];

            lucroMenos10p = 0;
            lucroEntre10e20p = 0;
            lucroMais20p = 0;
            somaCompra = 0.0;
            somaVenda = 0.0;

            //Leitura de Produtos
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                produto[i] = (aux[0]);
                compra[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
            }

            //Faixa de Lucros
            for (i = 0; i < N; i++)
            {
                lucroP = ((venda[i] * 100) / compra[i]) - 100;
                if (lucroP < 10)
                {
                    lucroMenos10p++;
                }
                else if (lucroP >= 10 && lucroP <= 20)
                {
                    lucroEntre10e20p++;
                }
                else
                {
                    lucroMais20p++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + lucroMenos10p);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10e20p);
            Console.WriteLine("Lucro acima de 20%: " + lucroMais20p);

            //Soma e Total
            for (i = 0; i < N; i++)
            {
                somaCompra += compra[i];
                somaVenda += venda[i];
            }
            lucroTotal = somaVenda - somaCompra;

            Console.WriteLine("Valor total da compra: " + somaCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + somaVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

