namespace ClinicaCAI.Atencion.AtenderPaciente
{
    partial class AtenderPacienteForm
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
            this.lblTurnosDia = new System.Windows.Forms.Label();
            this.dgvTurnosDia = new System.Windows.Forms.DataGridView();
            this.dgvTurnosDiaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTurnosDiaPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTurnosDiaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.dgvHistoriaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistoriaMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistoriaDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.grpReceta = new System.Windows.Forms.GroupBox();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPosologia = new System.Windows.Forms.Label();
            this.txtPosologia = new System.Windows.Forms.TextBox();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.dgvMedicamentosMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosPosologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarMedicamento = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPaciente.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.grpReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurnosDia
            // 
            this.lblTurnosDia.AutoSize = true;
            this.lblTurnosDia.Location = new System.Drawing.Point(15, 12);
            this.lblTurnosDia.Name = "lblTurnosDia";
            this.lblTurnosDia.Text = "Turnos del día:";
            this.lblTurnosDia.TabIndex = 0;
            // 
            // dgvTurnosDia
            // 
            this.dgvTurnosDia.Location = new System.Drawing.Point(15, 32);
            this.dgvTurnosDia.Name = "dgvTurnosDia";
            this.dgvTurnosDia.Size = new System.Drawing.Size(380, 250);
            this.dgvTurnosDia.AllowUserToAddRows = false;
            this.dgvTurnosDia.AllowUserToDeleteRows = false;
            this.dgvTurnosDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosDia.MultiSelect = false;
            this.dgvTurnosDia.RowHeadersVisible = false;
            this.dgvTurnosDia.ReadOnly = true;
            this.dgvTurnosDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvTurnosDiaHora, this.dgvTurnosDiaPaciente, this.dgvTurnosDiaEstado });
            this.dgvTurnosDia.TabIndex = 1;
            this.dgvTurnosDiaHora.HeaderText = "Hora";
            this.dgvTurnosDiaHora.Name = "dgvTurnosDiaHora";
            this.dgvTurnosDiaHora.Width = 70;
            this.dgvTurnosDiaPaciente.HeaderText = "Paciente";
            this.dgvTurnosDiaPaciente.Name = "dgvTurnosDiaPaciente";
            this.dgvTurnosDiaPaciente.Width = 200;
            this.dgvTurnosDiaEstado.HeaderText = "Estado";
            this.dgvTurnosDiaEstado.Name = "dgvTurnosDiaEstado";
            this.dgvTurnosDiaEstado.Width = 107;
            // 
            // grpPaciente
            // 
            this.grpPaciente.Location = new System.Drawing.Point(410, 25);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(475, 120);
            this.grpPaciente.Text = "Paciente";
            this.grpPaciente.Controls.Add(this.lblPaciente);
            this.grpPaciente.Controls.Add(this.txtPaciente);
            this.grpPaciente.Controls.Add(this.lblEdad);
            this.grpPaciente.Controls.Add(this.txtEdad);
            this.grpPaciente.Controls.Add(this.lblObraSocial);
            this.grpPaciente.Controls.Add(this.txtObraSocial);
            this.grpPaciente.TabIndex = 2;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(15, 30);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Text = "Paciente:";
            this.lblPaciente.TabIndex = 3;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(100, 27);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(355, 23);
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.TabIndex = 4;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(15, 68);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Text = "Edad:";
            this.lblEdad.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(100, 65);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(60, 23);
            this.txtEdad.ReadOnly = true;
            this.txtEdad.TabIndex = 6;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(180, 68);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Text = "Obra social:";
            this.lblObraSocial.TabIndex = 7;
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(265, 65);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(190, 23);
            this.txtObraSocial.ReadOnly = true;
            this.txtObraSocial.TabIndex = 8;
            // 
            // lblHistoria
            // 
            this.lblHistoria.AutoSize = true;
            this.lblHistoria.Location = new System.Drawing.Point(410, 155);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Text = "Historia clínica (consultas anteriores):";
            this.lblHistoria.TabIndex = 9;
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.Location = new System.Drawing.Point(410, 175);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.Size = new System.Drawing.Size(475, 107);
            this.dgvHistoria.AllowUserToAddRows = false;
            this.dgvHistoria.AllowUserToDeleteRows = false;
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoria.MultiSelect = false;
            this.dgvHistoria.RowHeadersVisible = false;
            this.dgvHistoria.ReadOnly = true;
            this.dgvHistoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvHistoriaFecha, this.dgvHistoriaMedico, this.dgvHistoriaDiagnostico });
            this.dgvHistoria.TabIndex = 10;
            this.dgvHistoriaFecha.HeaderText = "Fecha";
            this.dgvHistoriaFecha.Name = "dgvHistoriaFecha";
            this.dgvHistoriaFecha.Width = 90;
            this.dgvHistoriaMedico.HeaderText = "Médico";
            this.dgvHistoriaMedico.Name = "dgvHistoriaMedico";
            this.dgvHistoriaMedico.Width = 150;
            this.dgvHistoriaDiagnostico.HeaderText = "Diagnóstico";
            this.dgvHistoriaDiagnostico.Name = "dgvHistoriaDiagnostico";
            this.dgvHistoriaDiagnostico.Width = 232;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Location = new System.Drawing.Point(15, 292);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(870, 175);
            this.grpConsulta.Text = "Consulta actual";
            this.grpConsulta.Controls.Add(this.lblMotivo);
            this.grpConsulta.Controls.Add(this.txtMotivo);
            this.grpConsulta.Controls.Add(this.lblDiagnostico);
            this.grpConsulta.Controls.Add(this.txtDiagnostico);
            this.grpConsulta.Controls.Add(this.lblObservaciones);
            this.grpConsulta.Controls.Add(this.txtObservaciones);
            this.grpConsulta.TabIndex = 11;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(15, 30);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Text = "Motivo:";
            this.lblMotivo.TabIndex = 12;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(110, 27);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(740, 23);
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.TabIndex = 13;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(15, 66);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Text = "Diagnóstico:";
            this.lblDiagnostico.TabIndex = 14;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(110, 63);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(740, 23);
            this.txtDiagnostico.TabIndex = 15;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(15, 102);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Text = "Indicaciones:";
            this.lblObservaciones.TabIndex = 16;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(110, 99);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(740, 60);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.TabIndex = 17;
            // 
            // grpReceta
            // 
            this.grpReceta.Location = new System.Drawing.Point(15, 475);
            this.grpReceta.Name = "grpReceta";
            this.grpReceta.Size = new System.Drawing.Size(870, 185);
            this.grpReceta.Text = "Medicamentos prescriptos";
            this.grpReceta.Controls.Add(this.lblMedicamento);
            this.grpReceta.Controls.Add(this.cmbMedicamento);
            this.grpReceta.Controls.Add(this.lblCantidad);
            this.grpReceta.Controls.Add(this.nudCantidad);
            this.grpReceta.Controls.Add(this.lblPosologia);
            this.grpReceta.Controls.Add(this.txtPosologia);
            this.grpReceta.Controls.Add(this.btnAgregarMedicamento);
            this.grpReceta.Controls.Add(this.dgvMedicamentos);
            this.grpReceta.Controls.Add(this.btnQuitarMedicamento);
            this.grpReceta.TabIndex = 18;
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(15, 32);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Text = "Medicamento:";
            this.lblMedicamento.TabIndex = 19;
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.Location = new System.Drawing.Point(110, 29);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(250, 23);
            this.cmbMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicamento.Items.AddRange(new object[] { "Amoxicilina 500 mg", "Ibuprofeno 400 mg", "Paracetamol 500 mg", "Omeprazol 20 mg", "Loratadina 10 mg" });
            this.cmbMedicamento.TabIndex = 20;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(375, 32);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TabIndex = 21;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(440, 29);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 23);
            this.nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCantidad.TabIndex = 22;
            // 
            // lblPosologia
            // 
            this.lblPosologia.AutoSize = true;
            this.lblPosologia.Location = new System.Drawing.Point(515, 32);
            this.lblPosologia.Name = "lblPosologia";
            this.lblPosologia.Text = "Posología:";
            this.lblPosologia.TabIndex = 23;
            // 
            // txtPosologia
            // 
            this.txtPosologia.Location = new System.Drawing.Point(590, 29);
            this.txtPosologia.Name = "txtPosologia";
            this.txtPosologia.Size = new System.Drawing.Size(160, 23);
            this.txtPosologia.PlaceholderText = "Ej: 1 cada 8 hs";
            this.txtPosologia.TabIndex = 24;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(760, 26);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarMedicamento.Text = "Agregar";
            this.btnAgregarMedicamento.TabIndex = 25;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.Location = new System.Drawing.Point(15, 65);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(735, 105);
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.MultiSelect = false;
            this.dgvMedicamentos.RowHeadersVisible = false;
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvMedicamentosMedicamento, this.dgvMedicamentosCantidad, this.dgvMedicamentosPosologia });
            this.dgvMedicamentos.TabIndex = 26;
            this.dgvMedicamentosMedicamento.HeaderText = "Medicamento";
            this.dgvMedicamentosMedicamento.Name = "dgvMedicamentosMedicamento";
            this.dgvMedicamentosMedicamento.Width = 300;
            this.dgvMedicamentosCantidad.HeaderText = "Cantidad";
            this.dgvMedicamentosCantidad.Name = "dgvMedicamentosCantidad";
            this.dgvMedicamentosCantidad.Width = 100;
            this.dgvMedicamentosPosologia.HeaderText = "Posología";
            this.dgvMedicamentosPosologia.Name = "dgvMedicamentosPosologia";
            this.dgvMedicamentosPosologia.Width = 332;
            // 
            // btnQuitarMedicamento
            // 
            this.btnQuitarMedicamento.Location = new System.Drawing.Point(760, 65);
            this.btnQuitarMedicamento.Name = "btnQuitarMedicamento";
            this.btnQuitarMedicamento.Size = new System.Drawing.Size(90, 30);
            this.btnQuitarMedicamento.Text = "Quitar";
            this.btnQuitarMedicamento.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(664, 674);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Finalizar";
            this.btnAceptar.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(782, 674);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 29;
            // 
            // AtenderPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblTurnosDia);
            this.Controls.Add(this.dgvTurnosDia);
            this.Controls.Add(this.grpPaciente);
            this.Controls.Add(this.lblHistoria);
            this.Controls.Add(this.dgvHistoria);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpReceta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AtenderPacienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención del paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.grpReceta.ResumeLayout(false);
            this.grpReceta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTurnosDia;
        private System.Windows.Forms.DataGridView dgvTurnosDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTurnosDiaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTurnosDiaPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTurnosDiaEstado;
        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.DataGridView dgvHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistoriaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistoriaMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHistoriaDiagnostico;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox grpReceta;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblPosologia;
        private System.Windows.Forms.TextBox txtPosologia;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosPosologia;
        private System.Windows.Forms.Button btnQuitarMedicamento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
