using Match_EventApp.Classes;
using System;
using System.Windows.Forms;

namespace Match_EventApp
{
    public partial class InlogForm : Form
    {
        Database dbs = new Database("studmysql01.fhict.local", "dbi412769", "dbi412769", "EventMatchPT12");

        public InlogForm()
        {
            InitializeComponent();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != null && tbPassword.Text != null)
            {
                if (dbs.login(tbUsername.Text, tbPassword.Text))
                {
                    FestivalListForm fm = new FestivalListForm();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam en/of wachtwoord is onbekend.", "Waarschuwing");
                }
            }
            else
            {
                MessageBox.Show("Geen lege invoervelden toegestaan.", "Waarschuwing");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTregister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != null && tbPassword.Text != null)
            {
                if (dbs.register(tbUsername.Text, tbPassword.Text))
                {
                    Hide();
                    RegisterForm f1 = new RegisterForm();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam bestaat al.", "Waarschuwing");
                }
            }
            else
            {
                MessageBox.Show("Geen lege invoervelden toegestaan.", "Waarschuwing");
            }

        }
    }
}
