using System;
using System.ComponentModel.Design;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Entrada liberada!");

        }
        else
        {
         
            Console.WriteLine("Entrada proibida");
          
        }
               
        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}