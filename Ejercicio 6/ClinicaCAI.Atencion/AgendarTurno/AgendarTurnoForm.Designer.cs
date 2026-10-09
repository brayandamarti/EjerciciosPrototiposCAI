namespace ClinicaCAI.Atencion.AgendarTurno
{
    partial class AgendarTurnoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.grpBuscarPaciente = new System.Windows.Forms.GroupBox();
            this.lblDniBuscar = new System.Windows.Forms.Label();
            this.txtDniBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblFechaTurno = new System.Windows.Forms.Label();
            this.dtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.dgvHorariosHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorariosConsultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorariosEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblTurnoSeleccionado = new System.Windows.Forms.Label();
            this.txtTurnoSeleccionado = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBuscarPaciente.SuspendLayout();
            this.grpPaciente.SuspendLayout();
            this.grpTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscarPaciente
            // 
            this.grpBuscarPaciente.Location = new System.Drawing.Point(15, 12);
            this.grpBuscarPaciente.Name = "grpBuscarPaciente";
            this.grpBuscarPaciente.Size = new System.Drawing.Size(830, 65);
            this.grpBuscarPaciente.Text = "Buscar paciente";
            this.grpBuscarPaciente.Controls.Add(this.lblDniBuscar);
            this.grpBuscarPaciente.Controls.Add(this.txtDniBuscar);
            this.grpBuscarPaciente.Controls.Add(this.btnBuscar);
            this.grpBuscarPaciente.Controls.Add(this.btnNuevoPaciente);
            this.grpBuscarPaciente.TabIndex = 0;
            // 
            // lblDniBuscar
            // 
            this.lblDniBuscar.AutoSize = true;
            this.lblDniBuscar.Location = new System.Drawing.Point(15, 30);
            this.lblDniBuscar.Name = "lblDniBuscar";
            this.lblDniBuscar.Text = "DNI:";
            this.lblDniBuscar.TabIndex = 1;
            // 
            // txtDniBuscar
            // 
            this.txtDniBuscar.Location = new System.Drawing.Point(60, 27);
            this.txtDniBuscar.Name = "txtDniBuscar";
            this.txtDniBuscar.Size = new System.Drawing.Size(150, 23);
            this.txtDniBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(225, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 3;
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Location = new System.Drawing.Point(330, 24);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(130, 30);
            this.btnNuevoPaciente.Text = "Nuevo paciente";
            this.btnNuevoPaciente.TabIndex = 4;
            // 
            // grpPaciente
            // 
            this.grpPaciente.Location = new System.Drawing.Point(15, 85);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(830, 145);
            this.grpPaciente.Text = "Datos del paciente";
            this.grpPaciente.Controls.Add(this.lblApellido);
            this.grpPaciente.Controls.Add(this.txtApellido);
            this.grpPaciente.Controls.Add(this.lblNombre);
            this.grpPaciente.Controls.Add(this.txtNombre);
            this.grpPaciente.Controls.Add(this.lblFechaNac);
            this.grpPaciente.Controls.Add(this.dtpFechaNac);
            this.grpPaciente.Controls.Add(this.lblTelefono);
            this.grpPaciente.Controls.Add(this.txtTelefono);
            this.grpPaciente.Controls.Add(this.lblEmail);
            this.grpPaciente.Controls.Add(this.txtEmail);
            this.grpPaciente.Controls.Add(this.lblObraSocial);
            this.grpPaciente.Controls.Add(this.cmbObraSocial);
            this.grpPaciente.Controls.Add(this.lblNroAfiliado);
            this.grpPaciente.Controls.Add(this.txtNroAfiliado);
            this.grpPaciente.Controls.Add(this.btnModificarDatos);
            this.grpPaciente.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 23);
            this.txtApellido.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(390, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(480, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(330, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(15, 68);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Text = "Fecha nac.:";
            this.lblFechaNac.TabIndex = 10;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(110, 65);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(130, 23);
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(260, 68);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(330, 65);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 23);
            this.txtTelefono.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(510, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email:";
            this.lblEmail.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(560, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(15, 106);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Text = "Obra social:";
            this.lblObraSocial.TabIndex = 16;
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.Location = new System.Drawing.Point(110, 103);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(250, 23);
            this.cmbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObraSocial.Items.AddRange(new object[] { "Particular", "OSDE", "Swiss Medical", "Galeno", "PAMI" });
            this.cmbObraSocial.TabIndex = 17;
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(390, 106);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Text = "Nº afiliado:";
            this.lblNroAfiliado.TabIndex = 18;
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(480, 103);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(200, 23);
            this.txtNroAfiliado.TabIndex = 19;
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Location = new System.Drawing.Point(695, 100);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(115, 30);
            this.btnModificarDatos.Text = "Guardar datos";
            this.btnModificarDatos.TabIndex = 20;
            // 
            // grpTurno
            // 
            this.grpTurno.Location = new System.Drawing.Point(15, 238);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Size = new System.Drawing.Size(830, 330);
            this.grpTurno.Text = "Turno";
            this.grpTurno.Controls.Add(this.lblEspecialidad);
            this.grpTurno.Controls.Add(this.cmbEspecialidad);
            this.grpTurno.Controls.Add(this.lblMedico);
            this.grpTurno.Controls.Add(this.cmbMedico);
            this.grpTurno.Controls.Add(this.lblFechaTurno);
            this.grpTurno.Controls.Add(this.dtpFechaTurno);
            this.grpTurno.Controls.Add(this.lblHorarios);
            this.grpTurno.Controls.Add(this.dgvHorarios);
            this.grpTurno.Controls.Add(this.lblMotivo);
            this.grpTurno.Controls.Add(this.txtMotivo);
            this.grpTurno.Controls.Add(this.lblTurnoSeleccionado);
            this.grpTurno.Controls.Add(this.txtTurnoSeleccionado);
            this.grpTurno.TabIndex = 21;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(15, 32);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.TabIndex = 22;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Location = new System.Drawing.Point(110, 29);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(200, 23);
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Items.AddRange(new object[] { "Clínica médica", "Cardiología", "Dermatología", "Pediatría", "Traumatología" });
            this.cmbEspecialidad.TabIndex = 23;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(330, 32);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Text = "Médico:";
            this.lblMedico.TabIndex = 24;
            // 
            // cmbMedico
            // 
            this.cmbMedico.Location = new System.Drawing.Point(390, 29);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(220, 23);
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.Items.AddRange(new object[] { "Dr. Alvarez, Juan", "Dra. Benítez, Carla", "Dr. Sosa, Pablo" });
            this.cmbMedico.TabIndex = 25;
            // 
            // lblFechaTurno
            // 
            this.lblFechaTurno.AutoSize = true;
            this.lblFechaTurno.Location = new System.Drawing.Point(630, 32);
            this.lblFechaTurno.Name = "lblFechaTurno";
            this.lblFechaTurno.Text = "Fecha:";
            this.lblFechaTurno.TabIndex = 26;
            // 
            // dtpFechaTurno
            // 
            this.dtpFechaTurno.Location = new System.Drawing.Point(680, 29);
            this.dtpFechaTurno.Name = "dtpFechaTurno";
            this.dtpFechaTurno.Size = new System.Drawing.Size(130, 23);
            this.dtpFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTurno.TabIndex = 27;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(15, 68);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Text = "Horarios disponibles:";
            this.lblHorarios.TabIndex = 28;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.Location = new System.Drawing.Point(15, 88);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(400, 170);
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.MultiSelect = false;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvHorariosHora, this.dgvHorariosConsultorio, this.dgvHorariosEstado });
            this.dgvHorarios.TabIndex = 29;
            this.dgvHorariosHora.HeaderText = "Hora";
            this.dgvHorariosHora.Name = "dgvHorariosHora";
            this.dgvHorariosHora.Width = 100;
            this.dgvHorariosConsultorio.HeaderText = "Consultorio";
            this.dgvHorariosConsultorio.Name = "dgvHorariosConsultorio";
            this.dgvHorariosConsultorio.Width = 120;
            this.dgvHorariosEstado.HeaderText = "Estado";
            this.dgvHorariosEstado.Name = "dgvHorariosEstado";
            this.dgvHorariosEstado.Width = 177;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(430, 68);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Text = "Motivo de consulta:";
            this.lblMotivo.TabIndex = 30;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(430, 88);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(380, 170);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.TabIndex = 31;
            // 
            // lblTurnoSeleccionado
            // 
            this.lblTurnoSeleccionado.AutoSize = true;
            this.lblTurnoSeleccionado.Location = new System.Drawing.Point(15, 278);
            this.lblTurnoSeleccionado.Name = "lblTurnoSeleccionado";
            this.lblTurnoSeleccionado.Text = "Turno seleccionado:";
            this.lblTurnoSeleccionado.TabIndex = 32;
            // 
            // txtTurnoSeleccionado
            // 
            this.txtTurnoSeleccionado.Location = new System.Drawing.Point(145, 275);
            this.txtTurnoSeleccionado.Name = "txtTurnoSeleccionado";
            this.txtTurnoSeleccionado.Size = new System.Drawing.Size(665, 23);
            this.txtTurnoSeleccionado.ReadOnly = true;
            this.txtTurnoSeleccionado.TabIndex = 33;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(624, 594);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Agendar";
            this.btnAceptar.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(742, 594);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 35;
            // 
            // AgendarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 640);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpBuscarPaciente);
            this.Controls.Add(this.grpPaciente);
            this.Controls.Add(this.grpTurno);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AgendarTurnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar paciente y agendar turno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.grpBuscarPaciente.ResumeLayout(false);
            this.grpBuscarPaciente.PerformLayout();
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscarPaciente;
        private System.Windows.Forms.Label lblDniBuscar;
        private System.Windows.Forms.TextBox txtDniBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.GroupBox grpTurno;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblFechaTurno;
        private System.Windows.Forms.DateTimePicker dtpFechaTurno;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHorariosHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHorariosConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHorariosEstado;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblTurnoSeleccionado;
        private System.Windows.Forms.TextBox txtTurnoSeleccionado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
