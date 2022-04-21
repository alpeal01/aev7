using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7.Clases
{
    internal class Fichajes
    {
        private string nombre;
        private string apellidos;
        private string hora;

        public Fichajes(string n, string ap, string h)
        {
            nombre = n;
            apellidos = ap;
            hora = h;
        }

        public static string ListadoEmpleados()
        {
            string mensaje = "Empleados actualmente activos:";
            List<Fichajes> lista = new List<Fichajes>();
            string consulta = String.Format("SELECT nombre, apellido, h_entrada FROM empleado INNER JOIN fichaje ON nif = nif_empleado WHERE fichaje.dia = CURRENT_DATE;");
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    Fichajes fichaje = new Fichajes(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    mensaje += "\r\n " + fichaje.nombre + fichaje.apellidos + "Hora: " + fichaje.hora;
                    lista.Add(fichaje);
                }
                reader.Close();
            }
            return mensaje;

        }
    }
}
