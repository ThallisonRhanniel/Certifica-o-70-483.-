using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_2._6___Dynamic
{
    internal class Dinamicos
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto = objeto + 3;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            Console.WriteLine(dinamico);

            //vai dar erro, pois o método não existe, e não é verificado em tempo de execução
            dinamico.teste();

        }
    }
}
