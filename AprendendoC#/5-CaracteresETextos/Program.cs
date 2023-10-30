using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Fazendo a primeira frase";
        Console.WriteLine(primeiraFrase + 2023);

        string lista = @"-Arroz
         -Feijao
         -Macarrão
         -Frango";
        Console.WriteLine(lista);


        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}
