namespace AEV7
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.grbDiaHora = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.grbDiaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFoto
            // 
            this.ptbFoto.Image = global::AEV7.Properties.Resources.Foto_flori;
            this.ptbFoto.Location = new System.Drawing.Point(96, 165);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(791, 409);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 0;
            this.ptbFoto.TabStop = false;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDia.Location = new System.Drawing.Point(48, 28);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(41, 25);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(59, 63);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(54, 25);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.txtNif.Location = new System.Drawing.Point(254, 56);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(425, 83);
            this.txtNif.TabIndex = 3;
            this.txtNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEntrada.Location = new System.Drawing.Point(1122, 207);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(229, 52);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSalida.Location = new System.Drawing.Point(1122, 281);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(229, 56);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPresencia.Location = new System.Drawing.Point(1122, 356);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(229, 57);
            this.btnPresencia.TabIndex = 6;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMantenimiento.Location = new System.Drawing.Point(1122, 505);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(229, 53);
            this.btnMantenimiento.TabIndex = 7;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPermanencia.Location = new System.Drawing.Point(1122, 432);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(229, 54);
            this.btnPermanencia.TabIndex = 7;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // grbDiaHora
            // 
            this.grbDiaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbDiaHora.Controls.Add(this.lblDia);
            this.grbDiaHora.Controls.Add(this.lblHora);
            this.grbDiaHora.Location = new System.Drawing.Point(1190, 28);
            this.grbDiaHora.Name = "grbDiaHora";
            this.grbDiaHora.Size = new System.Drawing.Size(200, 100);
            this.grbDiaHora.TabIndex = 8;
            this.grbDiaHora.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.textBox1.Location = new System.Drawing.Point(172, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(644, 290);
            this.textBox1.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(172, 505);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(644, 53);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 607);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grbDiaHora);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.txtNif);
            this.Name = "FrmPrincipal";
            this.Text = "Aev7";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.grbDiaHora.ResumeLayout(false);
            this.grbDiaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.GroupBox grbDiaHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer tmrReloj;
    }
}

