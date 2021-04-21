using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class View
    {
        public static void Show(PC pc)
        {
            Console.CursorLeft = 5;
            Console.Write(pc.Brand);
            Console.CursorLeft = 20;
            Console.Write(pc.Type);
            Console.CursorLeft = 35;
            Console.WriteLine($"SN: {pc.SerialNUmber}");
        }
    }
}
