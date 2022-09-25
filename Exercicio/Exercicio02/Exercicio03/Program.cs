using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testa escopo");
            Console.WriteLine("Testando condicionais");

            int idade = 20;

            int quantidadePessoas = 3;

            bool acompanhado;

            if(quantidadePessoas >= 2)
            {

                acompanhado = true;
                //Console.WriteLine($"Verificando se está acompanhado = {acompanhado}");
            }

            else
            {

                acompanhado = false;
                //Console.WriteLine($"Verificando se não está acompanhado {acompanhado}");

            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine($"Maior de idade! a sua idade é {idade} e está acompanhado! Seja bem vindo!!!!");
            }

            else
            {
                Console.WriteLine("Você não pode entrar!");
            }


        }
    }
}
