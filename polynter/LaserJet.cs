using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polinter
{
    public class Laserjet : IPrinters
    {
        void IPrinters.Print(Printer printer)
        {
            Console.WriteLine("LasetJet printer printing....");
        }

        void IPrinters.Show(Printer printer)
        {
            Console.WriteLine("LasetJet display dimension : 11*14");
        }
    }
}