using System;

namespace _03_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "geovani";
            valor = valor.FirsToUpper();
            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
