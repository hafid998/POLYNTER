using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polinter
{
    public class Epson : IPrinters
    {
        void IPrinters.Print(Printer printer)
        {
            Console.WriteLine("Epson printer printing....");
        }

        void IPrinters.Show(Printer printer)
        {
            Console.WriteLine("Epson display dimension : 11*11");
        }
    }
}