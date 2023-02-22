using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_4.Parte_3
{
    internal class Finalizador
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Livro livro = new Livro();
            }

            GC.Collect();

            Console.ReadKey();
        }
    }

    class Livro
    {
        static int UltimoId = 0;
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        public int Id { get; }

        public Livro()
        {
            UltimoId++;
            Id = UltimoId;
            //Trace.WriteLine("Livro " + Id + " está sendo criado");
        }

        //~Livro()
        //{
        //    //LIBERAR SOMENTE OS RECURSOS NÃO-GERENCIADOS


        //    Trace.WriteLine("Livro " + Id + " está sendo finalizado");
        //}
    }
}
