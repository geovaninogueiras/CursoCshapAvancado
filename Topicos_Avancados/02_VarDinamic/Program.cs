using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 1234567;

            var v1 = "";
            var v2 = 1234567;

            dynamic d1 = "";
            dynamic d2 = new Usuario() { Nome = "Geovani" };

            Console.WriteLine(d2.Nome);
            Console.WriteLine(d2.Senha);

        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
