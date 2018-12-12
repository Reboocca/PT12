using System;
using MySql.Data.MySqlClient;

namespace Match_EventApp.Classes
{
    class Database
    {
        private string server;
        private string username;
        private string pwd;
        private string database;
        private MySqlConnection connect;

        public Database(string server, string username, string database, string pwd)
        {
            this.server = server;
            this.username = username;
            this.pwd = pwd;
            this.database = database;
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

        public bool register(string username, string pwd)
        {
            bool b = false;
            connOpen();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO " + database + ".account (`username`, `password`) VALUES ('" + username + "', '" + pwd + "');");
            cmd.Connection = connect;

            try
            {
                int register = cmd.ExecuteNonQuery();
                if (register > 0)
                {
                    if (login(username, pwd))
                    {
                        b = true;
                    }

                    connClose();
                }
            }
            catch (Exception)
            {
                b = false;
            }


            return b;
        }

        public int getNewID(string returncol, string table, string column, string value)
        {
            int id = 0;
            connOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT " + returncol + " FROM " + database + "." + table + " WHERE " + column + " = '" + value + "' LIMIT 0, 1;");
            cmd.Connection = connect;
            MySqlDataReader getId = cmd.ExecuteReader();

            if (getId.HasRows)
            {
                while (getId.Read())
                {
                    id = getId.GetInt32(0);
                }
            }

            return id;
        }
    }
}
