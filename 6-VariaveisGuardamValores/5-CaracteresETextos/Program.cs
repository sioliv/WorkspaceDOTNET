using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Executando o projeto 5- Caracteres e Textos");

           char letra = 'a';
           Console.WriteLine(letra);

           letra = (char)65;
           Console.WriteLine(letra);

           letra = (char) (76 + 1);
           Console.WriteLine(letra);

           string primeiraFrase = "Alura - cursos de tecnologia";
           Console.WriteLine(primeiraFrase);

           string vazia = " ";
           Console.WriteLine(vazia);

           letra = ' '; // no char nao posso ter um cacarter vazio. tem que ter algo. ao menos um espaco. 

           string cursos = @"Cursos disponiveis: 
- Go 
- C# 
- Python 
- Java";

            Console.WriteLine(cursos);



        


           Console.WriteLine("Digite uma tecla pra terminar o programa...");
           Console.ReadLine();



           double salario;
            salario = 3000.10;
            Console.WriteLine(salario);

            double numero1 = 9, numero2 = 2.0, numero3 = 4.0, resultado;
            resultado = numero1 / numero2;
            Console.WriteLine(resultado);

            resultado = 9/2;
            Console.WriteLine(resultado);

            resultado = Math.Sqrt(9);
            Console.WriteLine(resultado);

            resultado = Math.Pow(9,2); // Serve para potenciacao e Radiciacao. 9 elevado a 9 é 81
            Console.WriteLine(resultado);

            resultado = Math.Pow(81, (1/3.0));
            Console.WriteLine(resultado);

            resultado = Math.Pow(27,(1/3.0));
            Console.WriteLine(resultado);

            resultado = Math.Pow(125, 1/3.0);
            Console.WriteLine(resultado);

            int preInc = 7, posInc = 7, preDec = 7, posDec = 7;
            
            Console.WriteLine($"preInc = {++preInc}" ); //Pega o valor 7, incrementa esse valor e o resultado da variável vale 8
            Console.WriteLine($"posInc =  {posInc ++}"); //Imprime o valor da variável pára depois fazer o incremento
            Console.WriteLine($"preDec = {--preDec}");
            Console.WriteLine($"posDec = {posDec--}");

            Console.WriteLine("\n Reimprimindo");

            Console.WriteLine($"preInc = {preInc}");
            Console.WriteLine($"posInc = {posInc}");
            Console.WriteLine($"preDec = {preDec}");
            Console.WriteLine($"posDec = {posDec}");

            Console.WriteLine("Tecle qualquer número para fechar...");
            


            Console.WriteLine("Operacoes aritmeticas");

            int a = 5, b = 2, c;
            int Soma, sub, Mult, Quociente, Resto;
            Double divExata, RaizQuadrada, Quadrado, Cubo, RaizCubica;

            //Calculos
            Soma = a + b;
            sub = a-b;
            Mult = a * b;
            Quociente = a/b;
            Resto = a%b;
            divExata = 9/2.0;
            RaizQuadrada = Math.Sqrt(36);
            Quadrado = Math.Pow(a, b);
            c = b+1;
            Cubo = Math.Pow(c,c);
            RaizCubica = Math.Pow(125, 1/3.0);

            //Impressão dos resultados
            Console.WriteLine($"{a}+{b} = {Soma}");
            Console.WriteLine($"{a} - {b} = {sub}");
            Console.WriteLine($"{c} elevado a {c} = {Cubo}");



            Console.WriteLine("Operacoes Artimeticas: ");
            //Exemplos

            double raio = 2;

            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"área calculada = {area}");

            double x = 2;
            double resultadoDaFuncao = 4 * Math.Pow(x,2) + 7 *x -2;
            Console.WriteLine($"resultado Da Funcao = {resultadoDaFuncao}");

            double n1 = 10;
            double n2 = 20;
            double n3 = 30;
            double valor = (n1+n2+n3)/3 -5;
            Console.WriteLine(valor);


            Console.WriteLine("Conversao implicita");
            int v = 5;
            Double y = v;
            Console.WriteLine(y);

            Console.WriteLine("Type casting - conversao explicita");
            int primeiroValor = 5 , segundoValor = 2;
            float f = (float)primeiroValor/segundoValor;
            Double d = x/(Double)y;
            Console.WriteLine(d);
            Console.WriteLine(f);


            Console.WriteLine("Exemplo 1");

            int oPrimeiroNumero, oSegundoNumero, oTerceiroNumero, soma;
            Double media;
            Console.WriteLine("Digite os três números ");
            oPrimeiroNumero = int.Parse(Console.ReadLine());
            oSegundoNumero = int.Parse(Console.ReadLine());
            oTerceiroNumero = int.Parse(Console.ReadLine());

            soma = oPrimeiroNumero + oSegundoNumero + oTerceiroNumero;
            media = (double)soma /3;
            Console.WriteLine($" a soma dos três números é: {soma}" );
            Console.WriteLine($"A média dos três números é: {media}");

            Console.WriteLine("Exemplo 2");
            double cateto1, cateto2, hipotenusa;
            Console.WriteLine("Digite os dois catetos");

            cateto1 = double.Parse(Console.ReadLine());
            cateto2 = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cateto1,2)+ Math.Pow(cateto2,2));
            Console.WriteLine($"hipotenusa = {hipotenusa}");

            Console.WriteLine("Exemplo 3");

            double salarioBruto, inss;

            Console.WriteLine("Digite o valor do salário bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());
            inss = salario * 0.11;

            Console.WriteLine($"O valor do INSS = R$ {inss:0:00}");
            
            Console.ReadLine();


             //Define a variável antes para poder utilizar.
            //o C# é fortemente tipada

            Console.WriteLine("Projeto 2 - Criando Variáveis");

            int idade;
            int idadeDeFernanda = 14;
            String nome2 = "Fernanda";
            String nome = "Carla";
            idade = 27;
            Console.WriteLine("Minha idade é " + idade);

            idade = 27 - 5;
            Console.WriteLine("Minha idade é " + idade);
            idade = (5 * 2) - 6; // Da preferencia a multiplicação, divisão e soma.

            Console.WriteLine("A idade de " +nome+ " é de: " + idade);

            //Não faz a quebra de linha.
            Console.Write(idade);

            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();




        }
    }
}
