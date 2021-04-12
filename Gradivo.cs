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
        public string Avtor { get; set; }

        //Constructor
        public Gradivo(int id, string naslov, string letoIzdaje, string avtor)
        {
            Id = id;
            Naslov = naslov;
            LetoIzdaje = letoIzdaje;
            Avtor = avtor;
        }

        //functions
        public override string ToString()
        {
            return Id.ToString() + " " + Naslov + " " + Avtor + " " + LetoIzdaje;
        }
    }
}
