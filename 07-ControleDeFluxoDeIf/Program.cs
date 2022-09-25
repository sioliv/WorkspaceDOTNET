using System;

namespace _07__Controle_de_fluxo_com_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - 07 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;



            bool grupo = true;
            bool acompanhado = quantidadePessoas > 1;

            if(idadeJoao >= 18 || grupo ){

                Console.WriteLine("Pode entrar!");

            } else {             
                    
                    Console.WriteLine("Não pode entrar!");
                }
               
             //Se ele não tem 18 anos, ele não pode entrar

             //OBS: a CONDIÇÃO UTILIZADA EM UM COMANDO IF NORMALMENTE É COMPOSTA POR EXPRESSÕES BOOLEANAS EXPRESSAS POR COMPARAÇÕES
             //DE VALORES ATRAVÉS DE OPERADORES RELACIONAIS.

             //Sistema para mostrar se o aluno foi aprovado ou não

             int notaDoALuno;

             Console.WriteLine("Digite a nota do aluno");

             notaDoALuno = int.Parse(Console.ReadLine());

             if(notaDoALuno >= 60){
                Console.WriteLine("Aluno Aprovado");
             }


             int segundaNotadoALuno;

             Console.WriteLine("Digite a nota do aluno: ");

             segundaNotadoALuno = int.Parse(Console.ReadLine());

             if(segundaNotadoALuno >=60 ){

                Console.WriteLine("Aluno Aprovado");
                Console.WriteLine("Parabéns!");

             } else {

                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("Ele deverá fazer a reavaliação");
             }
             
    
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}
