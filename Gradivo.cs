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
        public string ImeZalozba { get; set; }

        //Constructor
        public Gradivo(int id, string naslov, string letoIzdaje, string ime, string priimek, string zalozba)
        {
            Id = id;
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
            ImeAvtorja = ime;
            PriimekAvtorja = priimek;
            ImeZalozba = zalozba;
        }
        public Gradivo(int id, string naslov, string letoIzdaje, string ime, string priimek)
        {
            Id = id;
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
            ImeAvtorja = ime;
            PriimekAvtorja = priimek;
            ImeZalozba = null;
        }

        //functions
        public override string ToString()
        {
            return Id.ToString() + " " + Naslov + " " + ImeAvtorja + " " + PriimekAvtorja + " " + LetoIzdaje + " " + ImeZalozba;
        }
    }
}
