using ConsoleApp1.Parte_4._2___Métodos_Substituídos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_2.Parte_2._2___Conversões_explícitas
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 1_234_567_890.123;
            //long copia = divida;

            double salario = 1_237.89;
            long copiaSalario = (long)salario;
            Console.WriteLine(copiaSalario);

            ///<image url="$(ProjectDir)img13.png" />
            ///

            Animal animal = new Gato();
            Gato gato = (Gato)animal; //cast = conversão explícita
            Console.WriteLine(gato.GetType());
        }
    }
}
