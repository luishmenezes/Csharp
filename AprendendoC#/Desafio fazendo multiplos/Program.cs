using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o desafio de multiplos");

       

        for(int i = 1;  i <100;i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            } 
        }


        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}
