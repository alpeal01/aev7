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
            this.dgvPerm.Location = new System.Drawing.Point(85, 117);
            this.dgvPerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPerm.Name = "dgvPerm";
            this.dgvPerm.RowHeadersWidth = 51;
            this.dgvPerm.Size = new System.Drawing.Size(760, 300);
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
            this.txtNif.Location = new System.Drawing.Point(125, 57);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(216, 22);
            this.txtNif.TabIndex = 1;
            this.txtNif.TextChanged += new System.EventHandler(this.txtNif_TextChanged);
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(81, 60);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(31, 16);
            this.lblNIF.TabIndex = 2;
            this.lblNIF.Text = "NIF:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(785, 468);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(677, 468);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpPerm1
            // 
            this.dtpPerm1.Location = new System.Drawing.Point(76, 469);
            this.dtpPerm1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPerm1.Name = "dtpPerm1";
            this.dtpPerm1.Size = new System.Drawing.Size(265, 22);
            this.dtpPerm1.TabIndex = 5;
            this.dtpPerm1.ValueChanged += new System.EventHandler(this.dtpPerm1_ValueChanged);
            // 
            // dtpPerm2
            // 
            this.dtpPerm2.Location = new System.Drawing.Point(377, 468);
            this.dtpPerm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPerm2.Name = "dtpPerm2";
            this.dtpPerm2.Size = new System.Drawing.Size(255, 22);
            this.dtpPerm2.TabIndex = 6;
            this.dtpPerm2.ValueChanged += new System.EventHandler(this.dtpPerm2_ValueChanged);
            // 
            // fecha_dia
            // 
            this.fecha_dia.HeaderText = "Fecha";
            this.fecha_dia.MinimumWidth = 6;
            this.fecha_dia.Name = "fecha_dia";
            this.fecha_dia.ReadOnly = true;
            this.fecha_dia.Width = 125;
            // 
            // h_entrada
            // 
            this.h_entrada.HeaderText = "Entrada";
            this.h_entrada.MinimumWidth = 6;
            this.h_entrada.Name = "h_entrada";
            this.h_entrada.ReadOnly = true;
            this.h_entrada.Width = 125;
            // 
            // h_salida
            // 
            this.h_salida.HeaderText = "Salida";
            this.h_salida.MinimumWidth = 6;
            this.h_salida.Name = "h_salida";
            this.h_salida.ReadOnly = true;
            this.h_salida.Width = 125;
            // 
            // duracion
            // 
            this.duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duracion.HeaderText = "Duración";
            this.duracion.MinimumWidth = 6;
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtpPerm2);
            this.Controls.Add(this.dtpPerm1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.dgvPerm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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