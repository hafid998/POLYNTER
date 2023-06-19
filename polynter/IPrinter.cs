using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polinter
{
    interface IPrinters
    {
        void Print(Printer printer);
        void Show(Printer printer);
    }
}