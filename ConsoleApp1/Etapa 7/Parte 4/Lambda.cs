using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_7.Parte_4
{
    class Program
    {
        delegate int Operacao(int a, int b);

        static void Main(string[] args)
        {
            Operacao operacao = (x, y) => x + y; //expressão lambda
            Console.WriteLine(operacao(3, 2));

            Func<int, int, int> somar = (x, y) => x + y;
            Console.WriteLine(somar(3, 2));

            Action<string> imprimirMensagem
                = (mensagem) =>
                {
                    Console.WriteLine(mensagem);
                };

            imprimirMensagem("Olá, Alura!");

            var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Números divisíveis por 3:");
            Predicate<int> divisivelPor3 = (numero) => numero % 3 == 0;
            var divisiveis = Array.FindAll(numeros, divisivelPor3);

            foreach (var numero in divisiveis)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
