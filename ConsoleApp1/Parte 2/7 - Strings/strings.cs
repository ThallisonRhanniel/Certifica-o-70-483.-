using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_2._7___Strings
{
    internal class strings
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = "b";
            // Adiciona ao conteúdo de "b"
            b = b + "om dia";
            Console.WriteLine($"a == b: {a == b}");

            //trecho do código omitido

            string bomDia = "bom dia";
            Console.WriteLine($"bomDia[4]: {bomDia[4]}");
        }
    }
}
