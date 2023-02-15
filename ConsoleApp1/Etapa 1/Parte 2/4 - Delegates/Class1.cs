using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_2._4___Delegates
{
    internal class Class1
    {
        // Declaração
        public delegate void SimplesDelegate();

        class ExemploDeDelegate
        {
            public static void minhaFuncao()
            {
                Console.WriteLine("Eu fui chamada por um delegate ...");
            }

            public static void Main()
            {
                // Instanciação
                SimplesDelegate simplesDelegate = new SimplesDelegate(minhaFuncao);

                // Invocação
                simplesDelegate();
                Console.ReadKey();
            }
        }

    }
}
