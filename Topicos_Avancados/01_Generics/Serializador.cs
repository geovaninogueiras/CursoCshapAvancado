using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serializador
    {
        private static string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        public static void Serializar(object obj)
        {
            StreamWriter writer = new StreamWriter(path + "03_" + obj.GetType().Name.Trim() + ".txt");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String Json = serializer.Serialize(obj);
            writer.WriteLine(Json);
            writer.Close();

        }

        public static T Deserializar <T>()
        {
            StreamReader reader = new StreamReader(path + "03_" + typeof(T).Name.Trim() + ".txt");
            String fileReader = reader.ReadToEnd();
            JavaScriptSerializer serializar = new JavaScriptSerializer();
            T obj = (T)serializar.Deserialize(fileReader, typeof(T));
            // object obj = serializar.Deserialize<T>(fileReader);
            return obj;
        }

    }
}
