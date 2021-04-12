using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        int uporabnik_id = -1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void loadUserList()
        {
            List<Uporabniki> uporabniki = Database.izberiVseUporabnike();
            foreach (Uporabniki uporabnik in uporabniki)
            {
                claniListBox.Items.Add(uporabnik);
            }
        }

        private void claniListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (claniListBox.SelectedIndex != -1)
            {
                //Dobi in shrani izbranega uporabnika
                Uporabniki uporabnik = (Uporabniki)claniListBox.SelectedItem;
                imePriimekLabel.Text = uporabnik.ime + " " + uporabnik.priimek;
                uporabnik_id = uporabnik.id;

                //Izpiše izposojeno gradivo izbranega uporabnika
                izposojenoGradivoListBox.Items.Clear();
                List<Knjiga> izposojenoGradivo = Database.izpisIzposojenegaGradiva(uporabnik_id);
                foreach (Knjiga knjiga in izposojenoGradivo)
                {
                    izposojenoGradivoListBox.Items.Add(knjiga);
                }

                //Izpiše vso gradivo
                vsoGradivoListBox.Items.Clear();
                List<Knjiga> vseKnjige = Database.izpisVsegaGradiva();
                foreach (Knjiga knjiga1 in vseKnjige)
                {
                    vsoGradivoListBox.Items.Add(knjiga1);
                }

                //Prikaže vracilo/izposoja tab
                tabControl1.SelectedTab = tabControl1.TabPages["vraciloIzposojaTabPage"];
            }
        }

        private void izposojenoListBoxUpdate()
        {
            List<Knjiga> knjige = Database.izpisIzposojenegaGradiva(uporabnik_id);
            foreach (Knjiga knjiga in knjige)
            {
                izposojenoGradivoListBox.Items.Add(knjiga);
            }
        }

        private void imePriimekTextBox_TextChanged(object sender, EventArgs e)
        {
            if (imePriimekTextBox.Text != "")
            {
                List<Uporabniki> uporabniki = Database.IsciVseUporabnike(imePriimekTextBox.Text);
                claniListBox.Items.Clear();
                foreach (Uporabniki uporabnik in uporabniki)
                {
                    claniListBox.Items.Add(uporabnik);
                }
            }
            else
            {
                List<Uporabniki> uporabniki = Database.izberiVseUporabnike();
                claniListBox.Items.Clear();
                foreach (Uporabniki uporabnik in uporabniki)
                {
                    claniListBox.Items.Add(uporabnik);
                }
            }
        }

        private void dodajClanaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database.dodajClana(imeTextBox2.Text, priimekTextBox.Text, telefonTextBox.Text, naslovTextBox.Text, emailTextBox.Text, opombeRichTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka pri dodajanju člana!");
            }
        }

        private void izposodiGradivoButton_Click(object sender, EventArgs e)
        {
            if (vsoGradivoListBox.SelectedIndex != -1)
            {
                Knjiga knjiga = (Knjiga)vsoGradivoListBox.SelectedItem;
                Database.izposojaGradiva(knjiga, uporabnik_id);
            }
        }
    }
}
