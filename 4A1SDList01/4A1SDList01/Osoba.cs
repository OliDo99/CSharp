using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1SDList01
{
    [Serializable]
    class Osoba
    {
        private int vek;
        private string meno;
        private string priezvisko;
        public Osoba(int vek, string meno, string priezvisko)
        {
            this.vek = vek;
            this.meno = meno;
            this.priezvisko = priezvisko;
        }
        public int GetVek() { return this.vek; }
        public string GetMeno() { return this.meno; }
        public string GetPriezvisko() { return this.priezvisko; }


    }
}
