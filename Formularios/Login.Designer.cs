namespace AEV7
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicioS = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInicioS
            // 
            this.lblInicioS.AutoSize = true;
            this.lblInicioS.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblInicioS.Location = new System.Drawing.Point(117, 37);
            this.lblInicioS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicioS.Name = "lblInicioS";
            this.lblInicioS.Size = new System.Drawing.Size(315, 48);
            this.lblInicioS.TabIndex = 0;
            this.lblInicioS.Text = "Inicio de Sesión";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombre.Location = new System.Drawing.Point(159, 117);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(251, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NIF de Administrador";
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNif.Location = new System.Drawing.Point(165, 165);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(252, 26);
            this.txtNif.TabIndex = 2;
            this.txtNif.TextChanged += new System.EventHandler(this.txtNif_TextChanged);
            // 
            // txtCont
            // 
            this.txtCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCont.Location = new System.Drawing.Point(165, 286);
            this.txtCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(252, 26);
            this.txtCont.TabIndex = 3;
            this.txtCont.UseSystemPasswordChar = true;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCont.Location = new System.Drawing.Point(159, 225);
            this.lblCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(143, 29);
            this.lblCont.TabIndex = 4;
            this.lblCont.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEntrar.Location = new System.Drawing.Point(281, 351);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(137, 42);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 438);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInicioS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioS;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Button btnEntrar;
    }
}