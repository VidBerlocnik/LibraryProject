using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Uporabniki
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }
        public string telefon { get; set; }
        public string naslov { get; set; }
        public string email { get; set; }
        public string opombe { get; set; }
        public Uporabniki()
        {
        }

        public Uporabniki(int id, string ime, string priimek)
        {
            this.id = id;
            this.ime = ime;
            this.priimek = priimek;
        }

        public override string ToString()
        {
            return this.ime + " " + this.priimek;
        }

        public Uporabniki(int id, string ime, string priimek, string telefon, string naslov, string email, string opombe)
        {
            this.id = id;
            this.ime = ime;
            this.priimek = priimek;
            this.telefon = telefon;
            this.naslov = naslov;
            this.email = email;
            this.opombe = opombe;
        }
    }
}
