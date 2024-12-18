using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace LoginEjercicio.Data
{
    internal class Connection
    {

        public static string server = "127.0.0.1";
        public static string port = "3308";
        public static string dataBase = "login";
        public static string user = "root";
        public static string pwd = "root";

        public static MySqlConnection connMaster;

       

        public static void openConnection()
        {
            string connectionString = $"server={server};port={port};database={dataBase};user={user};password={pwd}";

            connMaster = new MySqlConnection(connectionString) ;    
            connMaster.Open();
            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión establecida");
            }
            else
            {
                MessageBox.Show("No se ha establecido conexión");
            }
        }
        public static void closeConnection() 
        { 

        }
    }
}
