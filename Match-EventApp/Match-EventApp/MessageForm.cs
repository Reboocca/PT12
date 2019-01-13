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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void BTclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BThome_Click(object sender, EventArgs e)
        {
            FestivalListForm f2 = new FestivalListForm();
            f2.Show();
            Close();
        }

        private void BTnaam1_Click(object sender, EventArgs e)
        {
            MessageScreenForm f3 = new MessageScreenForm();
            f3.Show();
            Close();
        }

        private void BTnaam2_Click(object sender, EventArgs e)
        {
            MessageScreenForm f3 = new MessageScreenForm();
            f3.Show();
            Close();
        }

        private void BTnaam3_Click(object sender, EventArgs e)
        {
            MessageScreenForm f3 = new MessageScreenForm();
            f3.Show();
            Close();
        }

        private void BTnaam4_Click(object sender, EventArgs e)
        {
            MessageScreenForm f3 = new MessageScreenForm();
            f3.Show();
            Close();
        }

        private void BTnaam5_Click(object sender, EventArgs e)
        {
            MessageScreenForm f3 = new MessageScreenForm();
            f3.Show();
            Close();
        }
    }
}
