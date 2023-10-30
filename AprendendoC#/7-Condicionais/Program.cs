using System;
using System.ComponentModel.Design;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        
        if(idadeJoao >= 18)
        {
            Console.WriteLine("Entrada liberada");
            
        } else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("liberada com acompanhante");
            }
            else
            {
                Console.WriteLine("Entrada proibida");
            }

        }

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}
