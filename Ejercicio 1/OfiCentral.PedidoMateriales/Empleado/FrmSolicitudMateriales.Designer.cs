namespace OfiCentral.PedidoMateriales.Formularios.Empleado
{
    partial class FrmSolicitudMateriales
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
            this.grpSolicitante = new System.Windows.Forms.GroupBox();
            this.lblNroSolicitud = new System.Windows.Forms.Label();
            this.txtNroSolicitud = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.grpAgregarMaterial = new System.Windows.Forms.GroupBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMaterialesSolicitados = new System.Windows.Forms.Label();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.dgvMaterialesCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaterialesMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaterialesCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaterialesUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaterialesObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpSolicitante.SuspendLayout();
            this.grpAgregarMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSolicitante
            // 
            this.grpSolicitante.Location = new System.Drawing.Point(15, 12);
            this.grpSolicitante.Name = "grpSolicitante";
            this.grpSolicitante.Size = new System.Drawing.Size(790, 110);
            this.grpSolicitante.Text = "Datos de la solicitud";
            this.grpSolicitante.Controls.Add(this.lblNroSolicitud);
            this.grpSolicitante.Controls.Add(this.txtNroSolicitud);
            this.grpSolicitante.Controls.Add(this.lblFecha);
            this.grpSolicitante.Controls.Add(this.dtpFecha);
            this.grpSolicitante.Controls.Add(this.lblPrioridad);
            this.grpSolicitante.Controls.Add(this.cmbPrioridad);
            this.grpSolicitante.Controls.Add(this.lblLegajo);
            this.grpSolicitante.Controls.Add(this.txtLegajo);
            this.grpSolicitante.Controls.Add(this.lblEmpleado);
            this.grpSolicitante.Controls.Add(this.txtEmpleado);
            this.grpSolicitante.Controls.Add(this.lblArea);
            this.grpSolicitante.Controls.Add(this.txtArea);
            this.grpSolicitante.TabIndex = 0;
            // 
            // lblNroSolicitud
            // 
            this.lblNroSolicitud.AutoSize = true;
            this.lblNroSolicitud.Location = new System.Drawing.Point(15, 30);
            this.lblNroSolicitud.Name = "lblNroSolicitud";
            this.lblNroSolicitud.Text = "Nº de solicitud:";
            this.lblNroSolicitud.TabIndex = 1;
            // 
            // txtNroSolicitud
            // 
            this.txtNroSolicitud.Location = new System.Drawing.Point(130, 27);
            this.txtNroSolicitud.Name = "txtNroSolicitud";
            this.txtNroSolicitud.Size = new System.Drawing.Size(120, 23);
            this.txtNroSolicitud.ReadOnly = true;
            this.txtNroSolicitud.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(280, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(340, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 23);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.TabIndex = 4;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(500, 30);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Text = "Prioridad:";
            this.lblPrioridad.TabIndex = 5;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Location = new System.Drawing.Point(580, 27);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(190, 23);
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Items.AddRange(new object[] { "Baja", "Normal", "Urgente" });
            this.cmbPrioridad.TabIndex = 6;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(15, 68);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Text = "Legajo:";
            this.lblLegajo.TabIndex = 7;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(130, 65);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(120, 23);
            this.txtLegajo.TabIndex = 8;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(280, 68);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TabIndex = 9;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(340, 65);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(150, 23);
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.TabIndex = 10;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(500, 68);
            this.lblArea.Name = "lblArea";
            this.lblArea.Text = "Área:";
            this.lblArea.TabIndex = 11;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(580, 65);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(190, 23);
            this.txtArea.ReadOnly = true;
            this.txtArea.TabIndex = 12;
            // 
            // grpAgregarMaterial
            // 
            this.grpAgregarMaterial.Location = new System.Drawing.Point(15, 130);
            this.grpAgregarMaterial.Name = "grpAgregarMaterial";
            this.grpAgregarMaterial.Size = new System.Drawing.Size(790, 75);
            this.grpAgregarMaterial.Text = "Agregar material";
            this.grpAgregarMaterial.Controls.Add(this.lblMaterial);
            this.grpAgregarMaterial.Controls.Add(this.cmbMaterial);
            this.grpAgregarMaterial.Controls.Add(this.lblCantidad);
            this.grpAgregarMaterial.Controls.Add(this.nudCantidad);
            this.grpAgregarMaterial.Controls.Add(this.lblUnidad);
            this.grpAgregarMaterial.Controls.Add(this.txtUnidad);
            this.grpAgregarMaterial.Controls.Add(this.btnAgregar);
            this.grpAgregarMaterial.TabIndex = 13;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(15, 33);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Text = "Material:";
            this.lblMaterial.TabIndex = 14;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Location = new System.Drawing.Point(85, 30);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(250, 23);
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Items.AddRange(new object[] { "Birome azul", "Birome negra", "Lápiz negro HB", "Cuaderno A4 rayado", "Resma A4 75 g", "Tijera", "Abrochadora", "Caja de broches", "Resaltador", "Carpeta oficio" });
            this.cmbMaterial.TabIndex = 15;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(350, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TabIndex = 16;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(420, 30);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(70, 23);
            this.nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCantidad.TabIndex = 17;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(505, 33);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Text = "Unidad:";
            this.lblUnidad.TabIndex = 18;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(560, 30);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(90, 23);
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(670, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TabIndex = 20;
            // 
            // lblMaterialesSolicitados
            // 
            this.lblMaterialesSolicitados.AutoSize = true;
            this.lblMaterialesSolicitados.Location = new System.Drawing.Point(15, 215);
            this.lblMaterialesSolicitados.Name = "lblMaterialesSolicitados";
            this.lblMaterialesSolicitados.Text = "Materiales solicitados:";
            this.lblMaterialesSolicitados.TabIndex = 21;
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.Location = new System.Drawing.Point(15, 235);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.Size = new System.Drawing.Size(670, 220);
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvMaterialesCodigo, this.dgvMaterialesMaterial, this.dgvMaterialesCantidad, this.dgvMaterialesUnidad, this.dgvMaterialesObservacion });
            this.dgvMateriales.TabIndex = 22;
            this.dgvMaterialesCodigo.HeaderText = "Código";
            this.dgvMaterialesCodigo.Name = "dgvMaterialesCodigo";
            this.dgvMaterialesCodigo.Width = 90;
            this.dgvMaterialesCodigo.ReadOnly = true;
            this.dgvMaterialesMaterial.HeaderText = "Material";
            this.dgvMaterialesMaterial.Name = "dgvMaterialesMaterial";
            this.dgvMaterialesMaterial.Width = 280;
            this.dgvMaterialesMaterial.ReadOnly = true;
            this.dgvMaterialesCantidad.HeaderText = "Cantidad";
            this.dgvMaterialesCantidad.Name = "dgvMaterialesCantidad";
            this.dgvMaterialesCantidad.Width = 100;
            this.dgvMaterialesUnidad.HeaderText = "Unidad";
            this.dgvMaterialesUnidad.Name = "dgvMaterialesUnidad";
            this.dgvMaterialesUnidad.Width = 90;
            this.dgvMaterialesUnidad.ReadOnly = true;
            this.dgvMaterialesObservacion.HeaderText = "Observación";
            this.dgvMaterialesObservacion.Name = "dgvMaterialesObservacion";
            this.dgvMaterialesObservacion.Width = 105;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(700, 235);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 30);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TabIndex = 23;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(700, 273);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(105, 30);
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TabIndex = 24;
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(700, 311);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(105, 30);
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.TabIndex = 25;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(15, 468);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Text = "Motivo de la solicitud:";
            this.lblMotivo.TabIndex = 26;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(15, 488);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(790, 80);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(584, 594);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Enviar";
            this.btnAceptar.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(702, 594);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 29;
            // 
            // FrmSolicitudMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpSolicitante);
            this.Controls.Add(this.grpAgregarMaterial);
            this.Controls.Add(this.lblMaterialesSolicitados);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSolicitudMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva solicitud de materiales";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.grpSolicitante.ResumeLayout(false);
            this.grpSolicitante.PerformLayout();
            this.grpAgregarMaterial.ResumeLayout(false);
            this.grpAgregarMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSolicitante;
        private System.Windows.Forms.Label lblNroSolicitud;
        private System.Windows.Forms.TextBox txtNroSolicitud;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.GroupBox grpAgregarMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMaterialesSolicitados;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaterialesCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaterialesMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaterialesCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaterialesUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaterialesObservacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
