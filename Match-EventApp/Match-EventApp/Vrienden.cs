using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Match_EventApp.Classes;

namespace Match_EventApp
{
    public partial class Vrienden : Form
    {
        Account acc = new Account();
        Database db = new Database();

        int idAcc1;

        public Vrienden()
        {
            InitializeComponent();

            //id ophalen van de huidige gebruiker
            idAcc1 = acc._idAccount;
        }

        private void BTvrienden_toevoegen_Click_1(object sender, EventArgs e)
        {
            bool result = db.addFriend(idAcc1.ToString());
            switch (result)
            {
                case true:
                    MessageBox.Show("Vriend is toegevoegd!", "Succes");
                    break;
                case false:
                    MessageBox.Show("Er is iets mis gegaan bij het toevoegen.", "Error");
                    break;
            }
        }

        private void BTclose_Click(object sender, EventArgs e)
        {
            Close();
            InlogForm f2 = new InlogForm();
            f2.Show();
        }

        private void BThome_Click(object sender, EventArgs e)
        {
            FestivalListForm festival = new FestivalListForm();
            festival.Show();
            this.Close();
        }

        private void BTclose_Click_1(object sender, EventArgs e)
        {
            Close();
            InlogForm inlog = new InlogForm();
            inlog.Show();
        }

        private void BThome_Click_1(object sender, EventArgs e)
        {
            FestivalListForm festivalListForm = new FestivalListForm();
            festivalListForm.Show();
            this.Close();
        }
    }
}
