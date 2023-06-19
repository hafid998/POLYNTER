using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Guntur Tri Atmaja

namespace Polinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Silahkan pilih jenis Printer berikut : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Pilih nomor 1..3 :   ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            printer.Merk = pilihan;

            IPrinters show;
            IPrinters print;

            if (printer.Merk == 1)
            {
                show = new Epson();
                print = new Epson();
            }
            else if (printer.Merk == 2)
            {
                show = new Canon();
                print = new Canon();
            }
            else
                show = new Laserjet();
            print = new Laserjet();

            show.Show(printer);
            print.Print(printer);
            Console.ReadLine();
        }
    }
}