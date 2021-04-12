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

        //Vrne seznam vseh uporabnikov v bazi
        public static List<Uporabniki> izberiVseUporabnike()
        {
            List<Uporabniki> seznam = new List<Uporabniki>();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT id, ime, priimek FROM uporabniki", con);
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string ime = reader.GetString(1);
                    string priimek = reader.GetString(2);
                    seznam.Add(new Uporabniki(id, ime, priimek));
                }
                con.Close();
            }
            return seznam;
        }

        //Vrne seznam vseh uporabnikov, ki v imenu ali priimku vsebujejo vnešene znake
        public static List<Uporabniki> IsciVseUporabnike(string filter)
        {
            List<Uporabniki> seznam = new List<Uporabniki>();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT id, ime, priimek FROM uporabniki WHERE ime LIKE '%" + filter + "%' OR priimek LIKE '%" + filter + "%';", con);
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string ime = reader.GetString(1);
                    string priimek = reader.GetString(2);
                    seznam.Add(new Uporabniki(id, ime, priimek));
                }
                con.Close();
            }
            return seznam;
        }

        //Vrne seznam izposojenega gradiva od uporabnika
        public static List<Knjiga> izpisIzposojenegaGradiva(int uporabnik_id)
        {
            List<Knjiga> seznam = new List<Knjiga>();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT id, naslov, leto_izdaje FROM knjige k INNER JOIN izposoje i ON k.id = i.knjiga_id INNER JOIN uporabniki u ON i.uporabnik_id = u.id WHERE u.id = '" + uporabnik_id + "';", con);
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string priimek = reader.GetString(1);
                    seznam.Add(ime + ", " + priimek);
                    int id = reader.GetInt32(0);
                    string naslov = reader.GetString(1);
                    string leto_izdaje = reader.GetString(2);
                    seznam.Add(new Knjiga(id, naslov, leto_izdaje));
                }
                con.Close();
            }
            return seznam;
        }

        //Doda novega člana
        public static void dodajClana(string ime, string priimek, string telefon, string naslov, string email, string opombe)
        {
            try
            {
                //Spremeni vse empty strings v null
                if (telefon.Trim() == "")
                {
                    telefon = null;
                }
                if (naslov.Trim() == "")
                {
                    naslov = null;
                }
                if (email.Trim() == "")
                {
                    email = null;
                }
                if (opombe.Trim() == "")
                {
                    opombe = null;
                }

                using (SQLiteConnection con = new SQLiteConnection(conn))
                {
                    con.Open();
                    SQLiteCommand com = new SQLiteCommand("INSERT INTO uporabniki (ime, priimek, telefon, naslov, email, opombe) VALUES ('" + ime + "', '" + priimek + "', '" + telefon + "', '" + naslov + "', '" + email + "', '" + opombe + "');", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }

                System.Windows.Forms.MessageBox.Show("Uporabnik uspešno dodan!");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Napaka pri dodajanju novega člana");
            }
            
        //Avtentikacija podatkov za prijavo uporabnika
        public static bool Prijava(string uporabniskoIme, string geslo)
        {

            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM admin WHERE(uporabniskoIme = '" + uporabniskoIme + "') AND (geslo = '" + geslo + "');", con);
                SQLiteDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
        }
    }
}
