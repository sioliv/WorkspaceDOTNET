using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioFinal;

            Console.WriteLine("Digite o seu salário: ");
            
            salario = double.Parse(Console.ReadLine());

            if(salario <= 1000){

                salarioFinal = salario * 0.08;

            } else {

                salarioFinal = salario * 0.10;
            }

            Console.WriteLine($"O valor a ser descontado de INSS é de R$ {salarioFinal:0.00}");
        }
    }
}
