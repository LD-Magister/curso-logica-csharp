using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N, qtdM, qtdF;
            double menorAlt, maiorAlt, mediaAltF;
            char[] sexo;
            double[] altura;
            string[] aux;

            N = int.Parse(Console.ReadLine());
            sexo = new char[N];
            altura = new double[N];

            qtdM = 0;
            mediaAltF = 0.0;
            qtdF = 0;
            menorAlt = 999.0;
            maiorAlt = 0.0;

            //Leitura de Pessoas
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(aux[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(aux[1]);
            }

            //Menor Altura
            for (i = 0; i < N; i++)
            {
                if (altura[i] < menorAlt)
                {
                    menorAlt = altura[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAlt.ToString("F2", CultureInfo.InvariantCulture));

            //Maior Altura
            for (i = 0; i < N; i++)
            {
                if (altura[i] > maiorAlt)
                {
                    maiorAlt = altura[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAlt.ToString("F2", CultureInfo.InvariantCulture));

            //Média Altura F e Quantidade M
            for (i = 0; i < N; i++)
            {
                switch (sexo[i])
                {
                    case 'F':
                        mediaAltF += altura[i];
                        qtdF++;
                        break;
                    case 'M':
                        qtdM++;
                        break;
                }
            }
            mediaAltF /= qtdF;
            Console.WriteLine("Media das alturas das mulheres = " + mediaAltF.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + qtdM);

        }
    }
}

