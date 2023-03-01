using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_8.Parte_3
{
    internal class AsyncFiles
    {
        static void XMain(string[] args)
        {
            //TAREFA:   IMPLEMENTAR ACESSO ASSÍNCRONO A ARQUIVOS,
            //          TANTO NA LEITURA QUANTO NA GRAVAÇÃO


            // GRAVANDO UM ARQUIVO
            using (FileStream fluxoSaida
                   = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write))
            {
                string mensagemSaida = "Olá, Alura!";

                byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
                int posicao = 0;
                int tamanho = mensagemSaida.Length;
                fluxoSaida.Write(array, posicao, tamanho);
            }

            // LENDO UM ARQUIVO
            using (FileStream fluxoEntrada
                   = new FileStream("ArquivoSaida.txt",
                       FileMode.Open, FileAccess.Read))
            {
                byte[] bytesLidos = new byte[fluxoEntrada.Length];
                int posicao = 0;
                fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);
                string texto = Encoding.UTF8.GetString(bytesLidos);
                Console.WriteLine("Mensagem Lida: " + texto);
            }

            Console.ReadKey();
        }

        static async Task XMain2(string[] args)
        {
            //TAREFA: CAPTURAR A EXCEÇÃO 
            //GERADA POR UM MÉTODO ASSÍNCRONO

            byte[] dados = new byte[100];
            try
            {
                // nome do arquivo com caractere inválido ">"
                await GravarBytesAsync("destino>.dat", dados);
            }
            catch (Exception writeException)
            {
                Console.WriteLine(writeException.Message);
                Console.WriteLine("escrita falhou");
            }
            Console.Read();
        }

        static async Task GravarBytesAsync(string nomeArquivo, byte[] items)
        {
            using (FileStream fluxoSaida = new FileStream(nomeArquivo, FileMode.OpenOrCreate, FileAccess.Write))
            {
                await fluxoSaida.WriteAsync(items, 0, items.Length);
            }
        }
    }
}
