using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AEV7.Clases;
using MySql.Data.MySqlClient;

namespace AEV7
{
    public partial class FrmMantenimiento : Form
    {

        public void RellenarDataGrid()
        {
            dtvEmpleados.Rows.Clear();
            List<Empleado> lista = new List<Empleado>();
            lista = Empleado.ListadoEmpleados();
            for (int i = 0; i < lista.Count; i++)
            {
                dtvEmpleados.Rows.Add(lista[i].Nif, lista[i].Nombre, lista[i].Apellido, lista[i].Direccion, lista[i].Admin);
            }
        }

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
            RellenarDataGrid();
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConBD.AbrirConexion();
            Empleado.BorrarEmpleado(txtNif.Text);
            RellenarDataGrid();
            ConBD.CerrarConexion();
        }

        private void btnCerrarAPP_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(1);
        }

        private void dtvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;

            id = dtvEmpleados.CurrentRow.Cells[0].Value.ToString();

            ConBD.AbrirConexion();
            Empleado.BorrarEmpleado(id);
            RellenarDataGrid();
            ConBD.CerrarConexion();
        }
    }
}
