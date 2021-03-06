using AEV7.Clases;
using AEV7.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AEV7
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        int tik = 0;
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (!Empleado.CalcLetra(txtNif.Text))
            {
                ptbFoto.Visible = false;
                txtMessage.Text = "El NIF no es correcto";
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
                        if (lista.Count > 0 && lista[0].Nif == txtNif.Text && lista[0].Borrado == false)
                        {
                            if (Empleado.compFicharEntrada(txtNif.Text))
                            {
                                ptbFoto.Visible = false;
                                txtMessage.Text = "Empleado ya ha fichado";
                            }
                            else
                            {
                                Empleado.FicharEntrada(txtNif.Text, lblHora.Text);
                                ptbFoto.Visible = false;
                                txtMessage.Text = "Fichaje realizado correctamente";
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

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (!Empleado.CalcLetra(txtNif.Text))
            {
                ptbFoto.Visible = false;
                txtMessage.Text = "El NIF no es correcto";
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
                        if (lista.Count > 0 && lista[0].Nif == txtNif.Text && lista[0].Borrado == false)
                        {
                            if (!Empleado.compFicharEntrada(txtNif.Text))
                            {
                                ptbFoto.Visible = false;
                                txtMessage.Text = "Empleado no tiene entrada fichada";
                            }
                            else
                            {
                                Empleado.FicharSalida(txtNif.Text, lblHora.Text);
                                ptbFoto.Visible = false;
                                txtMessage.Text = "Fichaje realizado correctamente";
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

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    string mensaje = Fichajes.LEmpleados();
                    ptbFoto.Visible = false;
                    txtMessage.Text = mensaje;

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
        
        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            FrmPermanencia frm = new FrmPermanencia();
            frm.ShowDialog();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ptbFoto.Visible = true;
            txtMessage.Clear();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tmrReloj.Enabled = true;
            tmrReloj.Interval = 1;
            lblHora.Text = DateTime.Now.ToString("T");
            lblDia.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            
            lblHora.Text = DateTime.Now.ToString("T");
            
            if(ptbFoto.Visible == false && tik == 1000)
            {
                ptbFoto.Visible = true;
                txtMessage.Clear();
                tik = 0;
            }else if (tik == 1000)
            {
                tik = 0;
            }
            else
            {
                tik++;
            }
                
            

            
            
        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            txtNif.Text = txtNif.Text.ToUpper();
        }
    }
}
