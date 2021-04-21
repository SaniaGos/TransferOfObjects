using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ClassLib;


namespace Transfer
{
    static class Serialize
    {
        public static void SaveFile(string path, List<PC> list)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream stream = File.Create(path))
            {
                formatter.Serialize(stream, list);
            }
        }
    }
}
