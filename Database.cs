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
        private static string conn = "data source=library.db";

        //Constructor

        public static List<string> izberiVseUporabnike()
        {
            List<string> seznam = new List<string>();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT ime, priimek FROM uporabniki", con);
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string priimek = reader.GetString(1);
                    seznam.Add(ime + ", " + priimek);
                    //listBoxOrdinacije.Items.Add(ime + " | " + naslov + ", " + kraj);
                    //comboBoxOrdinacija.Items.Add(ime + " | " + naslov + ", " + kraj);
                }
                con.Close();
            }
            return seznam;
        }

        //Izpis podatkov za izposojo in vračilo
        public static List<string> izposojaVracilo()
        {
            List<string> seznam = new List<string>();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT ime, priimek FROM uporabniki", con); //TODO: change SQL
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string priimek = reader.GetString(1);
                    seznam.Add(ime + ", " + priimek);
                    //listBoxOrdinacije.Items.Add(ime + " | " + naslov + ", " + kraj);
                    //comboBoxOrdinacija.Items.Add(ime + " | " + naslov + ", " + kraj);
                }
                con.Close();
            }
            return seznam;
        }
    }
}
