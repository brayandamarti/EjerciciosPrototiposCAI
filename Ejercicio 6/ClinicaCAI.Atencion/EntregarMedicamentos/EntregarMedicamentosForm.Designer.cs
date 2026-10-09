namespace ClinicaCAI.Atencion.EntregarMedicamentos
{
    partial class EntregarMedicamentosForm
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
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNroReceta = new System.Windows.Forms.Label();
            this.txtNroReceta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.lblMedicamentos = new System.Windows.Forms.Label();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.dgvMedicamentosMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosPosologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosCantPrescripta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosCantEntregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedicamentosEntregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblRetira = new System.Windows.Forms.Label();
            this.cmbRetira = new System.Windows.Forms.ComboBox();
            this.lblDniRetira = new System.Windows.Forms.Label();
            this.txtDniRetira = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBuscar.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Location = new System.Drawing.Point(15, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(790, 110);
            this.grpBuscar.Text = "Buscar receta";
            this.grpBuscar.Controls.Add(this.lblDni);
            this.grpBuscar.Controls.Add(this.txtDni);
            this.grpBuscar.Controls.Add(this.lblNroReceta);
            this.grpBuscar.Controls.Add(this.txtNroReceta);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.lblPaciente);
            this.grpBuscar.Controls.Add(this.txtPaciente);
            this.grpBuscar.Controls.Add(this.lblMedico);
            this.grpBuscar.Controls.Add(this.txtMedico);
            this.grpBuscar.TabIndex = 0;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(15, 32);
            this.lblDni.Name = "lblDni";
            this.lblDni.Text = "DNI paciente:";
            this.lblDni.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(110, 29);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(140, 23);
            this.txtDni.TabIndex = 2;
            // 
            // lblNroReceta
            // 
            this.lblNroReceta.AutoSize = true;
            this.lblNroReceta.Location = new System.Drawing.Point(270, 32);
            this.lblNroReceta.Name = "lblNroReceta";
            this.lblNroReceta.Text = "Nº receta:";
            this.lblNroReceta.TabIndex = 3;
            // 
            // txtNroReceta
            // 
            this.txtNroReceta.Location = new System.Drawing.Point(345, 29);
            this.txtNroReceta.Name = "txtNroReceta";
            this.txtNroReceta.Size = new System.Drawing.Size(120, 23);
            this.txtNroReceta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(480, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 5;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(15, 72);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Text = "Paciente:";
            this.lblPaciente.TabIndex = 6;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(110, 69);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(300, 23);
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.TabIndex = 7;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(425, 72);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Text = "Médico:";
            this.lblMedico.TabIndex = 8;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(485, 69);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(285, 23);
            this.txtMedico.ReadOnly = true;
            this.txtMedico.TabIndex = 9;
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.Location = new System.Drawing.Point(15, 132);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Text = "Medicamentos prescriptos:";
            this.lblMedicamentos.TabIndex = 10;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.Location = new System.Drawing.Point(15, 152);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(790, 220);
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.MultiSelect = false;
            this.dgvMedicamentos.RowHeadersVisible = false;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvMedicamentosMedicamento, this.dgvMedicamentosPosologia, this.dgvMedicamentosCantPrescripta, this.dgvMedicamentosStock, this.dgvMedicamentosCantEntregada, this.dgvMedicamentosEntregar });
            this.dgvMedicamentos.TabIndex = 11;
            this.dgvMedicamentosMedicamento.HeaderText = "Medicamento";
            this.dgvMedicamentosMedicamento.Name = "dgvMedicamentosMedicamento";
            this.dgvMedicamentosMedicamento.Width = 230;
            this.dgvMedicamentosMedicamento.ReadOnly = true;
            this.dgvMedicamentosPosologia.HeaderText = "Posología";
            this.dgvMedicamentosPosologia.Name = "dgvMedicamentosPosologia";
            this.dgvMedicamentosPosologia.Width = 180;
            this.dgvMedicamentosPosologia.ReadOnly = true;
            this.dgvMedicamentosCantPrescripta.HeaderText = "Cant. prescripta";
            this.dgvMedicamentosCantPrescripta.Name = "dgvMedicamentosCantPrescripta";
            this.dgvMedicamentosCantPrescripta.Width = 110;
            this.dgvMedicamentosCantPrescripta.ReadOnly = true;
            this.dgvMedicamentosStock.HeaderText = "Stock";
            this.dgvMedicamentosStock.Name = "dgvMedicamentosStock";
            this.dgvMedicamentosStock.Width = 80;
            this.dgvMedicamentosStock.ReadOnly = true;
            this.dgvMedicamentosCantEntregada.HeaderText = "Cant. a entregar";
            this.dgvMedicamentosCantEntregada.Name = "dgvMedicamentosCantEntregada";
            this.dgvMedicamentosCantEntregada.Width = 110;
            this.dgvMedicamentosEntregar.HeaderText = "Entregar";
            this.dgvMedicamentosEntregar.Name = "dgvMedicamentosEntregar";
            this.dgvMedicamentosEntregar.Width = 77;
            // 
            // grpEntrega
            // 
            this.grpEntrega.Location = new System.Drawing.Point(15, 382);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Size = new System.Drawing.Size(790, 150);
            this.grpEntrega.Text = "Datos de la entrega";
            this.grpEntrega.Controls.Add(this.lblFechaEntrega);
            this.grpEntrega.Controls.Add(this.dtpFechaEntrega);
            this.grpEntrega.Controls.Add(this.lblRetira);
            this.grpEntrega.Controls.Add(this.cmbRetira);
            this.grpEntrega.Controls.Add(this.lblDniRetira);
            this.grpEntrega.Controls.Add(this.txtDniRetira);
            this.grpEntrega.Controls.Add(this.lblObservaciones);
            this.grpEntrega.Controls.Add(this.txtObservaciones);
            this.grpEntrega.TabIndex = 12;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(15, 32);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Text = "Fecha:";
            this.lblFechaEntrega.TabIndex = 13;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(70, 29);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(130, 23);
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.TabIndex = 14;
            // 
            // lblRetira
            // 
            this.lblRetira.AutoSize = true;
            this.lblRetira.Location = new System.Drawing.Point(220, 32);
            this.lblRetira.Name = "lblRetira";
            this.lblRetira.Text = "Retira:";
            this.lblRetira.TabIndex = 15;
            // 
            // cmbRetira
            // 
            this.cmbRetira.Location = new System.Drawing.Point(275, 29);
            this.cmbRetira.Name = "cmbRetira";
            this.cmbRetira.Size = new System.Drawing.Size(200, 23);
            this.cmbRetira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetira.Items.AddRange(new object[] { "El paciente", "Familiar / tercero" });
            this.cmbRetira.TabIndex = 16;
            // 
            // lblDniRetira
            // 
            this.lblDniRetira.AutoSize = true;
            this.lblDniRetira.Location = new System.Drawing.Point(495, 32);
            this.lblDniRetira.Name = "lblDniRetira";
            this.lblDniRetira.Text = "DNI de quien retira:";
            this.lblDniRetira.TabIndex = 17;
            // 
            // txtDniRetira
            // 
            this.txtDniRetira.Location = new System.Drawing.Point(620, 29);
            this.txtDniRetira.Name = "txtDniRetira";
            this.txtDniRetira.Size = new System.Drawing.Size(150, 23);
            this.txtDniRetira.TabIndex = 18;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(15, 68);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.TabIndex = 19;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 88);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(755, 48);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.TabIndex = 20;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(584, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Entregar";
            this.btnAceptar.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(702, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 22;
            // 
            // EntregarMedicamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.lblMedicamentos);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.grpEntrega);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EntregarMedicamentosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega de medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNroReceta;
        private System.Windows.Forms.TextBox txtNroReceta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label lblMedicamentos;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosPosologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosCantPrescripta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMedicamentosCantEntregada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvMedicamentosEntregar;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblRetira;
        private System.Windows.Forms.ComboBox cmbRetira;
        private System.Windows.Forms.Label lblDniRetira;
        private System.Windows.Forms.TextBox txtDniRetira;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
