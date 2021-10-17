using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjektiPonavljanjeZadatak2IvanMocilac
{
    class GeometrijskiLik
    {
        public int BrojStranica
        {
            get;
            set;
        }
        
        public double[] Stranice
        {
            get;
            set;
        }

        public GeometrijskiLik(int brojStranica)
        {
            BrojStranica = brojStranica;
        }

        public void UcitajStranice()
        {
            Stranice = new double[BrojStranica];
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.Write($"Unesite {i + 1}. stranicu: ");
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double Opseg()
        {
            double vrati = 0;
            foreach(var broj in Stranice)
            {
                vrati += broj;
            }
            return vrati;
        }
    }
}
