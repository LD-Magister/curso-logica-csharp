using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int i, N;
            double media;
            string[] aluno, aux;
            double[] notas1, notas2;

            N = int.Parse(Console.ReadLine());
            aluno = new string[N];
            notas1 = new double[N];
            notas2 = new double[N];            

            //Leitura de Alunos e Notas
            for (i = 0; i < N; i++)
            {
                aux = Console.ReadLine().Split(' ');
                aluno[i] = aux[0];
                notas1[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
            }

            //Seleção e Apresentação de pessoa mais velha
            Console.WriteLine("Alunos Aprovados:");
            for (i = 0; i < N; i++)
            {
                media = (notas1[i] + notas2[i]) / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine(aluno[i]);
                }
            }
        }
    }
}

