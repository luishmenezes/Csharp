using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.Bytebank.Atendimento
{
    internal class Exemplos_arrays
    {
        //#region Exemplos de Arrays
        ////TestaArrayInt();
        ////BuscarPalavra();

        //void TestaArrayInt()
        //{
        //    int[] idades = new int[5];
        //    idades[0] = 30;
        //    idades[1] = 40;
        //    idades[2] = 17;
        //    idades[3] = 21;
        //    idades[4] = 18;

        //    Console.WriteLine($"Tamanho do Array: {idades.Length} ");

        //    int acumulador = 0;

        //    for( int i = 0; i < idades.Length; i++)
        //    {
        //        int idade = idades[i];
        //        Console.WriteLine($"Índice [{i}] = {idade}");
        //        acumulador += idade;
        //    }
        //    int media = acumulador / idades.Length;

        //    Console.WriteLine($"A média das idades é de: {media}");
        //}

        //void BuscarPalavra()
        //{
        //    string[] arrayDePalavras = new string[5];

        //    for (int i = 0; i < arrayDePalavras.Length; i++)
        //    {
        //        Console.Write($"Digite {i+1}ª palavra: ");
        //        arrayDePalavras[i] = Console.ReadLine();
        //    }

        //    Console.Write("Digite a palavra a ser procurada: ");
        //    var busca = Console.ReadLine();

        //    foreach (string palavra in arrayDePalavras)
        //    {
        //        if (palavra.Equals(busca))
        //        {
        //            Console.WriteLine($"Palavra encontrada = {busca}");
        //            return;
        //        }

        //    }
        //}

        //Array amostra = new double[5];
        //amostra.SetValue(5.9, 0);
        //amostra.SetValue(1.8, 1);
        //amostra.SetValue(7.1, 2);
        //amostra.SetValue(10, 3);
        //amostra.SetValue(6.9, 4);

        ////TestaMediana(amostra);
        //void TestaMediana(Array array)
        //{
        //    if ((array == null) || (array.Length == 0))
        //    {
        //        Console.WriteLine("Array está vazio ou nulo para calculo de mediana");
        //    }

        //    double[] numerosOrdenados = (double [])array.Clone();
        //    Array.Sort(numerosOrdenados);

        //    int tamanho = numerosOrdenados.Length;
        //    int meio = tamanho / 2;
        //    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
        //    // na linha de cima a "?" seria uma especie de if / else onde se um for verdade ou o outro.

        //    Console.WriteLine($"Com base na amostra a mediana é igual a : {mediana}");
        //}

        ////TestaArrayDeContasCorrentes();
        //void TestaArrayDeContasCorrentes()
        //{
        //    ListaContasCorrentes listaContas = new ListaContasCorrentes ();
        //    listaContas.Adicionar(new ContaCorrente(874, "621651-A"));
        //    listaContas.Adicionar(new ContaCorrente(874, "651251-B"));
        //    listaContas.Adicionar(new ContaCorrente(874, "6251654-C"));
        //    listaContas.Adicionar(new ContaCorrente(874, "6251654-C"));
        //    listaContas.Adicionar(new ContaCorrente(874, "6251654-C"));
        //    listaContas.Adicionar(new ContaCorrente(874, "6251654-C"));
        //    listaContas.Adicionar(new ContaCorrente(874, "6251654-C"));
        //    listaContas.Adicionar(new ContaCorrente(874, "6251654-C"));
        //    var contaDoluis = new ContaCorrente(984, "9494489-A");
        //    listaContas.Adicionar(contaDoluis);
        //    listaContas.ExibeLista();
        //    Console.WriteLine("==================");
        //    listaContas.Remover(contaDoluis);
        //    listaContas.ExibeLista();







        //    /*ContaCorrente[] listaDeContas = new ContaCorrente[]
        //    {
        //        new ContaCorrente(874, "621651-A"),
        //        new ContaCorrente(874, "651251-B"),
        //        new ContaCorrente(874, "6251654-C")

        //    }; 
        //    /for (int i = 0; i < listaDeContas.Length; i++)
        //    {
        //        ContaCorrente contaAtual = listaDeContas[i];
        //        Console.WriteLine($"Índice{i} - Conta: {contaAtual.Conta}");
        //    }
        //    */
        //}
        //#endregion  Exemplos de Arrays

    }
}
