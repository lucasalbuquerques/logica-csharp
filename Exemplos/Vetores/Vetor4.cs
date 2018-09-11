using System;
using System.Globalization;
namespace primeiro_projeto.Exemplos.Vetores
{
    class Vetor4
    {
        static void vvetor04(string[] args)
        {
            int N, id;
            double maior;
            double[] vet;
            N = int.Parse(Console.ReadLine());
            vet = new double[N];
            string[] entrada = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
            }

            maior = vet[0];
            id = 0;
            for (int j = 1; j < N; j++)
            {
                if (vet[j] > maior)
                {
                    maior = vet[j];
                    id = j;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(id);
            Console.ReadLine();
        }
    }
}
