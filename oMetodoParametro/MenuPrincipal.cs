using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oMetodoParametro
{
    public class MenuPrincipal
    {
         private static void Tarefa1(){
            Console.Clear();
            Console.WriteLine("Executando tarefa 1.");
            Console.ReadLine();
        }

        private static void Tarefa2(){
            int umValor;
            Console.Clear();
            Console.WriteLine("Executando tarefa 2");
            Console.WriteLine("Digite um valor: ");
            umValor = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
         public static bool oMenuPrincipal(){
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1) Executar tarefa 1.");
            Console.WriteLine("2) Executar tarefa 2");
            Console.WriteLine("3), Sair");
            Console.Write("\r\nOpcao: ");

            switch(Console.ReadLine()){
                case "1":
                    Tarefa1();
                    return true;
                case "2":
                    Tarefa2();
                    return true;
                case "3":
                    return false;
                default:
                    return true;        
            }            
        }
    }
}