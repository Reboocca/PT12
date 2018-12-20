using Match_EventApp.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Match_EventApp
{
    public partial class RegisterForm : Form
    {
        Database db = new Database();
        bool setImage = false;
        OpenFileDialog foto = new OpenFileDialog();

        public RegisterForm()
        {
            InitializeComponent();

            cbGeslacht.SelectedIndex = 0;
        }

        private void BTclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BThome_Click(object sender, EventArgs e)
        {
            Close();
            InlogForm f2 = new InlogForm();
            f2.Show();
        }

        private void BTregister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbLeeftijd.Text) || string.IsNullOrEmpty(tbVoornaam.Text) || string.IsNullOrEmpty(tbAchternaam.Text) || cbGeslacht.SelectedIndex == -1)
            {
                MessageBox.Show("Zorg ervoor dat de velden met een '*' erachter niet leeg zijn.", "Waarschuwing");
            }
            else if (!Int32.TryParse(tbLeeftijd.Text, out int leeftijd))
            {
                MessageBox.Show("Alleen nummers zijn toegestaan in leeftijd.", "Waarschuwing");
            }
            else if (!setImage)
            {
                MessageBox.Show("Voeg eerst een foto toe, voordat je je profiel opslaat.", "Waarschuwing");
            }
            else
            {
                if (db.updateUserInfo(tbVoornaam.Text, tbAchternaam.Text, leeftijd, tbHobby.Text, tbFest.Text, tbGenre.Text, cbGeslacht.SelectedIndex, foto))
                {
                    MessageBox.Show("Saved");
                    BTregister.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan bij het updaten van het account", "Error");
                }
            }
        }

        private void BTfoto_toevoegen_Click(object sender, EventArgs e)
        {
            foto.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            foto.Title = "Selecteer een foto";

            if (foto.ShowDialog() == DialogResult.OK)
            {
                setImage = true;
                BTfoto_toevoegen.BackgroundImage = new Bitmap(foto.FileName);
                BTfoto_toevoegen.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}