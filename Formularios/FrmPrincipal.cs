using AEV7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {

            InitializeComponent();
            /*try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    MessageBox.Show("Se ha conectado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }*/
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string consulta;

            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();


                    if (String.IsNullOrEmpty(txtNif.Text))
                    {
                        errorProvider1.SetError(txtNif, "NIF Inválido");
                    }
                    else
                    {
                        consulta = "INSERT INTO fichaje ";
                    }

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

        private void btnSalida_Click(object sender, EventArgs e)
        {

        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            ptbFoto.Visible = false;
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ptbFoto.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
