using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        public string Brand { get; set; }
        public string SerialNUmber { get; set; }
        public string Type { get; set; }
        public PC()
        {
            Brand = "none";
            SerialNUmber = "0";
            Type = "office";
        }
        public void OnPC()
        {
            Console.WriteLine("The computer turns on");
        }
        public void OffPC()
        {
            Console.WriteLine("The computer shuts down");
        }
        public void RebootPC()
        {
            Console.WriteLine("The computer restarts");
        }
    }
}
