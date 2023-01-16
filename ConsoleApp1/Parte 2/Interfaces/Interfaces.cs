using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parte_2.Interfaces
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            Ieletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();

            eletro1 = new Abajur();

        }
    }
    interface Ieletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : Ieletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
    class Abajur : Ieletrodomestico, IIluminacao
    {

        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
    class Lanterna : Ieletrodomestico, IIluminacao
    {

        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
