﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_5.Parte_5
{
    internal class VerificarMaiuscula
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //======
            //Imprimir o documento no console, destacando
            //as letras maiúsculas no texto

            string documento = GetDocumento();
            Console.WriteLine(documento);

            //Char c = documento[0];
            //Console.WriteLine(c);

            foreach (char c in documento)
            {
                if (char.IsUpper(c))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(c);
            }

            Console.ReadKey();
        }

        private static string GetDocumento()
        {
            return "Uma cadeia de caracteres é uma coleção sequencial de caracteres que é usada para representar texto. Um objeto String é uma coleção sequencial de objetos System.Char que representam uma cadeia de caracteres; um System.Char objeto corresponde a uma unidade de código UTF-16. O valor de objeto String é o conteúdo da coleção sequencial de objetos System.Char cujo valor é imutável. Ou seja, ele é somente leitura.";
        }

    }
}
