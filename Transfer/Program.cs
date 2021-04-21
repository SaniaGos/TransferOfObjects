using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace Transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pc_s = new List<PC>()
            {
                new PC() { Brand = "Asus", SerialNUmber = "SN005", Type = "Game"},
                new PC() { Brand = "HP", SerialNUmber = "SN015", Type = "Home"},
                new PC() { Brand = "Dell", SerialNUmber = "SN105", Type = "Office"},
                new PC() { Brand = "Intel", SerialNUmber = "SN022", Type = "Office"}
            };
            DoSerialize.Write(pc_s, "PC*.txt");   // для кожного обєкту в ліст окремий тхт
            Serialize.SaveFile("Test.bin", pc_s); // сереаліазуєм масив
        }
    }
}
