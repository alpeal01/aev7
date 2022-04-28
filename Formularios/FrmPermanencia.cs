using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AEV7.Clases;

namespace AEV7.Formularios
{
    public partial class FrmPermanencia : Form
    {
        public FrmPermanencia()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Empleado.CalcLetra(txtNif.Text))
            {
                MessageBox.Show("El NIF no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        List<Empleado> lista = new List<Empleado>();
                        lista = Empleado.BuscarEmpleado(txtNif.Text);
                        if (lista.Count > 0 && lista[0].Nif == txtNif.Text)
                        {
                            //codigo
                            dgvPerm.Rows.Clear();
                            List<Fichajes> list = Fichajes.permanencia(txtNif.Text,dtpPerm1.Value, dtpPerm2.Value);

                            foreach (Fichajes f in list)
                            {
                                string duracion = (Math.Truncate(f.Tiempo / 60) + "h " + Math.Truncate(f.Tiempo % 60) + "min").ToString();
                                
                                dgvPerm.Rows.Add(DateTime.Parse(f.Dia).ToString("dddd, dd MMM yyy"), f.Hora, f.Salida, duracion);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se ha podido realizar");
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
        }

        private void FrmPermanencia_Load(object sender, EventArgs e)
        {

        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            txtNif.Text = txtNif.Text.ToUpper();
        }
    }
}

