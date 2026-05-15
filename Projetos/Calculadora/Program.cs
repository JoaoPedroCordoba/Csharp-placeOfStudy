using System;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading;

class Program
{
    public static void Main (){
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
            case "+":{

                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double resultado = Aritmetica.Adicao(n1, n2);

                 Console.WriteLine($"Resultado: {resultado}");

                 Thread.Sleep(2500);

                Console.WriteLine("--Selecione a Operação que deseja realizar--");
                Console.WriteLine("+ Soma");      
                Console.WriteLine("exit - Sair do Programa");
                string n = "";

                n = Convert.ToString(Console.ReadLine());

                switch (n)
                {
                    case "menu":
                    Program.Main();
                    break;

                    case "exit":
                    Console.Clear();
                    Console.WriteLine("Obrigado por Ultilizar meu Programa👍");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                    default:
                    Console.WriteLine("Digite uma opção valida"); 
                    Thread.Sleep(2500);
                    Main();
                    break;       
                }
            break; }

            case "-":{              
                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double resultado = Aritmetica.Subtracao(n1, n2);

                 Console.WriteLine($"Resultado: {resultado}");

                 Thread.Sleep(2500);

                Console.WriteLine("--Selecione a Operação que deseja realizar--");
                Console.WriteLine("+ Soma");      
                Console.WriteLine("exit - Sair do Programa");
                string n = "";

                n = Convert.ToString(Console.ReadLine());

                switch (n)
                {
                    case "menu":
                    Program.Main();
                    break;

                    case "exit":
                    Console.Clear();
                    Console.WriteLine("Obrigado por Ultilizar meu Programa👍");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                    default:
                    Console.WriteLine("Digite uma opção valida"); 
                    Thread.Sleep(2500);
                    Main();
                    break;       
                }
            break;}

            case "/":
                Aritmetica.Divisao();
            break;

            case "*":
                Aritmetica.Multiplicacao();
            break;

            case "~":
                Aritmetica.Raiz();
            break;

            case "!":
                Aritmetica.Exponenciacao();
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
}

class Aritmetica
{
     public static double Adicao(double a , double b){
        
        double soma = a + b;

        return soma;

    }

    public static double Subtracao(double a , double b){

        double subtrair = a - b;

        return subtrair;

    }

    public static void Multiplicacao()
    {
        Console.Clear();
        double numero1 = 0 , numero2 = 0;

        Console.WriteLine("Digite o Primeiro Numero que deseja Multiplicar: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero que deseja Multiplicar: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        double multi = numero1 * numero2;

        Console.WriteLine($"A Multiplicação é: {multi} \n");

        Thread.Sleep(2500);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("--Selecione a Operação que deseja realizar--");
        Console.WriteLine("* - Multiplição");
        Console.WriteLine("menu - Retornar ao inicio");        
        Console.WriteLine("exit - Sair do Programa");
        Console.ResetColor();
        string resultado = "";

        resultado = Convert.ToString(Console.ReadLine());

        switch (resultado)
        {
            case "menu":
            Program.Main();
            break;

            case "exit":
            Console.Clear();
            Console.WriteLine("Obrigado por Ultilizar meu Programa👍");
            Thread.Sleep(2500);
            Console.Clear();
            Environment.Exit(0);
            break;

            case "*":
            Multiplicacao();
            break;

            default:
            Console.WriteLine("Digite uma opção valida"); 
            Thread.Sleep(2500);
            Multiplicacao();
            break;       
        }
    }

    public static void Divisao(){
        Console.Clear();
        double numero1 = 0 , numero2 = 0;

        Console.WriteLine("Digite o Primeiro Numero que deseja dividir: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero que deseja dividir: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        double divisao = numero1 / numero2;

        Console.WriteLine($"A divisão é: {divisao} \n");

        Thread.Sleep(2500);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("--Selecione a Operação que deseja realizar--");
        Console.WriteLine("/ - Divisão");
        Console.WriteLine("menu - Retornar ao inicio");        
        Console.WriteLine("exit - Sair do Programa");
        Console.ResetColor();
        string resultado = "";

        resultado = Convert.ToString(Console.ReadLine());

        switch (resultado)
        {
            case "menu":
            Program.Main();
            break;

            case "exit":
            Console.Clear();
            Console.WriteLine("Obrigado por Ultilizar meu Programa👍");
            Thread.Sleep(2500);
            Console.Clear();
            Environment.Exit(0);
            break;

            case "/":
            Divisao();
            break;

            default:
            Console.WriteLine("Digite uma opção valida"); 
            Thread.Sleep(2500);
            Divisao();
            break;       
        }
    }  
    public  static void Raiz(){}
    public static void Exponenciacao(){}
}