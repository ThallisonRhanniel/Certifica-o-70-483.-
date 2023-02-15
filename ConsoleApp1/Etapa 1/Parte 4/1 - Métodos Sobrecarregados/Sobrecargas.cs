using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_4._1___Métodos_Sobrecarregados
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
        }

        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }


        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}
