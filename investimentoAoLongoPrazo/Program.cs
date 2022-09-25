using System;

namespace investimentoAoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - investimento a longo prazo e mês a mÊs");

            double fatorRendimento = 1.005;
            double investimento = 1000;

            for(int anos = 1; anos <=5 ; anos++){

                for(int mes = 1; mes <=12; mes++){

                    investimento *= fatorRendimento;
                   

                }

                fatorRendimento = fatorRendimento + 0.001;

            }
            Console.WriteLine("Depois de 5 anos você terá  R$ " + investimento);
        }
    }
}
