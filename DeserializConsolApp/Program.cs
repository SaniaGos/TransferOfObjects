using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;


namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> list1 = Deserialize.ReadFile(@"..\..\..\Transfer\bin\Debug\Test.bin"); //ох і намучився з цим шляхом
            foreach (PC item in list1)
            {
                View.Show(item);
            }
           
            
            List<PC> list2 = DoSerialize.Read(@"..\..\..\Transfer\bin\Debug\PC*.txt"); // інший спосіб десереалізації
            Console.WriteLine();
            foreach (PC item in list2)
            {
                View.Show(item);
            }
            Console.ReadKey();
        }
    }
}
