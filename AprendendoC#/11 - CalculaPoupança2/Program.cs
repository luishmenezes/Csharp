using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Realizando o projeto 11 - calculando poupança");

        double investimento = 1000;
        int mes;

       for( mes = 1; mes <= 12; mes += 1)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes + " seu saldo é de " + investimento);
        }




        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}