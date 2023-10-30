using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("sua aliquota é de 7.5%");
            Console.WriteLine("poderá deduzir 142,00 R$");
        }
        if(salario > 2800.0 && salario <= 3751.0)
        {
            Console.WriteLine("sua aliquota é de 15%");
            Console.WriteLine("poderá deduzir 350,00 R$");
        }
        if( salario > 3751.00 && salario <= 4664.0)
        {
            Console.WriteLine("sua aliquota é de 22,5%");
            Console.WriteLine("poderá deduzir 636,00 R$");
        }
    }
}