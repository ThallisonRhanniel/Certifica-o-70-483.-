using ConsoleApp1.Parte_4._2___Métodos_Substituídos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_2.Parte_2._1___Conversões_implícitas
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            Console.WriteLine(inteiroLongo);

            //inteiro = inteiroLongo;

            ///<image url="$(ProjectDir)img12.png" />

            Gato gato = new Gato();
            Animal animal = gato;
            Console.WriteLine(animal.GetType());
            //IAnimal ianimal = gato;
            //Console.WriteLine(ianimal.GetType());
            //gato = ianimal;

        }
    }
}
