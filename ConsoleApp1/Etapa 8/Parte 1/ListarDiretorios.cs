using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_8.Parte_1
{
    internal static class ListarDiretorios
    {

        
        private static void ListarDiretorioss(DirectoryInfo diretorioInicial)
        {
            foreach (var diretorio in diretorioInicial.GetDirectories())
            {
                Console.WriteLine(diretorio.FullName);

                foreach (var arquivo in diretorio.GetFiles("*.cs"))
                {
                    Console.WriteLine(arquivo.FullName);
                }

                ListarDiretorioss(diretorio);
            }
        }
    }
}
