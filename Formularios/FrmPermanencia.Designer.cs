namespace AEV7.Formularios
{
    partial class FrmPermanencia
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
            this.dgvPerm = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpPerm1 = new System.Windows.Forms.DateTimePicker();
            this.dtpPerm2 = new System.Windows.Forms.DateTimePicker();
            this.fecha_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerm
            // 
            this.dgvPerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_dia,
            this.h_entrada,
            this.h_salida,
            this.duracion});
            this.dgvPerm.Location = new System.Drawing.Point(64, 95);
            this.dgvPerm.Name = "dgvPerm";
            this.dgvPerm.Size = new System.Drawing.Size(570, 244);
            this.dgvPerm.TabIndex = 0;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(94, 46);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(163, 20);
            this.txtNif.TabIndex = 1;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(61, 49);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(27, 13);
            this.lblNIF.TabIndex = 2;
            this.lblNIF.Text = "NIF:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(589, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(508, 380);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpPerm1
            // 
            this.dtpPerm1.Location = new System.Drawing.Point(64, 379);
            this.dtpPerm1.Name = "dtpPerm1";
            this.dtpPerm1.Size = new System.Drawing.Size(200, 20);
            this.dtpPerm1.TabIndex = 5;
            // 
            // dtpPerm2
            // 
            this.dtpPerm2.Location = new System.Drawing.Point(283, 380);
            this.dtpPerm2.Name = "dtpPerm2";
            this.dtpPerm2.Size = new System.Drawing.Size(192, 20);
            this.dtpPerm2.TabIndex = 6;
            // 
            // fecha_dia
            // 
            this.fecha_dia.HeaderText = "Fecha";
            this.fecha_dia.Name = "fecha_dia";
            this.fecha_dia.ReadOnly = true;
            // 
            // h_entrada
            // 
            this.h_entrada.HeaderText = "Entrada";
            this.h_entrada.Name = "h_entrada";
            this.h_entrada.ReadOnly = true;
            // 
            // h_salida
            // 
            this.h_salida.HeaderText = "Salida";
            this.h_salida.Name = "h_salida";
            this.h_salida.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duración";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpPerm2);
            this.Controls.Add(this.dtpPerm1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.dgvPerm);
            this.Name = "FrmPermanencia";
            this.Text = "Permanencia";
            this.Load += new System.EventHandler(this.FrmPermanencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerm;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpPerm1;
        private System.Windows.Forms.DateTimePicker dtpPerm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
    }
}