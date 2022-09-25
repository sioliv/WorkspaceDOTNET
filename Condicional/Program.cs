using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Testando condicionais");

           int idade = 2;
           int quantidadePessoas = 3;

           if(idade >= 18){
            Console.WriteLine("Idade maior do que 18");

            Console.WriteLine("Seja bem vindo!!!!!!");


           } 

           else
           
           {

                if(quantidadePessoas > 2)                
                {

                    Console.WriteLine("Voce não tem 18 anos, mas pode entrar, "
                    + " pois está acompanhado!");

            } 
            else
            {

            Console.WriteLine("Idade menor do que 18");

            Console.WriteLine("Você não pode entrar!!!!!");

            }
            

           }
        }
    }
}
