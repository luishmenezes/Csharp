using ByteBankIO;
using System.Diagnostics;
using System.Text;

partial class Program
{

    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 78956, 4500.80, Luis Henrique";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoArquivo.Write(bytes, 0, bytes.Length);
        }
    }
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            escritor.Write("989, 246521, 22800.05, Luis Henrique Menezes");
        }

    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            for (int i = 0; i < 100000000; i++) {

                escritor.WriteLine($"linha {i}");
                escritor.Flush(); 
                Console.WriteLine($"linha {i} foi escrita no arquivo, tecle enter...");
                Console.ReadLine();


            }


        }
        

    }
}