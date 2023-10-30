using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Realizando o projeto 10 - calculando poupança");

        double investimento = 1000;
        int mes = 1;

        //rendimento de 0.5% (0.005) mes
        while( mes <= 12)
        {
            investimento += investimento * 0.005;
            
            Console.WriteLine("no mes " + mes + " Seu saldo é de " + investimento);

            mes++;
        }
        



        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}