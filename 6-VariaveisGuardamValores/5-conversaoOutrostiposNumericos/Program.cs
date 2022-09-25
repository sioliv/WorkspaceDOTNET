using System;

namespace _5_conversaoOutrostiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5 - Conversao outros tipos numericos");

            // Float aceita variáveis tanto do tipo intiero como do tipo flutuante

            Double salario = 3000.15;
            Console.WriteLine(salario);

            int salarioInteiro = (int)salario; // No casting ele só vai considerar a parte inteira. perde precisão.
            //Pois ignorou a precisão dos centavos.

            //Tipo de variavel de 64 bits
            long x;
            x = 200000000000000000;

            short y = 1500; //guarda valores não muito grandes.

            float altura =1.62f;

            Console.WriteLine(altura);
            Console.WriteLine(y);

            double valor1 = 10;
            double valor2 = 20;
            double total = valor1 + valor2;
            Console.WriteLine(total);
            
            double salario2 = 3000.23;
            int valor = (int) salario;
            Console.WriteLine(valor);

 


            Console.WriteLine(salarioInteiro);


            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.ReadLine();
        }
    }
}
