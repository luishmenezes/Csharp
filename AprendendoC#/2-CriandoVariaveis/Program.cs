using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variaveis");

        int idade;

        idade = 27;
        Console.WriteLine(idade);

        idade = 28 - 5;
        Console.WriteLine("Minha idade é " + idade);

        idade = 5 * 3 - 4;
        Console.WriteLine(idade);

        idade = (5 - 2) * 3;
        Console.WriteLine(idade);

        Console.WriteLine("tecle ENTER para fechar ...");
        Console.ReadLine();
    }
}