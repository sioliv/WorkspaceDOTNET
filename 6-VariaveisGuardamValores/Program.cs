using System;

namespace _6_VariaveisGuardamValores
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Executando projeto 6 - atribuições de variáveis ");

           int idade = 30;
           int idadeana = idade;
           Console.WriteLine(idadeana);

           idade = 25;
           Console.WriteLine(idade);

           Console.WriteLine("Rômulo depois de assistir os vídeos deste capítulo, resolveu testar o que foi dito em aula");
           Console.WriteLine("e fez um código para somar dois valores quaisquer");

           string parcela_1 = "10";
           string parcela_2 = "20";

           Console.WriteLine($"a soma das parcelas: {parcela_1} + {parcela_2} = " + parcela_1 + parcela_2);
           Console.WriteLine("Note que concatenou por ser uma soma de strings");

           Console.WriteLine("Type Casting");
           Console.WriteLine("Para fazer uma conversão em que pode haver perda de informações, é necessário fazer um type casting. Veja a instrução abaixo:");
           int idadeDeOutraPessoa = (int)30.0;
           Console.WriteLine(idadeDeOutraPessoa);

           Console.WriteLine("Tecle enter para fechar...");
           Console.ReadLine();

          
        }
    }
}
