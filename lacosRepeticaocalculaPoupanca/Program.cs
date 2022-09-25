using System;

namespace lacosRepeticaocalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - calcula poupança ");

            double investimento = 1000;

            //rendimento de 0.5% (0.005) ao mês

            investimento = investimento + investimento * 0.005;

            int mes = 1;

            //Se for true. se o mês for <=12 execute
            //. Com ela, enquanto a condição for verdadeira, o bloco de código será executado
            //Todos os operadores de comparação e lógicos são válidos na expressão condicional do while! Use-os com sabedoria!
            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + investimento + "você tem R$ " + investimento);

                // mes = mes + 1
                mes += 1 ; // mes vai passar a valer mes + 1 = 2, volta pro while. Quando ele passar a valer 13 vai dar false e o 
                //programa termina
            }


            Console.WriteLine("Praticando o Do While");

            Double numero, raiz;

            do
            {
                Console.Write("Digite um numero ");
                numero = Double.Parse(Console.ReadLine());

                if (numero > 0){

                raiz = Math.Sqrt(numero);
                Console.WriteLine($"A raiz quadrada de {numero} = {raiz}"); 

                }
                
            } while(numero > 0);

            //Console.WriteLine("Comando While utilizando o for");

           // double raizQuadrada, numeroQueQueroRaizQuadrada;
            //int contador = 1;

        //
           // while(contador <= 10){
                
               // Console.WriteLine("Digite um numero ");
               // numeroQueQueroRaizQuadrada = double.Parse(Console.ReadLine());

               // raizQuadrada = Math.Sqrt(numeroQueQueroRaizQuadrada);
               // Console.WriteLine($"A raiz quadrade de {numeroQueQueroRaizQuadrada} = {raizQuadrada}");
               // contador = contador + 1; // mesma coisa que contador++
           // }

            Console.WriteLine("Laco de repetição for");
            Console.WriteLine("For faz a mesma coisa do que o while");

          double investimento2 = 1000;

           for (int oMes = 1; oMes <= 12; oMes++){
            //Bloco de código que quero que seja reoslvido

                investimento2 = investimento2 + investimento2 * 0.005;
                Console.WriteLine("No mês " + investimento2 + "você tem R$ " + investimento2);

           }


            
            Console.WriteLine("Digite enter para fechar");
            Console.ReadLine();
        }
    }
}
