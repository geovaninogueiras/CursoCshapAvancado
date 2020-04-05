using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            Usuario usuario = new Usuario()
            {
                Nome = "Geovani Nogueira Santos",
                CPF = "000.000.000 - 00",
                Email = "geovaninogueira02@gmail.com",
            };

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String Json = serializer.Serialize(usuario);

            StreamWriter sw = new StreamWriter(path + "03_SerializarJSON.json");
            sw.Write(Json);
            sw.Close();

            StreamReader reader = new StreamReader(path + "03_SerializarJSON.json");
            string JsonReader = reader.ReadToEnd();
            Console.WriteLine(JsonReader);
            JavaScriptSerializer deserializar = new JavaScriptSerializer();
            Usuario usuario2 = (Usuario)deserializar.Deserialize(JsonReader, typeof(Usuario));
            Console.Write("Nome: {0}, CPF: {1}, Email: {2}", usuario2.Nome, usuario2.CPF, usuario2.Email);
            Console.ReadKey();
        }
    }
}
