using Match_EventApp.Classes;
using Match_EventApp.CustomRenderer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_EventApp
{
    public partial class TinderForm : Form
    {
        private Random rnd = new Random();
        private Database dbs = new Database();
        private Account acc = new Account();
        public TinderForm()
        {
            InitializeComponent();
            Showprofile();
        }

        public void Like()
        {
            dbs.insertlike(acc._idAccount, Showprofile());
        }

        public void Dislike()
        {
            dbs.insertdislike(acc._idAccount, Showprofile());
        }

        public int Showprofile()
        {
            int rndint = rnd.Next(0, 6);
            Profiel profiel = new Profiel();
            profiel = dbs.getProfiel()[rndint];

            lbl_naam.Text = profiel._voornaam + profiel._achternaam;
            lbl_favofest.Text += profiel._favofestival;
            lbl_filmgenre.Text += profiel._favofilms;
            lbl_hobbys.Text += profiel._hobbys;

            return rndint;

        }

        private void pb_dislike_Click(object sender, EventArgs e)
        {
            Dislike();
        }

        private void pb_like_Click(object sender, EventArgs e)
        {
            Like();
        }

        private void BTclose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
