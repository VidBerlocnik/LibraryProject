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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Close();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            string uporabniskoIme = uporabniskoImeTextBox.Text;
            string geslo = gesloTextBox.Text;
            if(Database.Prijava(uporabniskoIme, geslo))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Uporabniško ime in geslo se ne ujemata.");
            }
            
        }
    }
}
