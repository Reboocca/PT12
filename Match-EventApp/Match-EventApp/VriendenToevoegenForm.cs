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
    public partial class VriendenToevoegenForm : Form
    {
        public VriendenToevoegenForm()
        {
            InitializeComponent();
        }

        private void BThome_Click(object sender, EventArgs e)
        {
            Close();
            InlogForm f2 = new InlogForm();
            f2.Show();
        }

        private void BTclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
