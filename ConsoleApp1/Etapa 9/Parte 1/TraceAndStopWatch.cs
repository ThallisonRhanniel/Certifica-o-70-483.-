using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_9.Parte_1
{
    internal class TraceAndStopWatch
    {
        public async Task CriarBancoDeDadosAsync()
        {
            Trace.WriteLine("Entrando no método CriarBancoDeDadosAsync", "MÉTODO");
            Trace.Indent();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //await CriarBancoAsync();
            //await CriarTabelasAsync();
            stopwatch.Stop();
            Console.WriteLine("Criação do banco e tabelas: {0} milissegundos", stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();
            //await InserirRegistrosAsync();
            stopwatch.Stop();
            Console.WriteLine("Inserção no banco de dados: {0} milissegundos", stopwatch.ElapsedMilliseconds);

            Trace.Unindent();
            Trace.WriteLine("Saindo do método CriarBancoDeDadosAsync", "MÉTODO");
        }
    }
}
