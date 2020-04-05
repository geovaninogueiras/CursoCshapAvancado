using _00_Biblioteca;
using System;
using System.IO;
using System.Xml.Serialization;
namespace _02_SerealizarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            StreamReader reader = new StreamReader(path + "01_SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario)serializador.Deserialize(reader);
            Console.Write("Nome: {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();

        }
    }
}
