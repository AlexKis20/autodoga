using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodoga
{
    internal class Auto
    {
        

        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int GyartasiEv { get; set; }
        public int UzemanyagFogyasztas { get; set; }
        public int MegtettKilometerekSzama { get; set; }

        public Auto(string marka, string tipus, int gyartasiEv, int uzemanyagFogyasztas, int megtettKilometerekSzama)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
            UzemanyagFogyasztas = uzemanyagFogyasztas;
            MegtettKilometerekSzama = megtettKilometerekSzama;
        }

        private int Eletkor()
        {
            return 2025 - GyartasiEv;
        }
        private int Uzemanyag_felhasznalas()
        {
            return MegtettKilometerekSzama / 100;
        }
        private int Atlagfogyasztas_kmre()
        {
            return Uzemanyag_felhasznalas()/MegtettKilometerekSzama;
        }


        public void AdatKiir()
        {
            Console.WriteLine("Autók adatai");
            Console.WriteLine($"Márka: {Marka}");
            Console.WriteLine($"Tipus: {Tipus}");
            Console.WriteLine($"Gyártási év: {GyartasiEv}");
            Console.WriteLine($"Életkor: {Eletkor()} év");
            Console.WriteLine($"Fogyasztás: {UzemanyagFogyasztas}l/100km");
            Console.WriteLine($"Megtett kilométer {MegtettKilometerekSzama}km");
            Console.WriteLine($"Összes felhasznált üzemanyag: {Uzemanyag_felhasznalas()}l");
            Console.WriteLine($"Átlagos fogyasztás 1km-re: {Atlagfogyasztas_kmre()}liter/km");
        }




    }
}
