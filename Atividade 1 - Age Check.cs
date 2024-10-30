using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
