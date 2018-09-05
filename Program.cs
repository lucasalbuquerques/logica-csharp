using System;
using System.Globalization;
using primeiro_projeto.Exemplos.IF_ELSE;
using primeiro_projeto.Exemplos.Vetores;

namespace primeiro_projeto
{
    class teste1
    {
        static void Main(string[] args)
        {

            int x, soma1, soma2, soma3,soma4,soma5,soma6;

            x = int.Parse (Console.ReadLine());

            soma1 = x + 1;
            soma2 = soma1 + 2;
            soma3 = soma2 + 2;
            soma4 = soma3 + 2;
            soma5 = soma4 + 2;
            soma6 = soma5 + 2;

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
            Console.WriteLine(soma4);
            Console.WriteLine(soma5);
            Console.WriteLine(soma6);


            Console.ReadLine();
        }
    }
}
