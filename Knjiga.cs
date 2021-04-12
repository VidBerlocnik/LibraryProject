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
        //TODO: add author class proprety

        public Knjiga()
        {
        }

        public Knjiga(int id, string naslov, string leto_izdaje, bool izgubljena, bool trgovina)
        {
            this.id = id;
            this.naslov = naslov;
            this.leto_izdaje = leto_izdaje;
            this.izgubljena = izgubljena;
            this.trgovina = trgovina;
        }

        public Knjiga(int id, string naslov, string leto_izdaje)
        {
            this.id = id;
            this.naslov = naslov;
            this.leto_izdaje = leto_izdaje;
        }

        public override string ToString()
        {
            return this.naslov + " ; " + leto_izdaje; //TODO: update so it returns author as well
        }
    }
}
