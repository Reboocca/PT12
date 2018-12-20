using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Match_EventApp.Classes
{
    class Database
    {
        private static string server;
        private static string username;
        private static string pwd;
        private static string database;
        private MySqlConnection connect;

        public Database(string s, string u, string d, string p)
        {
            server      = s;
            username    = u;
            pwd         = p;
            database    = d;
        }
        
        public Database()
        {

        }

        private void connOpen()
        {
            string conn = "Server=" + server + ";Uid=" + username + ";Database=" + database + ";Pwd=" + pwd + ";";
            connect = new MySqlConnection(conn);
            connect.Open();
        }

        private void connClose()
        {
            connect.Close();
        }

        public bool login(string username, string pwd)
        {
            bool b = false;
            connOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + database + ".account WHERE username = '" + username + "' AND password = '" + pwd + "';");
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                if (login.HasRows)
                {
                    Account acc = new Account();
                    acc._idAccount = login.GetInt32("idAccount");
                    b = true;
                }

                connClose();
            }
            return b;
        }

        public bool register(string u, string p)
        {
            bool b = false;
            connOpen();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + database + ".account (`username`, `password`) VALUES ('" + u + "', '" + p + "');");
            cmd.Connection = connect;

            try
            {
                int register = cmd.ExecuteNonQuery();
                if (register > 0)
                {
                    b = true;
                    connClose();
                }
            }
            catch (Exception)
            {
                b = false;
            }


            return b;
        }

        public bool updateUserInfo(string v, string a, int l, string h, string f, string g, int ge, OpenFileDialog foto)
        {
            bool b = false;
            string url = savedFotoAsync(foto);
            if (url != "false")
            {
                connOpen();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO " + database + ".profiel " +
                    "(`idAccount`,`voornaam`, `achternaam`, `leeftijd`, `hobbys`, `fav_festival`, `fav_genre_films`, `geslacht`, `foto`) " +
                    "VALUES ( LAST_INSERT_ID(),'" + v + "', '" + a + "', " + l + ", '" + h + "', '" + f + "', '" + g + "', " + ge + ", '" + url + "');");
                cmd.Connection = connect;

                try
                {
                    int insert = cmd.ExecuteNonQuery();
                    if (insert > 0)
                    {
                        b = true;
                        connClose();
                    }
                }
                catch (Exception)
                {
                    b = false;
                }
            }

            

            return b;
        }

        private string savedFotoAsync(OpenFileDialog file)
        {
            string url = "";

            WebClient client = new WebClient();
            string myFile = file.FileName;
            client.Credentials = CredentialCache.DefaultCredentials;
            var response = client.UploadFile(@"http://i412769.hera.fhict.nl/FUN12/upload_image.php", "POST", myFile);
            url = client.Encoding.GetString(response);
            client.Dispose();

            return url;
        }

    }
}
