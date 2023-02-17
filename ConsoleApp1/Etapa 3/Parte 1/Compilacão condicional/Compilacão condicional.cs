using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_3.Parte_1
{
    internal class Compilacão_condicional
    {
        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        private const decimal JUROS = 0.034m;
        private const string ARQUIVO_LOG_TESTE = @"monitoramento/logs.txt";
        private const string ARQUIVO_LOG_PRODUCAO = @"\\\\10.1.2.179\\monitoramento\\logs.txt";
        private string codigoContrato;
        public void GravarLog(string mensagem)
        {
            String arquivo = "";
#if (DEBUG)
            arquivo = ARQUIVO_LOG_TESTE;
#else
            arquivo = ARQUIVO_LOG_PRODUCAO;
#endif

            Directory.CreateDirectory(Path.GetDirectoryName(arquivo));
            using (var writer = new StreamWriter(arquivo, append: true))
            {
                writer.WriteLine(mensagem);
            }
        }
    }
}
