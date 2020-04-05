using System;
using System.IO;
using System.Web.Script.Serialization;
using _00_Biblioteca;

namespace _03_SerializarJSON
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
        }
    }
}
