using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto Fazendo fatorial");

        int fatorial = 1;

        for(int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }


        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}
