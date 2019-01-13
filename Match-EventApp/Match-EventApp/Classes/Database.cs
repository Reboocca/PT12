using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            server = s;
            username = u;
            pwd = p;
            database = d;
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

        public List<Festival> GetFestivals()
        {
            List<Festival> lst = new List<Festival>();
            connOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + database + ".festival;");
            cmd.Connection = connect;

            try
            {

                connOpen();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow r in dt.Rows)
                {
                    lst.Add(new Festival(r[1].ToString(), r[2].ToString(), r[0].ToString(), r[5].ToString(), r[3].ToString(), DateTime.Parse(r[8].ToString())));
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connClose();
            }

            return lst;
        }

        /// <summary>
        /// Looks if the user already has a status for that festival in the database
        /// </summary>
        /// <param name="f">Festival ID</param>
        /// <param name="a">Account ID</param>
        /// <returns>True means it exists, false means it doesn't exist yet</returns>
        public bool checkUserFestivalStatus(string f, string a)
        {
            bool b = false;
            connOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + database + ".festival_aanwezigheid WHERE idAccount = '" + a + "' AND idFestival = '" + f + "';");
            cmd.Connection = connect;
            MySqlDataReader check = cmd.ExecuteReader();

            if (check.Read())
            {
                if (check.HasRows)
                {
                    b = true;
                }

                connClose();
            }
            return b;
        }

        /// <summary>
        /// Sets the status of the User / festival table
        /// </summary>
        /// <param name="f">Destival ID</param>
        /// <param name="a">Account ID</param>
        /// <returns></returns>
        public bool setUserFestivalStatus(string f, string a)
        {
            bool b = false;

            connOpen();
            MySqlCommand cmd = new MySqlCommand("UPDATE " + database + ".festival_aanwezigheid SET `status` = 1 WHERE `idAccount` = " + a + " AND `idFestival` = " + f + ";");
            cmd.Connection = connect;

            try
            {
                int update = cmd.ExecuteNonQuery();
                if (update > 0)
                {
                    b = true;
                }
            }
            catch (Exception)
            {
                b = false;
            }
            finally
            {
                connClose();
            }
            return b;
        }

        /// <summary>
        /// Inserts new row for the User / festival table
        /// </summary>
        /// <param name="f">Festival ID</param>
        /// <param name="a">Account ID</param>
        /// <returns></returns>
        public bool insertUserFestivalStatus(string f, string a)
        {
            bool b = false;

            connOpen();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + database + ".festival_aanwezigheid (`idAccount`,`idFestival`, `status`) VALUES (" + a + ", " + f + ", 1);");
            cmd.Connection = connect;

            try
            {
                int insert = cmd.ExecuteNonQuery();
                if (insert > 0)
                {
                    b = true;
                }
            }
            catch (Exception)
            {
                b = false;
            }
            finally
            {
                connClose();
            }
            return b;
        }

        public List<Profiel> getProfiel()
        {
            string query = "SELECT * FROM" + database + ".profiel";
            List<Profiel> profielen = new List<Profiel>();
            connOpen();

            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                profielen.Add(new Profiel(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetInt32(4),
                    read.GetInt32(3), read.GetString(7), read.GetString(8), read.GetString(5), read.GetString(6)));
            }
            connClose();

            return profielen;
        }

        public bool insertlike(int idaccount1,int idaccount2)
        {
            bool succes = false;
            connOpen();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + database + ".matches (`idAccount1`,`idAccount2`,`status`) VALUES(" + idaccount1 + ", " + idaccount2 + ", 1);");
            cmd.Connection = connect;

            try
            {
                int insert = cmd.ExecuteNonQuery();
                if (insert > 0)
                {
                    succes= true;
                }
            }
            catch (Exception)
            {
                succes= false;
            }
            return succes;
        }

        public bool insertdislike(int idaccount1,int idaccount2)
        {
            bool succes = false;
            connOpen();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + database + ".matches (`idAccount1`,`idAccount2`,`status`) VALUES(" + idaccount1 + ", " + idaccount2 + ", 2);");
            cmd.Connection = connect;

            try
            {
                int insert = cmd.ExecuteNonQuery();
                if (insert > 0)
                {
                    succes = true;
                }
            }
            catch (Exception)
            {
                succes = false;
            }
            return succes;
        }
    }
}