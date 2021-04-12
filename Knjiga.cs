using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Knjiga
    {
        public int id { get; set; }
        public string naslov { get; set; }
        public string leto_izdaje { get; set; }
        public bool izgubljena { get; set; }
        public bool trgovina { get; set; }
        public string opombe { get; set; }
        public Avtor avtor { get; set; }

        public Knjiga()
        {
        }

        public Knjiga(int id, string naslov, string leto_izdaje, bool izgubljena, bool trgovina, Avtor avtor)
        {
            this.id = id;
            this.naslov = naslov;
            this.leto_izdaje = leto_izdaje;
            this.izgubljena = izgubljena;
            this.trgovina = trgovina;
            this.avtor = avtor;
        }

        public Knjiga(int id, string naslov, string leto_izdaje, Avtor avtor)
        {
            this.id = id;
            this.naslov = naslov;
            this.leto_izdaje = leto_izdaje;
            this.avtor = avtor;
        }

        public override string ToString()
        {
            return this.naslov + " ; " + leto_izdaje + " ; " + avtor.ime + " " + avtor.priimek;
        }
    }
}
