namespace OfiCentral.PedidoMateriales.Formularios.JefeArea
{
    partial class AprobacionSolicitudesFrm
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
            grpFiltros = new GroupBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblSolicitudes = new Label();
            dgvSolicitudes = new DataGridView();
            dgvSolicitudesNroSolicitud = new DataGridViewTextBoxColumn();
            dgvSolicitudesFecha = new DataGridViewTextBoxColumn();
            dgvSolicitudesLegajo = new DataGridViewTextBoxColumn();
            dgvSolicitudesEmpleado = new DataGridViewTextBoxColumn();
            dgvSolicitudesPrioridad = new DataGridViewTextBoxColumn();
            dgvSolicitudesCantItems = new DataGridViewTextBoxColumn();
            dgvSolicitudesEstado = new DataGridViewTextBoxColumn();
            grpDetalle = new GroupBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            dgvDetalle = new DataGridView();
            dgvDetalleMaterial = new DataGridViewTextBoxColumn();
            dgvDetalleCantSolicitada = new DataGridViewTextBoxColumn();
            dgvDetalleCantAprobada = new DataGridViewTextBoxColumn();
            dgvDetalleUnidad = new DataGridViewTextBoxColumn();
            dgvDetalleAprobar = new DataGridViewCheckBoxColumn();
            lblComentario = new Label();
            txtComentario = new TextBox();
            btnAprobar = new Button();
            btnRechazar = new Button();
            btnCerrar = new Button();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(lblEstado);
            grpFiltros.Controls.Add(cmbEstado);
            grpFiltros.Controls.Add(lblDesde);
            grpFiltros.Controls.Add(dtpDesde);
            grpFiltros.Controls.Add(lblHasta);
            grpFiltros.Controls.Add(dtpHasta);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(btnLimpiar);
            grpFiltros.Location = new Point(15, 12);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(830, 70);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(15, 32);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada", "Todas" });
            cmbEstado.Location = new Point(70, 29);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(140, 23);
            cmbEstado.TabIndex = 2;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(230, 32);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 3;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(280, 29);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(120, 23);
            dtpDesde.TabIndex = 4;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(420, 32);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 5;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(470, 29);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(120, 23);
            dtpHasta.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(610, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 30);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(715, 26);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 30);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            // 
            // lblSolicitudes
            // 
            lblSolicitudes.AutoSize = true;
            lblSolicitudes.Location = new Point(15, 92);
            lblSolicitudes.Name = "lblSolicitudes";
            lblSolicitudes.Size = new Size(111, 15);
            lblSolicitudes.TabIndex = 9;
            lblSolicitudes.Text = "Solicitudes del área:";
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { dgvSolicitudesNroSolicitud, dgvSolicitudesFecha, dgvSolicitudesLegajo, dgvSolicitudesEmpleado, dgvSolicitudesPrioridad, dgvSolicitudesCantItems, dgvSolicitudesEstado });
            dgvSolicitudes.Location = new Point(15, 112);
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.Size = new Size(830, 170);
            dgvSolicitudes.TabIndex = 10;
            // 
            // dgvSolicitudesNroSolicitud
            // 
            dgvSolicitudesNroSolicitud.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSolicitudesNroSolicitud.HeaderText = "Nº solicitud";
            dgvSolicitudesNroSolicitud.Name = "dgvSolicitudesNroSolicitud";
            dgvSolicitudesNroSolicitud.ReadOnly = true;
            // 
            // dgvSolicitudesFecha
            // 
            dgvSolicitudesFecha.HeaderText = "Fecha";
            dgvSolicitudesFecha.Name = "dgvSolicitudesFecha";
            dgvSolicitudesFecha.ReadOnly = true;
            // 
            // dgvSolicitudesLegajo
            // 
            dgvSolicitudesLegajo.HeaderText = "Legajo";
            dgvSolicitudesLegajo.Name = "dgvSolicitudesLegajo";
            dgvSolicitudesLegajo.ReadOnly = true;
            dgvSolicitudesLegajo.Width = 80;
            // 
            // dgvSolicitudesEmpleado
            // 
            dgvSolicitudesEmpleado.HeaderText = "Empleado";
            dgvSolicitudesEmpleado.Name = "dgvSolicitudesEmpleado";
            dgvSolicitudesEmpleado.ReadOnly = true;
            dgvSolicitudesEmpleado.Width = 220;
            // 
            // dgvSolicitudesPrioridad
            // 
            dgvSolicitudesPrioridad.HeaderText = "Prioridad";
            dgvSolicitudesPrioridad.Name = "dgvSolicitudesPrioridad";
            dgvSolicitudesPrioridad.ReadOnly = true;
            // 
            // dgvSolicitudesCantItems
            // 
            dgvSolicitudesCantItems.HeaderText = "Cant. ítems";
            dgvSolicitudesCantItems.Name = "dgvSolicitudesCantItems";
            dgvSolicitudesCantItems.ReadOnly = true;
            // 
            // dgvSolicitudesEstado
            // 
            dgvSolicitudesEstado.HeaderText = "Estado";
            dgvSolicitudesEstado.Name = "dgvSolicitudesEstado";
            dgvSolicitudesEstado.ReadOnly = true;
            dgvSolicitudesEstado.Width = 110;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblMotivo);
            grpDetalle.Controls.Add(txtMotivo);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(lblComentario);
            grpDetalle.Controls.Add(txtComentario);
            grpDetalle.Controls.Add(btnAprobar);
            grpDetalle.Controls.Add(btnRechazar);
            grpDetalle.Location = new Point(15, 292);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(830, 330);
            grpDetalle.TabIndex = 11;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de la solicitud seleccionada";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(15, 30);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(48, 15);
            lblMotivo.TabIndex = 12;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(75, 27);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(735, 45);
            txtMotivo.TabIndex = 13;
            txtMotivo.TextChanged += txtMotivo_TextChanged;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { dgvDetalleMaterial, dgvDetalleCantSolicitada, dgvDetalleCantAprobada, dgvDetalleUnidad, dgvDetalleAprobar });
            dgvDetalle.Location = new Point(15, 82);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(800, 140);
            dgvDetalle.TabIndex = 14;
            // 
            // dgvDetalleMaterial
            // 
            dgvDetalleMaterial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalleMaterial.HeaderText = "Material";
            dgvDetalleMaterial.Name = "dgvDetalleMaterial";
            dgvDetalleMaterial.ReadOnly = true;
            // 
            // dgvDetalleCantSolicitada
            // 
            dgvDetalleCantSolicitada.HeaderText = "Cant. solicitada";
            dgvDetalleCantSolicitada.Name = "dgvDetalleCantSolicitada";
            dgvDetalleCantSolicitada.ReadOnly = true;
            dgvDetalleCantSolicitada.Width = 130;
            // 
            // dgvDetalleCantAprobada
            // 
            dgvDetalleCantAprobada.HeaderText = "Cant. aprobada";
            dgvDetalleCantAprobada.Name = "dgvDetalleCantAprobada";
            dgvDetalleCantAprobada.Width = 130;
            // 
            // dgvDetalleUnidad
            // 
            dgvDetalleUnidad.HeaderText = "Unidad";
            dgvDetalleUnidad.Name = "dgvDetalleUnidad";
            dgvDetalleUnidad.ReadOnly = true;
            // 
            // dgvDetalleAprobar
            // 
            dgvDetalleAprobar.HeaderText = "Aprobar ítem";
            dgvDetalleAprobar.Name = "dgvDetalleAprobar";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(15, 232);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(155, 15);
            lblComentario.TabIndex = 15;
            lblComentario.Text = "Comentario del jefe de área:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(15, 252);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.ScrollBars = ScrollBars.Vertical;
            txtComentario.Size = new Size(560, 60);
            txtComentario.TabIndex = 16;
            // 
            // btnAprobar
            // 
            btnAprobar.Location = new Point(600, 270);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(100, 30);
            btnAprobar.TabIndex = 17;
            btnAprobar.Text = "Aprobar";
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(715, 270);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(100, 30);
            btnRechazar.TabIndex = 18;
            btnRechazar.Text = "Rechazar";
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.Location = new Point(742, 634);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            // 
            // FrmAprobacionSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCerrar;
            ClientSize = new Size(860, 680);
            Controls.Add(grpFiltros);
            Controls.Add(lblSolicitudes);
            Controls.Add(dgvSolicitudes);
            Controls.Add(grpDetalle);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmAprobacionSolicitudes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aprobación de solicitudes de materiales";
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSolicitudes;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnCerrar;
        private DataGridViewTextBoxColumn dgvSolicitudesNroSolicitud;
        private DataGridViewTextBoxColumn dgvSolicitudesFecha;
        private DataGridViewTextBoxColumn dgvSolicitudesLegajo;
        private DataGridViewTextBoxColumn dgvSolicitudesEmpleado;
        private DataGridViewTextBoxColumn dgvSolicitudesPrioridad;
        private DataGridViewTextBoxColumn dgvSolicitudesCantItems;
        private DataGridViewTextBoxColumn dgvSolicitudesEstado;
        private DataGridViewTextBoxColumn dgvDetalleMaterial;
        private DataGridViewTextBoxColumn dgvDetalleCantSolicitada;
        private DataGridViewTextBoxColumn dgvDetalleCantAprobada;
        private DataGridViewTextBoxColumn dgvDetalleUnidad;
        private DataGridViewCheckBoxColumn dgvDetalleAprobar;
    }
}
