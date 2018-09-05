using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_projeto.Exemplos.IF_ELSE
{
    class IF_ELSE01
    {
        public static void IFELSE01()
        {

            int produto;
            double quantidade, resultado;

            string[] vet = Console.ReadLine().Split(' ');

            produto = int.Parse(vet[0]);
            quantidade = double.Parse(vet[1]);

            if (produto == 1)
            {
                resultado = quantidade * 4.00;
                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 2)
            {
                resultado = quantidade * 4.50;
                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 3)
            {
                resultado = quantidade * 5.00;
                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 4)
            {
                resultado = quantidade * 2.00;
                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 5)
            {
                resultado = quantidade * 1.50;
                Console.WriteLine("Total: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }





            Console.ReadLine();
        }
    }
}
    }
}
