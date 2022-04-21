using System;
using System.Collections;
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

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de empleados.
                while (reader.Read())
                {
                    Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetBoolean(4), reader.GetString(6));
                    lista.Add(user);
                }
                reader.Close();
            }
            return lista;

        }

        public static int FicharEntrada(string nif, string hora)
        {
            int retorno;
            DateTime dia = DateTime.Now;
            string consulta = String.Format("INSERT INTO fichaje (nif_empleado, dia, h_entrada, F_entrada, f_salida) VALUES " +
                "('{0}','{1}','{2}', true , false)", nif, dia.ToString("yyyy-MM-dd"), hora);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int FicharSalida(string nif, string hora)
        {
            int retorno;
            string consulta = String.Format("UPDATE fichaje SET f_salida = true, h_salida = ('{1}') WHERE nif_empleado = ('{0}')", nif, hora);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static bool compFicharEntrada(string nif)
        {
            int retorno;
            string consulta = String.Format("SELECT count(*) FROM fichaje WHERE nif_empleado = ('{0}') AND f_entrada = true and f_salida = false", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            retorno = reader.GetInt32(0);
            reader.Close();

            if (retorno == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static List<Empleado> ListadoEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            string consulta = String.Format("SELECT * FROM empleado WHERE borrado = false;");
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hallen registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de empleados.
                while (reader.Read())
                {
                    Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetBoolean(4), reader.GetString(6));
                    lista.Add(user);
                }
                reader.Close();
            }
            return lista;
        }

        public static int BorrarEmpleado(string nif)
        {
            int retorno;

            string consulta = String.Format("UPDATE empleado SET borrado = true WHERE nif = ('{0}')", nif);

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}
