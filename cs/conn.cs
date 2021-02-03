using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EIMS_CS
{
    public class conn
    {
        public MySqlConnection connection;
        private String database;
        private String server;
        private String user;
        private String pwd;

        public conn()
        {
            database = "johnnie";
            server = "localhost";
            user = "root";
            pwd = "";

            String connectionString = "SERVER=" + server+";"+"DATABASE="+ database+";" + "UID="+ user + ";" + "PASSWORD=" + pwd+";";
            connection = new MySqlConnection(connectionString);
        }
        //Open Connection
        public bool OpenConnection()
        {
             try
            {
                connection.Open();
                return true;
            }
             catch (MySqlException ex)
             {

                 switch (ex.Number)
                 {
                     case 0:
                         MessageBox.Show("Cannot connect to server.  Contact administrator");
                         break;

                     case 1045:
                         MessageBox.Show("Invalid username/password, Please try again");
                         break;
                 }
                 return false;
             }
        }
        //Close Connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
