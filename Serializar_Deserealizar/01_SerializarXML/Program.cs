using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            Usuario usuario = new Usuario() {
                Nome = "Geovani",
                CPF = "402.944.178-50",
                Email = "geovaninogueira02@gmail.com",
            };

            XmlSerializer serializador = new XmlSerializer(  typeof( Usuario));
            StreamWriter stream = new StreamWriter(path + "01_SerializarXML.xml");
            serializador.Serialize(stream, usuario);

        }
    }
}
