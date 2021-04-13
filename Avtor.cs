using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Avtor
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }

        public Avtor(int id, string ime, string priimek)
        {
            this.id = id;
            this.ime = ime;
            this.priimek = priimek;
        }

        public Avtor()
        {
            
        }
    }
}
