using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AEV7.Clases;
using MySql.Data.MySqlClient;

namespace AEV7
{
    public partial class FrmMantenimiento : Form
    {

        /// <summary>
        /// Rellena del datagrid con los empleados que hay activos
        /// </summary>
        public void RellenarDataGridEmp()

        {
            dtgEmpleados.Rows.Clear();
            List<Empleado> lista = new List<Empleado>();
            lista = Empleado.ListadoEmpleados();
            for (int i = 0; i < lista.Count; i++)
            {
                dtgEmpleados.Rows.Add(lista[i].Nif, lista[i].Nombre, lista[i].Apellido, lista[i].Direccion, lista[i].Admin);
            }
        }

        /// <summary>
        /// Rellena del datagrid con los fichajes que se especifican
        /// </summary>
        /// <param name="comprobar"></param>
        public void RellenarDataGridFich(bool comprobar)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            
            dtgFichajes.Rows.Clear();
            
            List<Fichajes> listado = new List<Fichajes>();
            
            listado = Fichajes.ListadoFichajes(comprobar);
            
            for (int j = 0; j < listado.Count; j++)
            {
                if (listado[j].Dia == fecha && comprobar == false)
                {
                    dtgFichajes.Rows.Add(listado[j].Nif, listado[j].Dia, listado[j].Hora, listado[j].Salida);
                }
                else if (comprobar == true)
                {
                    dtgFichajes.Rows.Add(listado[j].Nif, listado[j].Dia, listado[j].Hora, listado[j].Salida);
                }

            }


        }

        public FrmMantenimiento()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// Agrega un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        List <Empleado> lista = Empleado.BuscarEmpleado(txtNif.Text);
                        if (lista.Count == 0)
                        {
                            Empleado emp = new Empleado(txtNif.Text, txtNombre.Text, txtApellidos.Text, txtDir.Text, chbAdmin.Checked, txtCont.Text,false);

                            Empleado.AgregarEmpleado(emp);
                            
                            MessageBox.Show("Empleado agregado correctamente");
                        }
                        else
                        {
                            if (!lista[0].Borrado)
                            {
                                DialogResult dialogResult = MessageBox.Show("Empleado ya registrado pero borrado\n ¿Desea dar de alta?", 
                                    "Empleado ya registrado", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    Empleado.RestaurarEmpleado(lista[0]);
                                    MessageBox.Show("Empleado restaurado correctamente");
                                    RellenarDataGridEmp();


                                }
                            }

                            MessageBox.Show("El empleado ya existe");
                        }

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
            bool comprobar = false;
            RellenarDataGridEmp();
            RellenarDataGridFich(comprobar);
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    if (Empleado.CalcLetra(txtNif.Text)) {
                        Empleado.BorrarEmpleado(txtNif.Text);
                        RellenarDataGridEmp();
                    MessageBox.Show("Empleado eliminado correctamente"); 
                    }
                    else
                    {
                        MessageBox.Show("Nif incorrecto");
                    }
                    

                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }        
    

        private void btnCerrarAPP_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
        /// <summary>
        /// Al pulsar doble click borra un empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (ConBD.Conexion != null)
                {

                    ConBD.AbrirConexion();
                    Empleado.BorrarEmpleado(id);
                    RellenarDataGridEmp();
                    ConBD.CerrarConexion();

                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }


        /// <summary>
        /// Cambia a mayúscula la letra del nif automáticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            txtNif.Text = txtNif.Text.ToUpper(); }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    bool comprobar = false;
                    ConBD.AbrirConexion();
                    RellenarDataGridFich(comprobar);

                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    bool comprobar = true;
                    ConBD.AbrirConexion();
                    RellenarDataGridFich(comprobar);

                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }

        }

        private void dtgFichajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
