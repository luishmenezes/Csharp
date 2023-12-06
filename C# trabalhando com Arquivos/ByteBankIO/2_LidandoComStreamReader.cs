﻿using ByteBankIO;


partial class Program 
{ 
    static void LidandoComStreamReader()
    {

    
    var enderecoArquivo = "contas.txt";

    using (var fluxoDeArquivo = new FileStream(enderecoArquivo, FileMode.Open))
{
    var leitor = new StreamReader(fluxoDeArquivo);


    while (!leitor.EndOfStream)
    {
        var linha = leitor.ReadLine();
        var contaCorrente = ConverterStringParaContaCorrente(linha);

        var msg = $"{contaCorrente.Titular.Nome} : Conta número: {contaCorrente.Numero}, agencia: {contaCorrente.Agencia}, saldo: {contaCorrente.Saldo}";
        Console.WriteLine(msg);
    }
}
Console.ReadLine();
        
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    var campos = linha.Split(',');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2].Replace('.', ',');
    var nomeTitular = campos[3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComoDouble = double.Parse(saldo);

    var titular = new Cliente();
    titular.Nome = nomeTitular;


    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    resultado.Depositar(saldoComoDouble);
    resultado.Titular = titular;

    return resultado;
}
}
}