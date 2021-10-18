using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjektiPonavljanjeZadatak2IvanMocilac
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();

            Console.WriteLine("Trokut");
            trokut.UcitajStranice();
            double opsegTrokuta = trokut.Opseg();
            Console.WriteLine();

            Console.WriteLine("Četverokut");
            cetverokut.UcitajStranice();
            double opsegCetverkuta = cetverokut.Opseg();
            Console.WriteLine();

            Console.WriteLine($"Opseg trokuta je: {opsegTrokuta}");
            Console.WriteLine($"Opseg četverokuta je: {opsegCetverkuta}");
            Console.ReadKey();
        }
    }
}
