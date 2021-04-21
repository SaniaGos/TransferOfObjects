using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ClassLib
{
    public static class DoSerialize
    {
        public static void Write(List<PC> l_pc, string path)
        {
            for (int i = 0; i < l_pc.Count; i++)
            {
                string newPath = path.Replace("*", Convert.ToString(i + 1));
                using (StreamWriter writer = new StreamWriter(newPath, false, Encoding.UTF8))
                {
                    writer.WriteLine("Brand:" + l_pc[i].Brand);
                    writer.WriteLine("Type:" + l_pc[i].Type);
                    writer.WriteLine("SN:" + l_pc[i].SerialNUmber);
                }
            }
        }
        public static List<PC> Read(string path)
        {
            List<PC> list = new List<PC>();
            int i = 0;
            try
            {
                while (true)
                {
                    PC pc = new PC();
                    string newPath = path.Replace("*", Convert.ToString(1 + i));
                    using (StreamReader writer = new StreamReader(newPath, Encoding.UTF8))
                    {
                        pc.Brand = writer.ReadLine().Split(':')[1];
                        pc.Type = writer.ReadLine().Split(':')[1];
                        pc.SerialNUmber = writer.ReadLine().Split(':')[1];
                    }
                    list.Add(pc);
                    i++;
                }
            }
            catch (Exception)
            {
                return list;
            }
        }
    }
}
