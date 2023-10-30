using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 4000.50;
        Console.WriteLine(salario);
        
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long y = 20000000000000;
        Console.WriteLine(y);

        short x = 15000;
        Console.WriteLine(x);

        float altura = 1.62f;
        Console.WriteLine(altura);
        

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}