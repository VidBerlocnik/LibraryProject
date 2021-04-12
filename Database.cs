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

        public static void Registracija(string ime, string priimek, string uporabniskoIme, string geslo)
        {
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("INSERT INTO admin(ime, priimek, uporabniskoIme, geslo) " +
                    "VALUES('" + ime + "', '" + priimek + "', '" + uporabniskoIme + "', '" + geslo + "'); ", con);
                //SQLiteDataReader reader = com.ExecuteReader();
                com.ExecuteNonQuery();
            }
        }

        //Vrne seznam izposojenega gradiva od uporabnika
        public static List<Knjiga> izpisIzposojenegaGradiva(int uporabnik_id)
        {
            List<Knjiga> seznam = new List<Knjiga>();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT k.id, k.naslov, k.leto_izdaje, k.avtor_id FROM knjige k INNER JOIN izposoje i ON k.id = i.knjiga_id INNER JOIN uporabniki u ON i.uporabnik_id = u.id WHERE u.id = '" + uporabnik_id + "';", con);
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string naslov = reader.GetString(1);
                    string leto_izdaje = reader.GetString(2);
                    int avtor_id = reader.GetInt32(3);
                    seznam.Add(new Knjiga(id, naslov, leto_izdaje, isciAvtorja(avtor_id)));
                }
                con.Close();
            }
            return seznam;
        }

        //Vrne avtorja z id avtor_id
        public static Avtor isciAvtorja(int avtor_id)
        {
            Avtor avtor = new Avtor();
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT id, ime, priimek FROM avtorji WHERE id = '" + avtor_id + "';", con);
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    avtor.id = reader.GetInt32(0);
                    avtor.ime = reader.GetString(1);
                    avtor.priimek = reader.GetString(2);
                }
                con.Close();
            }
            return avtor;
        }
    }
}
