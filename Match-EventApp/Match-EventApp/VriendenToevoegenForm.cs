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
    public partial class VriendenToevoegenForm : Form
    {
        Account acc = new Account();
        Database db = new Database();

        int idAcc1;

        private void VriendenToevoegenForm_Load()
        {
            //id ophalen van de huidige gebruiker
            idAcc1 = acc._idAccount;
        }

        private void BTvrienden_toevoegen_Click(object sender, EventArgs e)
        {
            db.addFriend(idAcc1.ToString());
        }

        private void BThome_Click_1(object sender, EventArgs e)
        {
            InlogForm f2 = new InlogForm();
            f2.Show();
            Close();
        }
    }
}
