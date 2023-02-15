using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_3._3___Métodos_de_Extensão
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();
        }
    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
    }

    static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }

        public static void ImprimirDocumentoComResumo(this Impressora impressora)
        {
            Console.WriteLine();
            Console.WriteLine($"{impressora.Documento}\r\nRESUMO\r\n======\r\nO documento tem: {impressora.Documento.Length} caracteres.");
        }
    }
}

