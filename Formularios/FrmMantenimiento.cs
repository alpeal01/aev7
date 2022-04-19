using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AEV7.Clases;
using MySql.Data.MySqlClient;

namespace AEV7
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Empleado.CalcLetra(txtNif.Text))
            {
                MessageBox.Show("El NIF no es correcto");

            }
            else
            {
                

                try { 
                    if (ConBD.Conexion != null)
                    {
                        
                        ConBD.AbrirConexion();
                        Empleado emp = new Empleado(txtNif.Text, txtNombre.Text, txtApellidos.Text, txtDir.Text, chbAdmin.Checked, txtCont.Text);

                        Empleado.AgregarEmpleado(emp);

                        MessageBox.Show("Empleado agregado correctamente");

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    ConBD.CerrarConexion();
                }
            }
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
