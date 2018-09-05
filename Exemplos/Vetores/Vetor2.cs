using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_projeto.Exemplos.Vetores
{
    class Vetor2
    {
        public static void vetor1()
        {

        
        double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

        String[] vet;

        vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        triangulo = (double) (A* C) / 2;
            circulo = (double) (3.14159 * Math.Pow(C, 2.0));
            trapezio = (double) ((A + B) * C) / 2;
            quadrado = (double) B * B;
            retangulo = (double) A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}