using System;

namespace EstruturaHomogeneaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetor!!");

            //reservo 5 espaços de memória do tipo int
            //0, 1, 2, 3, 4
            int[] vetor = new int[5];


            //Acessar elementos de vetor. faço através de uma estrutura de repeticao

            for(int i = 0; i < 5; i ++)
            {
                Console.WriteLine($"digite o {i + 1}o. Elemento do vetor");
                vetor[i] = int.Parse(Console.ReadLine());

            }

            //Terminando o for. o meu vetor está totalmente populado

            //Variáveis quantidade e soma
            int Soma;
            int Qtde;

            Soma = SomaPares(vetor);
            Qtde = contaImpares(vetor);

            //Agora é só mostrar os resultados...

            Console.WriteLine();
            Console.WriteLine($"Soma dos números Pares: {Soma}");
            Console.WriteLine($"Quantidade dos números Impares: {Qtde}");


            //Funcoes
            //Recebo um vetor no parâmetro da minha função
            static int SomaPares(int[] v){
                int S = 0; // Variável que serve para acumular a soma dos números pares
                for(int i = 0; i < 5; i++){
                    if(v[i] % 2 ==0){

                         S = S + v[i];

                    }

                   
                }
                return S;
            }

            static int contaImpares(int[] v){

                int Q = 0;
                for(int i = 0; i < v.Length; i++){
                    if(v[i] % 2 != 0){ // se o V daquela posição modulo de 2 é diferente de zero. Ele é impar
                        Q++;
                    }
                }
                return Q;
            }


            
            Console.WriteLine("Digite qualquer tecla para sair...");

            Console.ReadKey();
        }
    }
}
