using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ClassLib;

namespace DeserializConsolApp
{
    static class Deserialize
    {
        public static List<PC> ReadFile(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<PC> list = new List<PC>();
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                list = (List<PC>)formatter.Deserialize(stream);
            }
            return list;
        }
    }
}
