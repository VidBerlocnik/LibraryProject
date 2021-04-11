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
    }
}
