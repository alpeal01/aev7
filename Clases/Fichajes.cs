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
        private string dia;
        private string hora;
        private string salida;
        private double tiempo;

        public string Dia { get { return dia; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public string Hora { get { return hora; } }
        public string Salida { get { return salida; } }
        public double Tiempo { get { return tiempo; } }
        




        public Fichajes(string n, string ap, string h)
        {
            nombre = n;
            apellidos = ap;
            hora = h;
            
        }
        //permanencia
        public Fichajes(string day, string h, string s, double t)
        {
            dia = day;
            hora = h;
            salida = s;
            tiempo = t;
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
                    lista.Add(fichaje);
                }
                reader.Close();

                for (int i = 0; i < lista.Count; i++)
                {
                    mensaje += "\r\n-------------------------";
                    mensaje += "\r\nNombre: " + lista[i].Nombre + " " + lista[i].Apellidos + "; Hora de entrada: " + lista[i].Hora;
                }
            }
            return mensaje;

        }
        
        public static List<Fichajes> permanencia(string nif,DateTime d1 , DateTime d2)
        {
            List<Fichajes> lista = new List<Fichajes>();
            string consulta = String.Format("SELECT dia, h_entrada, h_salida FROM empleado INNER JOIN fichaje ON nif = nif_empleado " +
                "WHERE  nif_empleado = '{0}' and fichaje.dia BETWEEN '{1}' and '{2}' ",nif, d1.ToString("yyyy-MM-dd"), d2.ToString("yyyy-MM-dd"));
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    double tiempo = TimeSpan.Parse(reader.GetString(2)).TotalMinutes - TimeSpan.Parse(reader.GetString(1)).TotalMinutes;
                    Fichajes fichaje = new Fichajes(reader.GetString(0), reader.GetString(1), reader.GetString(2), tiempo);

                    lista.Add(fichaje);
                }
                reader.Close();
            }
            return lista;
        }
    }
}
