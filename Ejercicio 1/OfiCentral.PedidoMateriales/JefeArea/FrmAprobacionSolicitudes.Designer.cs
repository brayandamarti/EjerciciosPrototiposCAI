namespace OfiCentral.PedidoMateriales.Formularios.JefeArea
{
    partial class FrmAprobacionSolicitudes
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSolicitudes = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.dgvSolicitudesNroSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesCantItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.dgvDetalleMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleCantSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleCantAprobada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleAprobar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Location = new System.Drawing.Point(15, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(830, 70);
            this.grpFiltros.Text = "Filtros";
            this.grpFiltros.Controls.Add(this.lblEstado);
            this.grpFiltros.Controls.Add(this.cmbEstado);
            this.grpFiltros.Controls.Add(this.lblDesde);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.lblHasta);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.btnLimpiar);
            this.grpFiltros.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(15, 32);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(70, 29);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(140, 23);
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada", "Todas" });
            this.cmbEstado.TabIndex = 2;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(230, 32);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(280, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 23);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(420, 32);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TabIndex = 5;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(470, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 23);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(610, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(715, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TabIndex = 8;
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Location = new System.Drawing.Point(15, 92);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Text = "Solicitudes del área:";
            this.lblSolicitudes.TabIndex = 9;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.Location = new System.Drawing.Point(15, 112);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(830, 170);
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvSolicitudesNroSolicitud, this.dgvSolicitudesFecha, this.dgvSolicitudesLegajo, this.dgvSolicitudesEmpleado, this.dgvSolicitudesPrioridad, this.dgvSolicitudesCantItems, this.dgvSolicitudesEstado });
            this.dgvSolicitudes.TabIndex = 10;
            this.dgvSolicitudesNroSolicitud.HeaderText = "Nº solicitud";
            this.dgvSolicitudesNroSolicitud.Name = "dgvSolicitudesNroSolicitud";
            this.dgvSolicitudesNroSolicitud.Width = 100;
            this.dgvSolicitudesFecha.HeaderText = "Fecha";
            this.dgvSolicitudesFecha.Name = "dgvSolicitudesFecha";
            this.dgvSolicitudesFecha.Width = 100;
            this.dgvSolicitudesLegajo.HeaderText = "Legajo";
            this.dgvSolicitudesLegajo.Name = "dgvSolicitudesLegajo";
            this.dgvSolicitudesLegajo.Width = 80;
            this.dgvSolicitudesEmpleado.HeaderText = "Empleado";
            this.dgvSolicitudesEmpleado.Name = "dgvSolicitudesEmpleado";
            this.dgvSolicitudesEmpleado.Width = 220;
            this.dgvSolicitudesPrioridad.HeaderText = "Prioridad";
            this.dgvSolicitudesPrioridad.Name = "dgvSolicitudesPrioridad";
            this.dgvSolicitudesPrioridad.Width = 100;
            this.dgvSolicitudesCantItems.HeaderText = "Cant. ítems";
            this.dgvSolicitudesCantItems.Name = "dgvSolicitudesCantItems";
            this.dgvSolicitudesCantItems.Width = 100;
            this.dgvSolicitudesEstado.HeaderText = "Estado";
            this.dgvSolicitudesEstado.Name = "dgvSolicitudesEstado";
            this.dgvSolicitudesEstado.Width = 110;
            // 
            // grpDetalle
            // 
            this.grpDetalle.Location = new System.Drawing.Point(15, 292);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(830, 330);
            this.grpDetalle.Text = "Detalle de la solicitud seleccionada";
            this.grpDetalle.Controls.Add(this.lblMotivo);
            this.grpDetalle.Controls.Add(this.txtMotivo);
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Controls.Add(this.lblComentario);
            this.grpDetalle.Controls.Add(this.txtComentario);
            this.grpDetalle.Controls.Add(this.btnAprobar);
            this.grpDetalle.Controls.Add(this.btnRechazar);
            this.grpDetalle.TabIndex = 11;
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
            this.txtMotivo.Location = new System.Drawing.Point(80, 27);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(735, 45);
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivo.TabIndex = 13;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(15, 82);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(800, 140);
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvDetalleMaterial, this.dgvDetalleCantSolicitada, this.dgvDetalleCantAprobada, this.dgvDetalleUnidad, this.dgvDetalleAprobar });
            this.dgvDetalle.TabIndex = 14;
            this.dgvDetalleMaterial.HeaderText = "Material";
            this.dgvDetalleMaterial.Name = "dgvDetalleMaterial";
            this.dgvDetalleMaterial.Width = 300;
            this.dgvDetalleMaterial.ReadOnly = true;
            this.dgvDetalleCantSolicitada.HeaderText = "Cant. solicitada";
            this.dgvDetalleCantSolicitada.Name = "dgvDetalleCantSolicitada";
            this.dgvDetalleCantSolicitada.Width = 130;
            this.dgvDetalleCantSolicitada.ReadOnly = true;
            this.dgvDetalleCantAprobada.HeaderText = "Cant. aprobada";
            this.dgvDetalleCantAprobada.Name = "dgvDetalleCantAprobada";
            this.dgvDetalleCantAprobada.Width = 130;
            this.dgvDetalleUnidad.HeaderText = "Unidad";
            this.dgvDetalleUnidad.Name = "dgvDetalleUnidad";
            this.dgvDetalleUnidad.Width = 100;
            this.dgvDetalleUnidad.ReadOnly = true;
            this.dgvDetalleAprobar.HeaderText = "Aprobar ítem";
            this.dgvDetalleAprobar.Name = "dgvDetalleAprobar";
            this.dgvDetalleAprobar.Width = 100;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(15, 232);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Text = "Comentario del jefe de área:";
            this.lblComentario.TabIndex = 15;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(15, 252);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(560, 60);
            this.txtComentario.Multiline = true;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.TabIndex = 16;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(600, 270);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(100, 30);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TabIndex = 17;
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(715, 270);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(100, 30);
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.TabIndex = 18;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(742, 634);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.TabIndex = 19;
            // 
            // FrmAprobacionSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 680);
            this.CancelButton = this.btnCerrar;
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.lblSolicitudes);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmAprobacionSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobación de solicitudes de materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesNroSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesCantItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesEstado;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleCantSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleCantAprobada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleUnidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvDetalleAprobar;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
