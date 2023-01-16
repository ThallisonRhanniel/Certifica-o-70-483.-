using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._6___Estruturas_Definidas_pelo_Usuário
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            

        }
    }

    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        //public PosicaoGps()
        //{

        //}

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string Tostring()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
}
