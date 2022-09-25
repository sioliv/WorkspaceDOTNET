using System;

namespace oMetodoParametro
{
    class Program
    {
              
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de método sem parâmetro. procedimento imprimir menu utilizando a linguagem c#");

            while(oMetodoParametro.MenuPrincipal.oMenuPrincipal()){

            }
        
            Console.WriteLine("Digite enter para sair....");

            Console.ReadKey();
        }
    }
}
