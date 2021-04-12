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

        //functions
        public override string ToString()
        {
            return Id.ToString() + " " + Naslov + " " + Avtor + " " + LetoIzdaje;
        }
    }
}
