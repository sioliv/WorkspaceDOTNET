using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioFinal;

            Console.WriteLine("Digite o salário do funcionário: ");

            salario = double.Parse(Console.ReadLine());

           if(salario <= 1000)
           {      
            
            salarioFinal = salario * 0.08;

           } else 

                 if (salario >=1000 && salario <= 1800)

           {

            salarioFinal = salario * 0.10;

           } else
           
           {
             salarioFinal = salario * 0.12;   
           }

           Console.WriteLine($"Valor a ser descontado de INSS = R$ {salarioFinal:0.00}");
        }

        //Cinco aliquotas = 4 comandos ifs
        //3 aliquotas = 2 comandos ifs
    }
}
