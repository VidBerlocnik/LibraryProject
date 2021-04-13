using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    class Zalozba
    {
        //properties
        public int Id { get; set; }
        public string Ime { get; set; }

        public Zalozba(int id, string ime)
        {
            Id = id;
            Ime = ime;
        }

        public override string ToString()
        {
            return Ime;
        }
    }
}
