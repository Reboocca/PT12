using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp.Classes
{
    class Account
    {
        private static string username;
        private static int idAccount;
        //profiel
        //lijst vrienden
        //lijst matches

        public Account()
        {
            //maak nieuw profiel
            //maak lijst vrienden
            //maak lijst matches
        }

        public string _username
        {
            get { return username; }
            set { username = value; }
        }

        public int _idAccount
        {
            get { return idAccount; }
            set { idAccount = value; }
        }

        public bool joinFestival(Festival f)
        {
            bool b = false;
            Database db = new Database();

            if (db.checkUserFestivalStatus(f.idFestival, idAccount.ToString()))
            {
                b = db.setUserFestivalStatus(f.idFestival, idAccount.ToString());
            }
            else
            {
                b = db.insertUserFestivalStatus(f.idFestival, idAccount.ToString());
            }

            return b;
        }

        public void Register(string user, int id)
        {
            _username = user;
            _idAccount = id;
        }
    }
}
