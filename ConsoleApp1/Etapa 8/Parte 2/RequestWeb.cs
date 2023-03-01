using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_8.Parte_2
{
    internal class RequestWeb
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //1) conectar-se site da caelum (http://www.caelum.com.br)
            //2) obter o conteúdo da página do site
            //3) exibir o conteúdo da página

            WebRequest requisicao = WebRequest.Create("http://www.caelum.com.br");
            WebResponse resposta = requisicao.GetResponse();

            using (var leitorResposta =
                   new StreamReader(resposta.GetResponseStream()))
            {
                var textoDoSite = leitorResposta.ReadToEnd();
                Console.WriteLine(textoDoSite);
                Console.ReadKey();
            }
        }

        static void XMain2(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //mas de forma mais simples e rápida

            WebClient webClient = new WebClient();
            string textoDoSite = webClient.DownloadString("http://www.caelum.com.br");
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }

        static async Task XMai3(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //de forma ASSÍNCRONA

            string textoDoSite = await LerTextoDoSite();
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }

        private static async Task<string> LerTextoDoSite()
        {
            WebClient webClient = new WebClient();
            var textoDoSite = await webClient.DownloadStringTaskAsync("http://www.caelum.com.br");
            return textoDoSite;
        }

        static async Task XMain4(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //de forma ASSÍNCRONA, porém o código precisa rodar em 
            // 
            // - Aplicações Windows (Windows Forms, WPF)
            // - Aplicações Web (ASP.NET e ASP.NET Core)
            // - Xamarin (aplicativos de celular / tablet)
            // - Windows Universal Application Platform

            HttpClient cliente = new HttpClient();
            var textoDoSite = await cliente.GetStringAsync("http://www.caelum.com.br");
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }
    }
}
