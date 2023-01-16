using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_2._5___Objetos
{
    internal class Objetos
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto: {meuObjeto}");

            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto; //conversão explícita, ou "cast"

            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
        }
    }

    internal class Jogador
    {
        public string Pontuacao { get; set; }
    }
}
