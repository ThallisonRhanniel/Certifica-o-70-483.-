//#define RELATORIO_RESUMIDO
#define RELATORIO_DETALHADO


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1.Parte_10.Parte_1
{
    internal class DefineDiretivaDeCompilacao
    {

        [Conditional("RELATORIO_DETALHADO")]
        void ListagemDetalhada()
        {
            Console.WriteLine("Data          Produto         Preco       TipoPagamento Nome                  Cidade                Região                Pais");
            Console.WriteLine("==========================================================================================================================================");

            //foreach (var venda in vendas)
            //{
            //    Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}"
            //        , venda.Data, venda.Produto, venda.Preco, venda.TipoPagamento, venda.Nome, venda.Cidade, venda.Estado, venda.Pais);
            //}
            Console.WriteLine();
        }

        [Conditional("RELATORIO_RESUMIDO")]
        void ListagemResumida()
        {
            Console.WriteLine("Data          Produto         Preco       TipoPagamento   ");
            Console.WriteLine("==========================================================");


            //foreach (var venda in vendas)
            //{
            //    Console.WriteLine("{0}  {1}  {2}  {3}"
            //        , venda.Data, venda.Produto, venda.Preco, venda.TipoPagamento);
            //}
            Console.WriteLine();
        }
    }
}
