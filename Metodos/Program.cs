using System;

namespace Metodos
{
    
           
    class Program
    {
         
            static void ImprimeCabecalho(){

                for(int i = 0; i < 5; i++)
            {
               
               Console.WriteLine("Algoritmos e Lógica de programacao");     
               Console.WriteLine(); //espaço na linha
            }
            
            }

            
            static void ImprimeCabecalhoComNome(String nome){
                Console.WriteLine($"Cabeçalho com nome {nome}");
                Console.WriteLine();
           }

           static void ImprimeCabecalhoComDoisParametros(string nome, char sexo){

            Console.WriteLine("Imprimindo cabeçalho com dois parâmetros");

            if(sexo == 'f' || sexo == 'F')
            {
                Console.WriteLine($"Nome da aluna : {nome}");
            } 
            
            else    
            {
                Console.WriteLine($"Nome do aluno {nome}");
                Console.WriteLine();
            }

           
        }
         static void procMax(int a, int b){

                if (a > b){
                    Console.WriteLine($"{a} é maior que {b}");
                } else {
                    Console.WriteLine($"{b} é maior que (ou igual a) {a}");
                }
            }

            static int Max(int a, int b){
                int maior;

                if (a > b){

                    maior = a;

                }
                    
                else {

                     maior = b;
                
                }
                return maior;
            }

            static int Max_v3(int a, int b){
                //Operador ternário
                //a é maior do que b?
                // é a pergunta.
                //caso sim, retorna a
                // -> senao 
                // retorna b
                return (a > b) ? a : b;
            }

            //Calculando o fatorial de um número

            public int fatorial(int n){

                int res = 1;
                int calculoFatorial;
                
                if(n == 0 || n ==1)
                {
                    return res;

                } else if (n > 1)
                {
                   calculoFatorial =  n * fatorial(n-1);
                   return calculoFatorial;
                
                } else
                
                {
                    return -1;
                }
            }

        

       static void Main(string[] args)
        {
                 
            ImprimeCabecalho();
            ImprimeCabecalhoComNome("Fernandes");
            ImprimeCabecalhoComDoisParametros("Luiza", 'F');

            int v1 = 13, v2 = 38;
            procMax(v1, v2);
            int resultado = 100 - Max(v1, v2); // maior valor entre v1 e v2 é o 38!!!.
            Console.WriteLine($"100 - { Max(v1,v2)} = {resultado}");
           
            Console.WriteLine(Max_v3(9, 20));

            int valor = -2;
            int resultadoFatorial;
            Program calc = new Program();

            resultadoFatorial = calc.fatorial(valor);
            Console.WriteLine("{0}! = {1}", valor, resultadoFatorial);


            
        }
       
            
    }
}

