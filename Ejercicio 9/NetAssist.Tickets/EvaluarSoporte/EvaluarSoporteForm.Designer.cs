namespace NetAssist.Tickets.EvaluarSoporte
{
    partial class EvaluarSoporteForm
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
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpIndicadores = new System.Windows.Forms.GroupBox();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.txtTotalTickets = new System.Windows.Forms.TextBox();
            this.lblTicketsCerrados = new System.Windows.Forms.Label();
            this.txtTicketsCerrados = new System.Windows.Forms.TextBox();
            this.lblFueraDePlazo = new System.Windows.Forms.Label();
            this.txtFueraDePlazo = new System.Windows.Forms.TextBox();
            this.lblTiempoRespuesta = new System.Windows.Forms.Label();
            this.txtTiempoRespuesta = new System.Windows.Forms.TextBox();
            this.lblTiempoResolucion = new System.Windows.Forms.Label();
            this.txtTiempoResolucion = new System.Windows.Forms.TextBox();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.txtSatisfaccion = new System.Windows.Forms.TextBox();
            this.lblPorTecnico = new System.Windows.Forms.Label();
            this.dgvPorTecnico = new System.Windows.Forms.DataGridView();
            this.dgvPorTecnicoTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPorTecnicoAsignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPorTecnicoCerrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPorTecnicoTiempoRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPorTecnicoTiempoResolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPorTecnicoSatisfaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dgvDetalleTickets = new System.Windows.Forms.DataGridView();
            this.dgvDetalleTicketsNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsTiempoRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsTiempoResolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleTicketsEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            this.grpIndicadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorTecnico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Location = new System.Drawing.Point(15, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(850, 70);
            this.grpFiltros.Text = "Período a evaluar";
            this.grpFiltros.Controls.Add(this.lblDesde);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.lblHasta);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.lblTecnico);
            this.grpFiltros.Controls.Add(this.cmbTecnico);
            this.grpFiltros.Controls.Add(this.btnConsultar);
            this.grpFiltros.TabIndex = 0;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(15, 32);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(65, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 23);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(205, 32);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(255, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 23);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.TabIndex = 4;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(395, 32);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Text = "Técnico:";
            this.lblTecnico.TabIndex = 5;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.Location = new System.Drawing.Point(455, 29);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(180, 23);
            this.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnico.Items.AddRange(new object[] { "Todos", "Fernández, Lucas", "Méndez, Sofía", "Torres, Diego" });
            this.cmbTecnico.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(725, 26);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 30);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TabIndex = 7;
            // 
            // grpIndicadores
            // 
            this.grpIndicadores.Location = new System.Drawing.Point(15, 90);
            this.grpIndicadores.Name = "grpIndicadores";
            this.grpIndicadores.Size = new System.Drawing.Size(850, 110);
            this.grpIndicadores.Text = "Indicadores del período";
            this.grpIndicadores.Controls.Add(this.lblTotalTickets);
            this.grpIndicadores.Controls.Add(this.txtTotalTickets);
            this.grpIndicadores.Controls.Add(this.lblTicketsCerrados);
            this.grpIndicadores.Controls.Add(this.txtTicketsCerrados);
            this.grpIndicadores.Controls.Add(this.lblFueraDePlazo);
            this.grpIndicadores.Controls.Add(this.txtFueraDePlazo);
            this.grpIndicadores.Controls.Add(this.lblTiempoRespuesta);
            this.grpIndicadores.Controls.Add(this.txtTiempoRespuesta);
            this.grpIndicadores.Controls.Add(this.lblTiempoResolucion);
            this.grpIndicadores.Controls.Add(this.txtTiempoResolucion);
            this.grpIndicadores.Controls.Add(this.lblSatisfaccion);
            this.grpIndicadores.Controls.Add(this.txtSatisfaccion);
            this.grpIndicadores.TabIndex = 8;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Location = new System.Drawing.Point(15, 32);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Text = "Tickets recibidos:";
            this.lblTotalTickets.TabIndex = 9;
            // 
            // txtTotalTickets
            // 
            this.txtTotalTickets.Location = new System.Drawing.Point(175, 29);
            this.txtTotalTickets.Name = "txtTotalTickets";
            this.txtTotalTickets.Size = new System.Drawing.Size(90, 23);
            this.txtTotalTickets.ReadOnly = true;
            this.txtTotalTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalTickets.TabIndex = 10;
            // 
            // lblTicketsCerrados
            // 
            this.lblTicketsCerrados.AutoSize = true;
            this.lblTicketsCerrados.Location = new System.Drawing.Point(300, 32);
            this.lblTicketsCerrados.Name = "lblTicketsCerrados";
            this.lblTicketsCerrados.Text = "Tickets cerrados:";
            this.lblTicketsCerrados.TabIndex = 11;
            // 
            // txtTicketsCerrados
            // 
            this.txtTicketsCerrados.Location = new System.Drawing.Point(440, 29);
            this.txtTicketsCerrados.Name = "txtTicketsCerrados";
            this.txtTicketsCerrados.Size = new System.Drawing.Size(90, 23);
            this.txtTicketsCerrados.ReadOnly = true;
            this.txtTicketsCerrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTicketsCerrados.TabIndex = 12;
            // 
            // lblFueraDePlazo
            // 
            this.lblFueraDePlazo.AutoSize = true;
            this.lblFueraDePlazo.Location = new System.Drawing.Point(565, 32);
            this.lblFueraDePlazo.Name = "lblFueraDePlazo";
            this.lblFueraDePlazo.Text = "Cerrados fuera de plazo:";
            this.lblFueraDePlazo.TabIndex = 13;
            // 
            // txtFueraDePlazo
            // 
            this.txtFueraDePlazo.Location = new System.Drawing.Point(745, 29);
            this.txtFueraDePlazo.Name = "txtFueraDePlazo";
            this.txtFueraDePlazo.Size = new System.Drawing.Size(90, 23);
            this.txtFueraDePlazo.ReadOnly = true;
            this.txtFueraDePlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFueraDePlazo.TabIndex = 14;
            // 
            // lblTiempoRespuesta
            // 
            this.lblTiempoRespuesta.AutoSize = true;
            this.lblTiempoRespuesta.Location = new System.Drawing.Point(15, 70);
            this.lblTiempoRespuesta.Name = "lblTiempoRespuesta";
            this.lblTiempoRespuesta.Text = "Respuesta prom. (h):";
            this.lblTiempoRespuesta.TabIndex = 15;
            // 
            // txtTiempoRespuesta
            // 
            this.txtTiempoRespuesta.Location = new System.Drawing.Point(175, 67);
            this.txtTiempoRespuesta.Name = "txtTiempoRespuesta";
            this.txtTiempoRespuesta.Size = new System.Drawing.Size(90, 23);
            this.txtTiempoRespuesta.ReadOnly = true;
            this.txtTiempoRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTiempoRespuesta.TabIndex = 16;
            // 
            // lblTiempoResolucion
            // 
            this.lblTiempoResolucion.AutoSize = true;
            this.lblTiempoResolucion.Location = new System.Drawing.Point(300, 70);
            this.lblTiempoResolucion.Name = "lblTiempoResolucion";
            this.lblTiempoResolucion.Text = "Resolución prom. (h):";
            this.lblTiempoResolucion.TabIndex = 17;
            // 
            // txtTiempoResolucion
            // 
            this.txtTiempoResolucion.Location = new System.Drawing.Point(440, 67);
            this.txtTiempoResolucion.Name = "txtTiempoResolucion";
            this.txtTiempoResolucion.Size = new System.Drawing.Size(90, 23);
            this.txtTiempoResolucion.ReadOnly = true;
            this.txtTiempoResolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTiempoResolucion.TabIndex = 18;
            // 
            // lblSatisfaccion
            // 
            this.lblSatisfaccion.AutoSize = true;
            this.lblSatisfaccion.Location = new System.Drawing.Point(565, 70);
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            this.lblSatisfaccion.Text = "Satisfacción promedio:";
            this.lblSatisfaccion.TabIndex = 19;
            // 
            // txtSatisfaccion
            // 
            this.txtSatisfaccion.Location = new System.Drawing.Point(745, 67);
            this.txtSatisfaccion.Name = "txtSatisfaccion";
            this.txtSatisfaccion.Size = new System.Drawing.Size(90, 23);
            this.txtSatisfaccion.ReadOnly = true;
            this.txtSatisfaccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSatisfaccion.TabIndex = 20;
            // 
            // lblPorTecnico
            // 
            this.lblPorTecnico.AutoSize = true;
            this.lblPorTecnico.Location = new System.Drawing.Point(15, 210);
            this.lblPorTecnico.Name = "lblPorTecnico";
            this.lblPorTecnico.Text = "Desempeño por técnico:";
            this.lblPorTecnico.TabIndex = 21;
            // 
            // dgvPorTecnico
            // 
            this.dgvPorTecnico.Location = new System.Drawing.Point(15, 230);
            this.dgvPorTecnico.Name = "dgvPorTecnico";
            this.dgvPorTecnico.Size = new System.Drawing.Size(850, 140);
            this.dgvPorTecnico.AllowUserToAddRows = false;
            this.dgvPorTecnico.AllowUserToDeleteRows = false;
            this.dgvPorTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorTecnico.MultiSelect = false;
            this.dgvPorTecnico.RowHeadersVisible = false;
            this.dgvPorTecnico.ReadOnly = true;
            this.dgvPorTecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvPorTecnicoTecnico, this.dgvPorTecnicoAsignados, this.dgvPorTecnicoCerrados, this.dgvPorTecnicoTiempoRespuesta, this.dgvPorTecnicoTiempoResolucion, this.dgvPorTecnicoSatisfaccion });
            this.dgvPorTecnico.TabIndex = 22;
            this.dgvPorTecnicoTecnico.HeaderText = "Técnico";
            this.dgvPorTecnicoTecnico.Name = "dgvPorTecnicoTecnico";
            this.dgvPorTecnicoTecnico.Width = 200;
            this.dgvPorTecnicoAsignados.HeaderText = "Asignados";
            this.dgvPorTecnicoAsignados.Name = "dgvPorTecnicoAsignados";
            this.dgvPorTecnicoAsignados.Width = 100;
            this.dgvPorTecnicoCerrados.HeaderText = "Cerrados";
            this.dgvPorTecnicoCerrados.Name = "dgvPorTecnicoCerrados";
            this.dgvPorTecnicoCerrados.Width = 100;
            this.dgvPorTecnicoTiempoRespuesta.HeaderText = "Resp. prom. (h)";
            this.dgvPorTecnicoTiempoRespuesta.Name = "dgvPorTecnicoTiempoRespuesta";
            this.dgvPorTecnicoTiempoRespuesta.Width = 120;
            this.dgvPorTecnicoTiempoResolucion.HeaderText = "Resol. prom. (h)";
            this.dgvPorTecnicoTiempoResolucion.Name = "dgvPorTecnicoTiempoResolucion";
            this.dgvPorTecnicoTiempoResolucion.Width = 120;
            this.dgvPorTecnicoSatisfaccion.HeaderText = "Satisfacción";
            this.dgvPorTecnicoSatisfaccion.Name = "dgvPorTecnicoSatisfaccion";
            this.dgvPorTecnicoSatisfaccion.Width = 207;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(15, 380);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Text = "Detalle de tickets:";
            this.lblDetalle.TabIndex = 23;
            // 
            // dgvDetalleTickets
            // 
            this.dgvDetalleTickets.Location = new System.Drawing.Point(15, 400);
            this.dgvDetalleTickets.Name = "dgvDetalleTickets";
            this.dgvDetalleTickets.Size = new System.Drawing.Size(850, 190);
            this.dgvDetalleTickets.AllowUserToAddRows = false;
            this.dgvDetalleTickets.AllowUserToDeleteRows = false;
            this.dgvDetalleTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleTickets.MultiSelect = false;
            this.dgvDetalleTickets.RowHeadersVisible = false;
            this.dgvDetalleTickets.ReadOnly = true;
            this.dgvDetalleTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvDetalleTicketsNroTicket, this.dgvDetalleTicketsCliente, this.dgvDetalleTicketsTecnico, this.dgvDetalleTicketsPrioridad, this.dgvDetalleTicketsTiempoRespuesta, this.dgvDetalleTicketsTiempoResolucion, this.dgvDetalleTicketsCalificacion, this.dgvDetalleTicketsEstado });
            this.dgvDetalleTickets.TabIndex = 24;
            this.dgvDetalleTicketsNroTicket.HeaderText = "Nº ticket";
            this.dgvDetalleTicketsNroTicket.Name = "dgvDetalleTicketsNroTicket";
            this.dgvDetalleTicketsNroTicket.Width = 80;
            this.dgvDetalleTicketsCliente.HeaderText = "Cliente";
            this.dgvDetalleTicketsCliente.Name = "dgvDetalleTicketsCliente";
            this.dgvDetalleTicketsCliente.Width = 170;
            this.dgvDetalleTicketsTecnico.HeaderText = "Técnico";
            this.dgvDetalleTicketsTecnico.Name = "dgvDetalleTicketsTecnico";
            this.dgvDetalleTicketsTecnico.Width = 150;
            this.dgvDetalleTicketsPrioridad.HeaderText = "Prioridad";
            this.dgvDetalleTicketsPrioridad.Name = "dgvDetalleTicketsPrioridad";
            this.dgvDetalleTicketsPrioridad.Width = 80;
            this.dgvDetalleTicketsTiempoRespuesta.HeaderText = "Resp. (h)";
            this.dgvDetalleTicketsTiempoRespuesta.Name = "dgvDetalleTicketsTiempoRespuesta";
            this.dgvDetalleTicketsTiempoRespuesta.Width = 80;
            this.dgvDetalleTicketsTiempoResolucion.HeaderText = "Resol. (h)";
            this.dgvDetalleTicketsTiempoResolucion.Name = "dgvDetalleTicketsTiempoResolucion";
            this.dgvDetalleTicketsTiempoResolucion.Width = 80;
            this.dgvDetalleTicketsCalificacion.HeaderText = "Calificación";
            this.dgvDetalleTicketsCalificacion.Name = "dgvDetalleTicketsCalificacion";
            this.dgvDetalleTicketsCalificacion.Width = 100;
            this.dgvDetalleTicketsEstado.HeaderText = "Estado";
            this.dgvDetalleTicketsEstado.Name = "dgvDetalleTicketsEstado";
            this.dgvDetalleTicketsEstado.Width = 107;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(644, 614);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(110, 30);
            this.btnExportar.Text = "Exportar...";
            this.btnExportar.TabIndex = 25;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(762, 614);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.TabIndex = 26;
            // 
            // EvaluarSoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.CancelButton = this.btnCerrar;
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.grpIndicadores);
            this.Controls.Add(this.lblPorTecnico);
            this.Controls.Add(this.dgvPorTecnico);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.dgvDetalleTickets);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EvaluarSoporteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluación de tiempos de respuesta y satisfacción";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorTecnico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTickets)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpIndicadores.ResumeLayout(false);
            this.grpIndicadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpIndicadores;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.TextBox txtTotalTickets;
        private System.Windows.Forms.Label lblTicketsCerrados;
        private System.Windows.Forms.TextBox txtTicketsCerrados;
        private System.Windows.Forms.Label lblFueraDePlazo;
        private System.Windows.Forms.TextBox txtFueraDePlazo;
        private System.Windows.Forms.Label lblTiempoRespuesta;
        private System.Windows.Forms.TextBox txtTiempoRespuesta;
        private System.Windows.Forms.Label lblTiempoResolucion;
        private System.Windows.Forms.TextBox txtTiempoResolucion;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.TextBox txtSatisfaccion;
        private System.Windows.Forms.Label lblPorTecnico;
        private System.Windows.Forms.DataGridView dgvPorTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPorTecnicoTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPorTecnicoAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPorTecnicoCerrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPorTecnicoTiempoRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPorTecnicoTiempoResolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPorTecnicoSatisfaccion;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsTiempoRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsTiempoResolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleTicketsEstado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
