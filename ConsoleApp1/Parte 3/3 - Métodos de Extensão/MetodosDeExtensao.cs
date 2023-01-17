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
}
}
