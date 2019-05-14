using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPrinter
{
    class LaserJet : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
            Console.WriteLine("LaserJet printer printing ... ");

        }
        public override void Show()
        {
            
            base.Show();

        }
    }
}