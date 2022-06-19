using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int senha, senhaCorreta;

            senhaCorreta = 2002;
            senha = int.Parse(Console.ReadLine());

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}