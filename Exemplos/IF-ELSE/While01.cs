using System;
using System.Globalization;
using primeiro_projeto.Exemplos.IF_ELSE;
using primeiro_projeto.Exemplos.Vetores;

namespace primeiro_projeto
{
    class While01
    {
        static void outracoisa (string[] args)
        {
            double idade, soma, quantidade, media;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            quantidade = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                quantidade = quantidade + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            media = soma / quantidade;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
