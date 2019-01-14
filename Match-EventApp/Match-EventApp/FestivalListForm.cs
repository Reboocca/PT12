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
    public partial class FestivalListForm : Form
    {
        Database dbs = new Database();
        public FestivalListForm()
        {
            InitializeComponent();
            propObjListView();
            fillObjListView();
        }

        //Set the properties of the items in the object list box
        private void propObjListView()
        {
            lbFestivals.Font            = new Font("Microsoft Sans Serif", 8);
            DescribedTaskRenderer task  = new DescribedTaskRenderer();
            Naam.Renderer               = task.CreateDescribedTaskRenderer();
            lbFestivals.RowHeight       = 100;
            lbFestivals.HeaderStyle     = ColumnHeaderStyle.None;
            Foto.CellVerticalAlignment  = StringAlignment.Near;
            
            btnJoin.IsButton    = true;
            btnMatch.IsButton   = true;
            
            btnJoin.CellVerticalAlignment   = StringAlignment.Near;
            btnMatch.CellVerticalAlignment  = StringAlignment.Near;

            lbFestivals.ButtonClick += LbFestivals_ButtonClick;
        }

        private void LbFestivals_ButtonClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            Account a = new Account();
            switch (e.SubItem.ToString())
            {
                case "ListViewSubItem: {J}":
                    bool result = a.joinFestival((Festival)e.Model);
                    if (result)
                    {
                        MessageBox.Show("Je status is gewijzigd", "Succes");
                        MessageScreenForm g = new MessageScreenForm();
                        g.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan bij het opslaan van je status, probeer het nog eens", "Error");
                    }
                    break;
                case "ListViewSubItem: {M}":
                    TinderForm t = new TinderForm();
                    t.Show();
                    this.Close();
                    break;
            }
        }

        private void fillObjListView()
        {
            lbFestivals.SetObjects(dbs.GetFestivals());
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

        private void button5_Click(object sender, EventArgs e)
        {
            FestivalListForm festival = new FestivalListForm();
            festival.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageScreenForm messageForm = new MessageScreenForm();
            messageForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VriendenToevoegenForm vriendenToevoegenForm = new VriendenToevoegenForm();
            vriendenToevoegenForm.Show();
            this.Close();
        }
    }
}

