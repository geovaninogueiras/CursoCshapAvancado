using _00_Biblioteca;
using System;
using System.IO;
using System.Xml.Serialization;
namespace _02_DeserealizarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            // Cria o arquivo ML
            Usuario usuario = new Usuario()
            {
                Nome = "Geovani",
                CPF = "000.000.000-00",
                Email = "geovaninogueira02@gmail.com",
            };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            StreamWriter stream = new StreamWriter(path + "02_DeserealizarXML.xml");
            serializador.Serialize(stream, usuario);
            stream.Close();
            
            // Fim da Crição dos arquivos

            StreamReader reader = new StreamReader(path + "02_DeserealizarXML.xml");

            // XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario2 = (Usuario)serializador.Deserialize(reader);
            Console.Write("Nome: {0}, CPF: {1}, Email: {2}", usuario2.Nome, usuario2.CPF, usuario2.Email);
            Console.ReadKey();

        }
    }
}
