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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    List<Empleado> lista = new List<Empleado>();
                    lista = Empleado.BuscarEmpleado(txtNif.Text);
                    if (lista[0].Nif == txtNif.Text && lista[0].Clave == txtCont.Text)
                    {
                        FrmMantenimiento mant = new FrmMantenimiento();
                        mant.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido acceder");
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
            this.Close();
            this.Dispose();
        }
    }
}
    

