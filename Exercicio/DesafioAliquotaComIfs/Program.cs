using System;

namespace DesafioAliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio aliquota com Ifs");

            double salario = 3300.0;
            
            bool primeiraFaixa = salario >= 1900.0 && salario <= 2800.0;
            bool segundaFaixa = salario >= 2800.01  && salario <= 3751.0;
            bool terceiraFaixa = salario >= 3751.01 && salario <= 4664.00;

            if( primeiraFaixa){

                Console.WriteLine("O IR é de 7.5%");
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 142");

            } 
            else if(segundaFaixa)
            {
                Console.WriteLine("O IR é de 15%");
                Console.WriteLine("Pode deduzir R$ 350");    
            }
            else if (terceiraFaixa)
            {
                Console.WriteLine("O IR é de 15%");
                Console.WriteLine("Pode deduzir R$ 636");
            }

                Console.WriteLine("Tecle enter para sair");
                Console.ReadLine();
        }
    }
}
