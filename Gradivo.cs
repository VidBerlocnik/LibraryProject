using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Gradivo
    {
        //properties

        public int Id { get; set; }
        public string Naslov { get; set; }
        public string LetoIzdaje { get; set; }
        public string ImeAvtorja { get; set; }
        public string PriimekAvtorja { get; set; }
        public int ZalozbaId { get; set; }
        public bool Kupljeno { get; set; }
        public bool Izgubljena { get; set; }

        //Constructor
        public Gradivo(int id, string naslov, string letoIzdaje, string ime, string priimek, int zalozba)
        {
            Id = id;
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
            ImeAvtorja = ime;
            PriimekAvtorja = priimek;
            ZalozbaId = zalozba;
            Izgubljena = false;
        }
        public Gradivo(int id, string naslov, string letoIzdaje, string ime, string priimek)
        {
            Id = id;
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
            ImeAvtorja = ime;
            PriimekAvtorja = priimek;
            ZalozbaId = -1;
            Izgubljena = false;
        }
        public Gradivo(int id, string naslov, string letoIzdaje, string ime, string priimek, int zalozba, bool kupljeno)
        {
            Id = id;
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
            ImeAvtorja = ime;
            PriimekAvtorja = priimek;
            ZalozbaId = zalozba;
            Kupljeno = kupljeno;
            Izgubljena = false;
        }

        //functions
        public override string ToString()
        {
            return Id.ToString() + " " + Naslov + " " + ImeAvtorja + " " + PriimekAvtorja + " " + LetoIzdaje;
        }
    }
}
