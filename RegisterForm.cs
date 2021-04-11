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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string imePriimek = imePriimekTextBox.Text;
            string uporabniskoIme = uporabniskoImeTextBox.Text;
            string geslo = gesloTextBox.Text;

            Database.Registracija(imePriimek, uporabniskoIme, geslo);
        }
    }
}
