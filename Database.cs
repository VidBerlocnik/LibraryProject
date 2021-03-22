using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LibraryProject
{
    class Database
    {
        private SQLiteConnection conn;

        //Constructor
        public Database()
        {
            conn = new SQLiteConnection("data source=items.db");
        }
    }
}
