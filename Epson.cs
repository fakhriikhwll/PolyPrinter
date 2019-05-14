using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPrinter
{
    class Epson : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Epson display dimension : 10*11");
            Console.WriteLine("Epson printer printing ... ");
        }
        public override void Show()
        {
            base.Show();
        }
    }
}