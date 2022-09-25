using System;

namespace _4_VariaveisNumericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 - Variáveis ponto flutuante");
            double salario;
            salario = 3000.10;

            salario = 3000;
            Console.WriteLine(salario);

            double idade;
            idade = 7.0/5; // atribui o 0, ele vai considerar todas as informações depois da virgula
            //Se não atribuir o 0, ele não considera todas as informações depois da virugula. somente o numero inteiro.
            //não é um arrendondamento. Considera tudo após o ponto como um número inteiro

            double kgDoPao = 30.89;
            Console.WriteLine(kgDoPao);

            double divisaoKdDoPao = 100.0/2.52;
            Console.WriteLine(divisaoKdDoPao);

            double divisaoKgDoPao = 100/2;
            Console.WriteLine(divisaoKgDoPao);

            Console.WriteLine(idade);

            double numero1, resultado;
            int numero2;

            numero1 = 2.0;
            numero2 = 1;


            resultado = numero1 * numero2;
            Console.WriteLine(resultado);


            Console.WriteLine("Digite qualquer tecla para fechar...");
            Console.ReadLine();

            //Obs: Uma  variável do tipo double aceita um tipo inteiro, mas uma variável do tipo ponto inteiro nao
            //aceita uma variável do tipo ponto flutuante

            
        }
    }
}
