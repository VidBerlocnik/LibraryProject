using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Izposoja
    {
        public int id { get; set; }
        public int stanje { get; set; }
        public DateTime datum { get; set; }
        public Knjiga knjiga { get; set; }
        public Uporabniki uporabnik { get; set; }

        public Izposoja(int id, int stanje, DateTime datum, Knjiga knjiga, Uporabniki uporabnik)
        {
            this.id = id;
            this.stanje = stanje;
            this.datum = datum;
            this.knjiga = knjiga;
            this.uporabnik = uporabnik;
        }

        public Izposoja()
        {

        }

        public override string ToString()
        {
            return stanje + " ; " + datum + " ; " + knjiga.ToString() + uporabnik.ToString();
        }
    }
}
