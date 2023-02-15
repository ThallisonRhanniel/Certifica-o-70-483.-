using ConsoleApp1.Parte_2._1___Tipos_de_Referência;
using ConsoleApp1.Parte_4._2___Métodos_Substituídos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_2.Parte_2._3___Operadores_IS_e_AS
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            if (obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }

            Console.WriteLine("obj não é um animal");
        }
    }
}
