using System;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading;

class Program
{
    static void Main (){
        string dado = "";
        Console.Clear();
        Console.WriteLine("--Selecione a Operação que deseja realizar--");
        Console.WriteLine("+ Soma");
        Console.WriteLine("- Subtração");        
        Console.WriteLine("/ Divisão");
        Console.WriteLine("* Multiplicação");
        Console.WriteLine("~ Raiz Quadrada");
        Console.WriteLine("! Exponeciação");
        Console.WriteLine("-Digite exit par sair do programa-");
        dado = Convert.ToString(Console.ReadLine());


        switch (dado)
        {
            case "+":
                Adicao();
            break;

            case "-":
                Subtracao();
            break;

            case "/":
                Divisao();
            break;

            case "*":
                Multiplicacao();
            break;

            case "~":
                Raiz();
            break;

            case "!":
                Exponenciacao();
            break;  

            case "exit":
            Console.Clear();
            Console.WriteLine("Obrigado por Ultilizar meu Programa");
            Thread.Sleep(3000);
            Environment.Exit(0);
            break;

            default:
            Console.WriteLine("Digite uma opção valida"); 
            break;       
        }
    }


    static void Adicao()
    {
        Console.Clear();
        double numero1 = 0 , numero2 = 0;

        Console.WriteLine("Digite o Primeiro Numero que deseja somar: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero que deseja somar: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        double soma = numero1 + numero2;

        Console.WriteLine($"A soma de seus é: {soma} \n");



        Console.WriteLine("--Selecione a Operação que deseja realizar--");
        Console.WriteLine("+ Soma");
        Console.WriteLine("menu - Retornar ao inicio");        
        Console.WriteLine("exit - Sair do Programa");
        string resultado = "";

        resultado = Convert.ToString(Console.ReadLine());

        switch (resultado)
        {
            case "menu":
            Main();
            break;

            case "exit":
            Console.Clear();
            Console.WriteLine("Obrigado por Ultilizar meu Programa👍");
            Thread.Sleep(2500);
            Console.Clear();
            Environment.Exit(0);
            break;

            case "+":
            Adicao();
            break;

            default:
            Console.WriteLine("Digite uma opção valida"); 
            Thread.Sleep(2500);
            Adicao();
            break;       
        }


    }
    static void Subtracao(){}
    static void Divisao(){}
    static void Multiplicacao(){}
    static void Raiz(){}
    static void Exponenciacao(){}
}