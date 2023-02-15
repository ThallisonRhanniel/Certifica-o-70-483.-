using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Etapa_2.Parte_3._1___string__var__object_e_dynamic
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            //tipo é definido na compilação
            string s = "Certificação C#";
            //tipo é definido na compilação (por inferência)
            var v = "Certificação C#";
            //tipo é definido na compilação
            object o = "Certificação C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //s = 123;
            //v = 123;
            o = 123;

            o = (int)o + 4;

            Console.WriteLine(o);

            //tipo é definido somente na execução
            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d = d + 4;
            Console.WriteLine(d);
        }
    }
}
