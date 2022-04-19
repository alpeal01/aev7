using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AEV7.Clases
{
    public class ConBD
    {

     
        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();

        private ConBD() { }


        public static MySqlConnection Conexion
        {
            get
            {
                
                lock (padlock)
                {
                    
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        string server = "server=database-1.cy5wu53qozpc.us-east-1.rds.amazonaws.com;";
                        string database = "database=AEV7;";
                        string usuario = "uid=admin;";
                        string password = "pwd=admin123;";
                        instancia.ConnectionString = server + database + usuario + password;
                    }
                    return instancia;
                }
            }
        }

        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }

        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }

    }
}

