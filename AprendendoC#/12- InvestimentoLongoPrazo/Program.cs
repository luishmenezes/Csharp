using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 12 - investimento longo prazo");

        double investimento = 1000;
        double fatorRendimento = 1.005;
        int anos;
        int mes;

        for (anos = 1; anos <= 5; anos++)
        {
            for (mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }


            fatorRendimento += +0.001;
        }

        Console.WriteLine("depois de 5 anos voce terá R$ " + investimento);


        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }
}
