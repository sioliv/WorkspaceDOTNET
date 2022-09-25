using System;

namespace PassagemDeParametros
{
    class Program
    {

       //Passagem por referência
        static void Troca(ref int x, ref int y){
            Console.WriteLine("\t******* Método Troca **********");
            Console.WriteLine($" \t Antes da troca: x = {x} e y = {y}");

        // a troca é feita aqui
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($" \t Após a troca: x = {x} e y = {y}");
        }

        //Passagem por valor

        static void TrocaInternamente(int x, int y){
            Console.WriteLine("\t******* Método Troca **********");
            Console.WriteLine($" \t Antes da troca: x = {x} e y = {y}");

            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($" \t Após a troca: x = {x} e y = {y}");



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Passagem de parâmetros através de métodos - Funções e procedimentos");
            Console.WriteLine("Chamando o método ");

            int a = 5, b = 7, c = 3, d = 19;

             Console.WriteLine($" antes da chamada do método Troca : a = {a} e b = {b}");
             Troca(ref a, ref b);
             Console.WriteLine($" após a chamada do método Troca : a = {a} e b = {b}");

             
             Console.WriteLine($" \t Antes da chamada do método TrocaInternamente: c = {c} e d = {d}");
             TrocaInternamente(c,d);             
             Console.WriteLine($" \t depois da chamada do método TrocaInternamente: c = {c} e y = {d}");

            
        }
    }
}
