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

        string textoAdicional;

        if (acompanhado)
        {
            textoAdicional = "Cliente está acompanhado";
        }
        else
        {
            textoAdicional = "Cliente não está acompanhado";
        }
        

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Entrada liberada!");
            Console.WriteLine(textoAdicional);

        }
        else
        {

            Console.WriteLine("Entrada proibida");

        }

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}