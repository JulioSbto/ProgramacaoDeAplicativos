using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha a operação que deseja realizar:");
        Console.WriteLine("+ = Soma");
        Console.WriteLine("- = Subtração");
        Console.WriteLine("* = Multiplicação");
        Console.WriteLine("/ = Divisão");

        char operacao = char.Parse(Console.ReadLine());

        Console.WriteLine("Insira o 1º Número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira o 2º Número:");
        double num2 = double.Parse(Console.ReadLine());

        if (operacao == '+')
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        else if (operacao == '-')
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        else if (operacao == '*')
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        else if (operacao == '/')
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
        }
        else
        {
            Console.WriteLine("Operação inválida.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
