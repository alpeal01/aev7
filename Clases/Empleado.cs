using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AEV7.Clases
{

    internal class Empleado
    {
        string nif;
        string nombre;
        string apellido;
        string direccion;
        bool admin;
        bool borrado;
        string clave;

        public string Nif { get { return nif; } }
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public string Direccion { get { return direccion; } }
        public bool Admin { get { return admin; } }
        public bool Borrado { get { return borrado; } }
        public string Clave { get { return clave; } }


        public Empleado(string nif, string nom, string ape, string dir, bool adm, string clave)
        {
            this.nif = nif;
            this.nombre = nom;
            this.apellido = ape;
            this.direccion = dir;
            this.admin = adm;
            this.borrado = false;
            this.clave = clave;

        }
        /// <summary>
        /// Calcular la letra del nif y devulve si es cierta o no
        /// </summary>
        /// <param name="nif">nif del usuario</param>
        /// <returns>True or False</returns>
        public static bool CalcLetra(string nif)
        {
            string letra = "TRWAGMYFPDXBNJZSQVHLCKE";
            string num="";

            for (int i = 0; i < nif.Length -1; i++)
            {
                num += nif[i];
            }
            char let = letra[int.Parse(num) % 23];

            if (let == nif[8])
            {
                return true;

            }
            else
                return false;

        }

        /// <summary>
        /// Función que inserta un empleado en la base de datos
        /// </summary>
        /// <param name="emp">Objeto Empleado</param>
        /// <returns>Número de registros afectados</returns>
        public static int AgregarEmpleado(Empleado emp)
        {
            
            int retorno;
            string consulta = String.Format("INSERT INTO empleado (nif, nombre, apellido, direccion, clave, administrador, borrado) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}',", emp.nif, emp.Nombre, emp.Apellido, emp.Direccion, emp.Clave);
            consulta += " " + emp.admin;
            consulta += ", " + emp.borrado + ");";


            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Empleado> BuscarEmpleado(string nif)
        {
            List<Empleado> lista = new List<Empleado>();
            string consulta = String.Format("SELECT * FROM empleado WHERE nif = ('{0}')", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetBoolean(4), reader.GetString(6));
                    lista.Add(user);
                }
            }
            return lista;

        }

    }
}
