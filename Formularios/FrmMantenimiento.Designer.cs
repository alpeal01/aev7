namespace AEV7
{
    partial class FrmMantenimiento
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
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgFichajes = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFichajes = new System.Windows.Forms.Label();
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblGestion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCerrarAPP = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFichajes)).BeginInit();
            this.grpGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nif,
            this.nombre,
            this.apellido,
            this.direccion,
            this.admin});
            this.dtgEmpleados.Location = new System.Drawing.Point(140, 97);
            this.dtgEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersWidth = 51;
            this.dtgEmpleados.Size = new System.Drawing.Size(909, 245);
            this.dtgEmpleados.TabIndex = 0;
            this.dtgEmpleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvEmpleados_CellContentDoubleClick);
            // 
            // nif
            // 
            this.nif.HeaderText = "NIF";
            this.nif.MinimumWidth = 6;
            this.nif.Name = "nif";
            this.nif.ReadOnly = true;
            this.nif.Width = 130;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 130;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 130;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 130;
            // 
            // admin
            // 
            this.admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admin.HeaderText = "Administrador";
            this.admin.MinimumWidth = 6;
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // dtgFichajes
            // 
            this.dtgFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFichajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Dia,
            this.hora_entrada,
            this.h_salida});
            this.dtgFichajes.Location = new System.Drawing.Point(140, 436);
            this.dtgFichajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgFichajes.Name = "dtgFichajes";
            this.dtgFichajes.ReadOnly = true;
            this.dtgFichajes.RowHeadersWidth = 51;
            this.dtgFichajes.Size = new System.Drawing.Size(625, 245);
            this.dtgFichajes.TabIndex = 1;
            this.dtgFichajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFichajes_CellContentClick);
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            this.Dia.Width = 125;
            // 
            // hora_entrada
            // 
            this.hora_entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hora_entrada.HeaderText = "Hora Entrada";
            this.hora_entrada.MinimumWidth = 6;
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.ReadOnly = true;
            // 
            // h_salida
            // 
            this.h_salida.HeaderText = "Hora Salida";
            this.h_salida.MinimumWidth = 6;
            this.h_salida.Name = "h_salida";
            this.h_salida.ReadOnly = true;
            this.h_salida.Width = 125;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblInfo.Location = new System.Drawing.Point(136, 53);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(315, 29);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Información de Empleados";
            // 
            // lblFichajes
            // 
            this.lblFichajes.AutoSize = true;
            this.lblFichajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFichajes.Location = new System.Drawing.Point(133, 388);
            this.lblFichajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFichajes.Name = "lblFichajes";
            this.lblFichajes.Size = new System.Drawing.Size(282, 29);
            this.lblFichajes.TabIndex = 3;
            this.lblFichajes.Text = "Información de Fichajes";
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.txtDir);
            this.grpGestion.Controls.Add(this.lblDir);
            this.grpGestion.Controls.Add(this.btnAgregar);
            this.grpGestion.Controls.Add(this.btnEliminar);
            this.grpGestion.Controls.Add(this.txtCont);
            this.grpGestion.Controls.Add(this.txtApellidos);
            this.grpGestion.Controls.Add(this.txtNombre);
            this.grpGestion.Controls.Add(this.txtNif);
            this.grpGestion.Controls.Add(this.chbAdmin);
            this.grpGestion.Controls.Add(this.lblCont);
            this.grpGestion.Controls.Add(this.lblApellidos);
            this.grpGestion.Controls.Add(this.lblNombre);
            this.grpGestion.Controls.Add(this.lblNif);
            this.grpGestion.Controls.Add(this.lblGestion);
            this.grpGestion.Location = new System.Drawing.Point(1201, 97);
            this.grpGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGestion.Size = new System.Drawing.Size(375, 482);
            this.grpGestion.TabIndex = 4;
            this.grpGestion.TabStop = false;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(112, 258);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(132, 22);
            this.txtDir.TabIndex = 13;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(21, 262);
            this.lblDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(67, 16);
            this.lblDir.TabIndex = 12;
            this.lblDir.Text = "Dirección:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(39, 391);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 43);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(223, 391);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 43);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(112, 338);
            this.txtCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(132, 22);
            this.txtCont.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(112, 210);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(132, 22);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 162);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(112, 113);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(132, 22);
            this.txtNif.TabIndex = 6;
            this.txtNif.TextChanged += new System.EventHandler(this.txtNif_TextChanged);
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Location = new System.Drawing.Point(127, 300);
            this.chbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(112, 20);
            this.chbAdmin.TabIndex = 5;
            this.chbAdmin.Text = "Administrador";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(19, 342);
            this.lblCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(79, 16);
            this.lblCont.TabIndex = 4;
            this.lblCont.Text = "Contraseña:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(28, 210);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(67, 16);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 166);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(55, 117);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(31, 16);
            this.lblNif.TabIndex = 1;
            this.lblNif.Text = "NIF:";
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblGestion.Location = new System.Drawing.Point(32, 36);
            this.lblGestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(290, 29);
            this.lblGestion.TabIndex = 0;
            this.lblGestion.Text = "Gestión de Empleados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCerrar.Location = new System.Drawing.Point(1441, 610);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 48);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCerrarAPP
            // 
            this.btnCerrarAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCerrarAPP.Location = new System.Drawing.Point(1399, 5);
            this.btnCerrarAPP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarAPP.Name = "btnCerrarAPP";
            this.btnCerrarAPP.Size = new System.Drawing.Size(191, 46);
            this.btnCerrarAPP.TabIndex = 6;
            this.btnCerrarAPP.Text = "Cerrar Aplicación";
            this.btnCerrarAPP.UseVisualStyleBackColor = true;
            this.btnCerrarAPP.Click += new System.EventHandler(this.btnCerrarAPP_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(764, 346);
            this.lblInformacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(226, 16);
            this.lblInformacion.TabIndex = 7;
            this.lblInformacion.Text = "Doble click para borrar un empleado";
            // 
            // btnHoy
            // 
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHoy.Location = new System.Drawing.Point(815, 455);
            this.btnHoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(201, 43);
            this.btnHoy.TabIndex = 8;
            this.btnHoy.Text = "Fichajes de Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEmp.Location = new System.Drawing.Point(815, 537);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(201, 43);
            this.btnEmp.TabIndex = 9;
            this.btnEmp.Text = "Registro de Fichajes";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 745);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnCerrarAPP);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grpGestion);
            this.Controls.Add(this.lblFichajes);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dtgFichajes);
            this.Controls.Add(this.dtgEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMantenimiento";
            this.Text = "Funciones de Mantenimiento";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFichajes)).EndInit();
            this.grpGestion.ResumeLayout(false);
            this.grpGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.DataGridView dtgFichajes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFichajes;
        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
        private System.Windows.Forms.Button btnCerrarAPP;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_salida;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnEmp;
    }
}