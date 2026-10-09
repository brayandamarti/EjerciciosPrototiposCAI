namespace OfiCentral.PedidoMateriales.Formularios.Empleado
{
    partial class SolicitudMaterialesFrm
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
            grpSolicitante = new GroupBox();
            lblNroSolicitud = new Label();
            txtNroSolicitud = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            lblLegajo = new Label();
            txtLegajo = new TextBox();
            lblEmpleado = new Label();
            txtEmpleado = new TextBox();
            lblArea = new Label();
            txtArea = new TextBox();
            grpAgregarMaterial = new GroupBox();
            lblMaterial = new Label();
            cmbMaterial = new ComboBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            lblUnidad = new Label();
            txtUnidad = new TextBox();
            btnAgregar = new Button();
            lblMaterialesSolicitados = new Label();
            dgvMateriales = new DataGridView();
            btnModificar = new Button();
            btnQuitar = new Button();
            btnVaciar = new Button();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dgvMaterialesCodigo = new DataGridViewTextBoxColumn();
            dgvMaterialesMaterial = new DataGridViewTextBoxColumn();
            dgvMaterialesCantidad = new DataGridViewTextBoxColumn();
            dgvMaterialesUnidad = new DataGridViewTextBoxColumn();
            dgvMaterialesObservacion = new DataGridViewTextBoxColumn();
            grpSolicitante.SuspendLayout();
            grpAgregarMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // grpSolicitante
            // 
            grpSolicitante.Controls.Add(lblNroSolicitud);
            grpSolicitante.Controls.Add(txtNroSolicitud);
            grpSolicitante.Controls.Add(lblFecha);
            grpSolicitante.Controls.Add(dtpFecha);
            grpSolicitante.Controls.Add(lblPrioridad);
            grpSolicitante.Controls.Add(cmbPrioridad);
            grpSolicitante.Controls.Add(lblLegajo);
            grpSolicitante.Controls.Add(txtLegajo);
            grpSolicitante.Controls.Add(lblEmpleado);
            grpSolicitante.Controls.Add(txtEmpleado);
            grpSolicitante.Controls.Add(lblArea);
            grpSolicitante.Controls.Add(txtArea);
            grpSolicitante.Location = new Point(15, 12);
            grpSolicitante.Name = "grpSolicitante";
            grpSolicitante.Size = new Size(790, 110);
            grpSolicitante.TabIndex = 0;
            grpSolicitante.TabStop = false;
            grpSolicitante.Text = "Datos de la solicitud";
            // 
            // lblNroSolicitud
            // 
            lblNroSolicitud.AutoSize = true;
            lblNroSolicitud.Location = new Point(15, 30);
            lblNroSolicitud.Name = "lblNroSolicitud";
            lblNroSolicitud.Size = new Size(88, 15);
            lblNroSolicitud.TabIndex = 1;
            lblNroSolicitud.Text = "Nº de solicitud:";
            // 
            // txtNroSolicitud
            // 
            txtNroSolicitud.Location = new Point(130, 27);
            txtNroSolicitud.Name = "txtNroSolicitud";
            txtNroSolicitud.ReadOnly = true;
            txtNroSolicitud.Size = new Size(120, 23);
            txtNroSolicitud.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(280, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(340, 27);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(130, 23);
            dtpFecha.TabIndex = 4;
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(500, 30);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(58, 15);
            lblPrioridad.TabIndex = 5;
            lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.Items.AddRange(new object[] { "Baja", "Normal", "Urgente" });
            cmbPrioridad.Location = new Point(580, 27);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(190, 23);
            cmbPrioridad.TabIndex = 6;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(15, 68);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(45, 15);
            lblLegajo.TabIndex = 7;
            lblLegajo.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(130, 65);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(120, 23);
            txtLegajo.TabIndex = 8;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(280, 68);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(63, 15);
            lblEmpleado.TabIndex = 9;
            lblEmpleado.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(340, 65);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.ReadOnly = true;
            txtEmpleado.Size = new Size(150, 23);
            txtEmpleado.TabIndex = 10;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(500, 68);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(34, 15);
            lblArea.TabIndex = 11;
            lblArea.Text = "Área:";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(580, 65);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(190, 23);
            txtArea.TabIndex = 12;
            // 
            // grpAgregarMaterial
            // 
            grpAgregarMaterial.Controls.Add(lblMaterial);
            grpAgregarMaterial.Controls.Add(cmbMaterial);
            grpAgregarMaterial.Controls.Add(lblCantidad);
            grpAgregarMaterial.Controls.Add(nudCantidad);
            grpAgregarMaterial.Controls.Add(lblUnidad);
            grpAgregarMaterial.Controls.Add(txtUnidad);
            grpAgregarMaterial.Controls.Add(btnAgregar);
            grpAgregarMaterial.Location = new Point(15, 130);
            grpAgregarMaterial.Name = "grpAgregarMaterial";
            grpAgregarMaterial.Size = new Size(790, 75);
            grpAgregarMaterial.TabIndex = 13;
            grpAgregarMaterial.TabStop = false;
            grpAgregarMaterial.Text = "Agregar material";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(15, 33);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(53, 15);
            lblMaterial.TabIndex = 14;
            lblMaterial.Text = "Material:";
            // 
            // cmbMaterial
            // 
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.Items.AddRange(new object[] { "Birome azul", "Birome negra", "Lápiz negro HB", "Cuaderno A4 rayado", "Resma A4 75 g", "Tijera", "Abrochadora", "Caja de broches", "Resaltador", "Carpeta oficio" });
            cmbMaterial.Location = new Point(85, 30);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(250, 23);
            cmbMaterial.TabIndex = 15;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(350, 33);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(420, 30);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(70, 23);
            nudCantidad.TabIndex = 17;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(505, 33);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(48, 15);
            lblUnidad.TabIndex = 18;
            lblUnidad.Text = "Unidad:";
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(560, 30);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.ReadOnly = true;
            txtUnidad.Size = new Size(90, 23);
            txtUnidad.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(670, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            // 
            // lblMaterialesSolicitados
            // 
            lblMaterialesSolicitados.AutoSize = true;
            lblMaterialesSolicitados.Location = new Point(15, 215);
            lblMaterialesSolicitados.Name = "lblMaterialesSolicitados";
            lblMaterialesSolicitados.Size = new Size(123, 15);
            lblMaterialesSolicitados.TabIndex = 21;
            lblMaterialesSolicitados.Text = "Materiales solicitados:";
            // 
            // dgvMateriales
            // 
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.AllowUserToDeleteRows = false;
            dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriales.Columns.AddRange(new DataGridViewColumn[] { dgvMaterialesCodigo, dgvMaterialesMaterial, dgvMaterialesCantidad, dgvMaterialesUnidad, dgvMaterialesObservacion });
            dgvMateriales.Location = new Point(15, 235);
            dgvMateriales.MultiSelect = false;
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.RowHeadersVisible = false;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.Size = new Size(670, 220);
            dgvMateriales.TabIndex = 22;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(700, 235);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 30);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(700, 273);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(105, 30);
            btnQuitar.TabIndex = 24;
            btnQuitar.Text = "Quitar";
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(700, 311);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(105, 30);
            btnVaciar.TabIndex = 25;
            btnVaciar.Text = "Vaciar lista";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(15, 468);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(124, 15);
            lblMotivo.TabIndex = 26;
            lblMotivo.Text = "Motivo de la solicitud:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(15, 488);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(790, 80);
            txtMotivo.TabIndex = 27;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(584, 594);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 30);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Enviar";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(702, 594);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            // 
            // dgvMaterialesCodigo
            // 
            dgvMaterialesCodigo.HeaderText = "Código";
            dgvMaterialesCodigo.Name = "dgvMaterialesCodigo";
            dgvMaterialesCodigo.ReadOnly = true;
            dgvMaterialesCodigo.Width = 90;
            // 
            // dgvMaterialesMaterial
            // 
            dgvMaterialesMaterial.HeaderText = "Material";
            dgvMaterialesMaterial.Name = "dgvMaterialesMaterial";
            dgvMaterialesMaterial.ReadOnly = true;
            dgvMaterialesMaterial.Width = 280;
            // 
            // dgvMaterialesCantidad
            // 
            dgvMaterialesCantidad.HeaderText = "Cantidad";
            dgvMaterialesCantidad.Name = "dgvMaterialesCantidad";
            // 
            // dgvMaterialesUnidad
            // 
            dgvMaterialesUnidad.HeaderText = "Unidad";
            dgvMaterialesUnidad.Name = "dgvMaterialesUnidad";
            dgvMaterialesUnidad.ReadOnly = true;
            dgvMaterialesUnidad.Width = 90;
            // 
            // dgvMaterialesObservacion
            // 
            dgvMaterialesObservacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterialesObservacion.HeaderText = "Observación";
            dgvMaterialesObservacion.Name = "dgvMaterialesObservacion";
            // 
            // FrmSolicitudMateriales
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(820, 640);
            Controls.Add(grpSolicitante);
            Controls.Add(grpAgregarMaterial);
            Controls.Add(lblMaterialesSolicitados);
            Controls.Add(dgvMateriales);
            Controls.Add(btnModificar);
            Controls.Add(btnQuitar);
            Controls.Add(btnVaciar);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmSolicitudMateriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva solicitud de materiales";
            grpSolicitante.ResumeLayout(false);
            grpSolicitante.PerformLayout();
            grpAgregarMaterial.ResumeLayout(false);
            grpAgregarMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DataGridViewTextBoxColumn dgvMaterialesCodigo;
        private DataGridViewTextBoxColumn dgvMaterialesMaterial;
        private DataGridViewTextBoxColumn dgvMaterialesCantidad;
        private DataGridViewTextBoxColumn dgvMaterialesUnidad;
        private DataGridViewTextBoxColumn dgvMaterialesObservacion;
    }
}
