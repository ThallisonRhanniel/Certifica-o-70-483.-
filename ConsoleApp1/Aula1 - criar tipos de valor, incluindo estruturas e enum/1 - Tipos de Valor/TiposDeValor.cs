using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aula1___criar_tipos_de_valor__incluindo_estruturas_e_enum._1___Tipos_de_Valor
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 30;

            System.Int32 copiaIdade = idade;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 23;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");
        }
    }
}
