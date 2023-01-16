using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._3___Tipos_de_Ponto_Flutuante
{
    internal class PontoFlutuante
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            //int massa = 6_000000_000000_000000;
            //long massa = 6e24;
            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            float massaDaTerra = 5.9736e24f; //System.Single
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            //float numeroPI = 3,14159f; // System.Single
            //Console.WriteLine($"numeroPI: {numeroPI}");

            //float numeroMuitoMaior = 6e100f
            // double numeroMuitoMaior = 6e100f;


            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            short y = 5;

            var resultado1 = x * y;
            Console.WriteLine("x * y= (0)", resultado1);
            Console.WriteLine($"O resultado é do tipo:  {resultado1.GetType()}");
        }
    }
}
