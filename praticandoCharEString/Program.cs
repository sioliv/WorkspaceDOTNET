using System;

namespace praticando_char_e_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando uma variável do tipo char");

            char letra = 'a';
            char segundaLetra = 'b';

            Console.WriteLine($"Mostrando um char : {letra}");
            Console.WriteLine($"Mostrando um segundo char: {segundaLetra}");

            Console.WriteLine("Saida correspondente ao valor numérico char");

            char valor = (char)65;
            Console.WriteLine($"Valor: {valor}");

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);





            Console.WriteLine("Digite uma tecla para fechar");

            Console.ReadLine();
        }
    }
}
