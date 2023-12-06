using ByteBankIO;
using System.Diagnostics;
using System.Text;

partial class Program
{
    static void UsandoFile()
    {
        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui: {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendocomFIle.txt", "escrevendo qualquer coisaaaaaaaaaaaaaaaa");
        Console.WriteLine("Aplicação Finalizada !");
        Console.ReadLine();
    }
}