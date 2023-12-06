using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoArquivo = "contas.txt";

        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;



            var Buffer = new byte[1024];

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoArquivo.Read(Buffer, 0, 1024);

                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(Buffer, numeroDeBytesLidos);
            }




            fluxoArquivo.Close();
            Console.ReadLine();
        }
    }


    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);

        /*
        foreach(var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }*/
    }

}