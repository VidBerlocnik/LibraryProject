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
            loadGradivoList();
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
                Uporabniki uporabnik = (Uporabniki)claniListBox.SelectedItem;
                imePriimekLabel.Text = uporabnik.ime + " " + uporabnik.priimek;
                uporabnik_id = uporabnik.id;
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

        private void loadGradivoList()
        {
            List<Gradivo> gradiva = Database.IzberiVsoGradivo();
            foreach (Gradivo gradivo in gradiva)
            {
                gradivoListBox.Items.Add(gradivo);
            }
        }

        private void isciButton_Click(object sender, EventArgs e)
        {
            if(naslovTextBox2.Text.Length > 0)
            {
                gradivoListBox.Items.Clear();
                List<Gradivo> seznam = Database.FilterNaslov;
                foreach (Gradivo gradivo in seznam)
                {
                    gradivoListBox.Items.Add(gradivo);
                }
            }
            else if(avtorTextBox.Text.Length > 0)
            {
                gradivoListBox.Items.Clear();
                List<Gradivo> seznam = Database.FilterAvtor;
                foreach (Gradivo gradivo in seznam)
                {
                    gradivoListBox.Items.Add(gradivo);
                }
            }
            else if(zalozbaTextBox.Text.Length > 0)
            {
                gradivoListBox.Items.Clear();
                List<Gradivo> seznam = Database.FilterZalozba;
                foreach (Gradivo gradivo in seznam)
                {
                    gradivoListBox.Items.Add(gradivo);
                }
            }
        }
    }
}
