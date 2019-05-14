using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPrinter
{
    class Cannon : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Cannon display dimension : 10*11");
            Console.WriteLine("Cannon printer printing ... ");
        }
    }
}
