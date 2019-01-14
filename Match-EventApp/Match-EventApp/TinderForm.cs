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
        List<Profiel> profielen = new List<Profiel>();
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
            lbl_favofest.Text = "Favoriete festival: ";
            lbl_filmgenre.Text = "Favoriete filmgenre: ";
            lbl_hobbys.Text = "Hobby's: ";
            profielen = dbs.getProfiel();

            int rndint = rnd.Next(0, profielen.Count - 1);
            Profiel profiel = new Profiel();
            profiel = profielen[rndint];

            lbl_naam.Text = profiel._voornaam + " " + profiel._achternaam;
            lbl_favofest.Text += profiel._favofestival;
            lbl_filmgenre.Text += profiel._favofilms;
            lbl_hobbys.Text += profiel._hobbys;

            pbFoto.Image = profiel._foto;

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

        private void BTmatches_Click(object sender, EventArgs e)
        {
            MessageForm messagefrom = new MessageForm();
            messagefrom.Show();
            Close();
        }

        private void BThome_Click(object sender, EventArgs e)
        {
            FestivalListForm festival = new FestivalListForm();
            festival.Show();
            this.Close();
        }
    }
}
