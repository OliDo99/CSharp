using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1SerializaciaDesecializacia
{
    [Serializable]
    class Vozidlo
    {
        
        public int pocetKolies;
        public double najazdeneKM;
        [NonSerialized]
        public string tovarenskaZnacak;
        public double priemernaSpotreba;
        public Vozidlo(int pocetKolies,double najazdeneKM, string tovarenskaZnacak, double priemernaSpotreba)
        {
            this.pocetKolies = pocetKolies;
            this.najazdeneKM = najazdeneKM;
            this.tovarenskaZnacak = tovarenskaZnacak;
            this.priemernaSpotreba = priemernaSpotreba;
        }
    }
}
