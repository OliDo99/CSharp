using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1SerializaciaDesecializacia2
{
    [Serializable]
    class Vozidlo
    {
        private int pocetKolies;
        private double najazdeneKM;
        private string tovarenskaZnacak;
        private double priemernaSpotreba;
        public Vozidlo(int pocetKolies, double najazdeneKM, string tovarenskaZnacak, double priemernaSpotreba)
        {
            this.pocetKolies = pocetKolies;
            this.najazdeneKM = najazdeneKM;
            this.tovarenskaZnacak = tovarenskaZnacak;
            this.priemernaSpotreba = priemernaSpotreba;
        }
        public int GetPocetKolies() { return this.pocetKolies; }
        public double GetNajazdeneKM() { return this.najazdeneKM; }
        public string GetToverenskaZnacka() { return this.tovarenskaZnacak; }
        public double GetPriemernaSpotreba() { return this.priemernaSpotreba; }
    }
}
