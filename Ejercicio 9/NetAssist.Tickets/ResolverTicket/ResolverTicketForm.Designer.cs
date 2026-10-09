namespace NetAssist.Tickets.ResolverTicket
{
    partial class ResolverTicketForm
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
            this.lblTicketsAsignados = new System.Windows.Forms.Label();
            this.dgvTicketsAsignados = new System.Windows.Forms.DataGridView();
            this.dgvTicketsAsignadosNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsAsignadosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsAsignadosAsunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsAsignadosPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsAsignadosFechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsAsignadosEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTicket = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblComentarioOperador = new System.Windows.Forms.Label();
            this.txtComentarioOperador = new System.Windows.Forms.TextBox();
            this.grpIntervencion = new System.Windows.Forms.GroupBox();
            this.lblFechaIntervencion = new System.Windows.Forms.Label();
            this.dtpFechaIntervencion = new System.Windows.Forms.DateTimePicker();
            this.lblHoras = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarIntervencion = new System.Windows.Forms.Button();
            this.lblDetalleTrabajo = new System.Windows.Forms.Label();
            this.txtDetalleTrabajo = new System.Windows.Forms.TextBox();
            this.dgvIntervenciones = new System.Windows.Forms.DataGridView();
            this.dgvIntervencionesFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIntervencionesHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIntervencionesDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarIntervencion = new System.Windows.Forms.Button();
            this.lblNuevoEstado = new System.Windows.Forms.Label();
            this.cmbNuevoEstado = new System.Windows.Forms.ComboBox();
            this.lblSolucion = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpTicket.SuspendLayout();
            this.grpIntervencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketsAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketsAsignados
            // 
            this.lblTicketsAsignados.AutoSize = true;
            this.lblTicketsAsignados.Location = new System.Drawing.Point(15, 12);
            this.lblTicketsAsignados.Name = "lblTicketsAsignados";
            this.lblTicketsAsignados.Text = "Mis tickets asignados:";
            this.lblTicketsAsignados.TabIndex = 0;
            // 
            // dgvTicketsAsignados
            // 
            this.dgvTicketsAsignados.Location = new System.Drawing.Point(15, 32);
            this.dgvTicketsAsignados.Name = "dgvTicketsAsignados";
            this.dgvTicketsAsignados.Size = new System.Drawing.Size(830, 150);
            this.dgvTicketsAsignados.AllowUserToAddRows = false;
            this.dgvTicketsAsignados.AllowUserToDeleteRows = false;
            this.dgvTicketsAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketsAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicketsAsignados.MultiSelect = false;
            this.dgvTicketsAsignados.RowHeadersVisible = false;
            this.dgvTicketsAsignados.ReadOnly = true;
            this.dgvTicketsAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvTicketsAsignadosNroTicket, this.dgvTicketsAsignadosCliente, this.dgvTicketsAsignadosAsunto, this.dgvTicketsAsignadosPrioridad, this.dgvTicketsAsignadosFechaLimite, this.dgvTicketsAsignadosEstado });
            this.dgvTicketsAsignados.TabIndex = 1;
            this.dgvTicketsAsignadosNroTicket.HeaderText = "Nº ticket";
            this.dgvTicketsAsignadosNroTicket.Name = "dgvTicketsAsignadosNroTicket";
            this.dgvTicketsAsignadosNroTicket.Width = 90;
            this.dgvTicketsAsignadosCliente.HeaderText = "Cliente";
            this.dgvTicketsAsignadosCliente.Name = "dgvTicketsAsignadosCliente";
            this.dgvTicketsAsignadosCliente.Width = 200;
            this.dgvTicketsAsignadosAsunto.HeaderText = "Asunto";
            this.dgvTicketsAsignadosAsunto.Name = "dgvTicketsAsignadosAsunto";
            this.dgvTicketsAsignadosAsunto.Width = 240;
            this.dgvTicketsAsignadosPrioridad.HeaderText = "Prioridad";
            this.dgvTicketsAsignadosPrioridad.Name = "dgvTicketsAsignadosPrioridad";
            this.dgvTicketsAsignadosPrioridad.Width = 90;
            this.dgvTicketsAsignadosFechaLimite.HeaderText = "Fecha límite";
            this.dgvTicketsAsignadosFechaLimite.Name = "dgvTicketsAsignadosFechaLimite";
            this.dgvTicketsAsignadosFechaLimite.Width = 110;
            this.dgvTicketsAsignadosEstado.HeaderText = "Estado";
            this.dgvTicketsAsignadosEstado.Name = "dgvTicketsAsignadosEstado";
            this.dgvTicketsAsignadosEstado.Width = 97;
            // 
            // grpTicket
            // 
            this.grpTicket.Location = new System.Drawing.Point(15, 192);
            this.grpTicket.Name = "grpTicket";
            this.grpTicket.Size = new System.Drawing.Size(830, 130);
            this.grpTicket.Text = "Ticket seleccionado";
            this.grpTicket.Controls.Add(this.lblDescripcion);
            this.grpTicket.Controls.Add(this.txtDescripcion);
            this.grpTicket.Controls.Add(this.lblComentarioOperador);
            this.grpTicket.Controls.Add(this.txtComentarioOperador);
            this.grpTicket.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción del cliente:";
            this.lblDescripcion.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 48);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(395, 65);
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblComentarioOperador
            // 
            this.lblComentarioOperador.AutoSize = true;
            this.lblComentarioOperador.Location = new System.Drawing.Point(420, 28);
            this.lblComentarioOperador.Name = "lblComentarioOperador";
            this.lblComentarioOperador.Text = "Comentario del operador:";
            this.lblComentarioOperador.TabIndex = 5;
            // 
            // txtComentarioOperador
            // 
            this.txtComentarioOperador.Location = new System.Drawing.Point(420, 48);
            this.txtComentarioOperador.Name = "txtComentarioOperador";
            this.txtComentarioOperador.Size = new System.Drawing.Size(395, 65);
            this.txtComentarioOperador.ReadOnly = true;
            this.txtComentarioOperador.Multiline = true;
            this.txtComentarioOperador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarioOperador.TabIndex = 6;
            // 
            // grpIntervencion
            // 
            this.grpIntervencion.Location = new System.Drawing.Point(15, 330);
            this.grpIntervencion.Name = "grpIntervencion";
            this.grpIntervencion.Size = new System.Drawing.Size(830, 140);
            this.grpIntervencion.Text = "Registrar intervención";
            this.grpIntervencion.Controls.Add(this.lblFechaIntervencion);
            this.grpIntervencion.Controls.Add(this.dtpFechaIntervencion);
            this.grpIntervencion.Controls.Add(this.lblHoras);
            this.grpIntervencion.Controls.Add(this.nudHoras);
            this.grpIntervencion.Controls.Add(this.btnAgregarIntervencion);
            this.grpIntervencion.Controls.Add(this.lblDetalleTrabajo);
            this.grpIntervencion.Controls.Add(this.txtDetalleTrabajo);
            this.grpIntervencion.TabIndex = 7;
            // 
            // lblFechaIntervencion
            // 
            this.lblFechaIntervencion.AutoSize = true;
            this.lblFechaIntervencion.Location = new System.Drawing.Point(15, 32);
            this.lblFechaIntervencion.Name = "lblFechaIntervencion";
            this.lblFechaIntervencion.Text = "Fecha:";
            this.lblFechaIntervencion.TabIndex = 8;
            // 
            // dtpFechaIntervencion
            // 
            this.dtpFechaIntervencion.Location = new System.Drawing.Point(85, 29);
            this.dtpFechaIntervencion.Name = "dtpFechaIntervencion";
            this.dtpFechaIntervencion.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaIntervencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIntervencion.TabIndex = 9;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(225, 32);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Text = "Horas:";
            this.lblHoras.TabIndex = 10;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(275, 29);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(70, 23);
            this.nudHoras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudHoras.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudHoras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudHoras.TabIndex = 11;
            // 
            // btnAgregarIntervencion
            // 
            this.btnAgregarIntervencion.Location = new System.Drawing.Point(715, 26);
            this.btnAgregarIntervencion.Name = "btnAgregarIntervencion";
            this.btnAgregarIntervencion.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarIntervencion.Text = "Agregar";
            this.btnAgregarIntervencion.TabIndex = 12;
            // 
            // lblDetalleTrabajo
            // 
            this.lblDetalleTrabajo.AutoSize = true;
            this.lblDetalleTrabajo.Location = new System.Drawing.Point(15, 68);
            this.lblDetalleTrabajo.Name = "lblDetalleTrabajo";
            this.lblDetalleTrabajo.Text = "Trabajo realizado:";
            this.lblDetalleTrabajo.TabIndex = 13;
            // 
            // txtDetalleTrabajo
            // 
            this.txtDetalleTrabajo.Location = new System.Drawing.Point(130, 65);
            this.txtDetalleTrabajo.Name = "txtDetalleTrabajo";
            this.txtDetalleTrabajo.Size = new System.Drawing.Size(685, 60);
            this.txtDetalleTrabajo.Multiline = true;
            this.txtDetalleTrabajo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalleTrabajo.TabIndex = 14;
            // 
            // dgvIntervenciones
            // 
            this.dgvIntervenciones.Location = new System.Drawing.Point(15, 478);
            this.dgvIntervenciones.Name = "dgvIntervenciones";
            this.dgvIntervenciones.Size = new System.Drawing.Size(710, 110);
            this.dgvIntervenciones.AllowUserToAddRows = false;
            this.dgvIntervenciones.AllowUserToDeleteRows = false;
            this.dgvIntervenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervenciones.MultiSelect = false;
            this.dgvIntervenciones.RowHeadersVisible = false;
            this.dgvIntervenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvIntervencionesFecha, this.dgvIntervencionesHoras, this.dgvIntervencionesDetalle });
            this.dgvIntervenciones.TabIndex = 15;
            this.dgvIntervencionesFecha.HeaderText = "Fecha";
            this.dgvIntervencionesFecha.Name = "dgvIntervencionesFecha";
            this.dgvIntervencionesFecha.Width = 110;
            this.dgvIntervencionesFecha.ReadOnly = true;
            this.dgvIntervencionesHoras.HeaderText = "Horas";
            this.dgvIntervencionesHoras.Name = "dgvIntervencionesHoras";
            this.dgvIntervencionesHoras.Width = 80;
            this.dgvIntervencionesHoras.ReadOnly = true;
            this.dgvIntervencionesDetalle.HeaderText = "Trabajo realizado";
            this.dgvIntervencionesDetalle.Name = "dgvIntervencionesDetalle";
            this.dgvIntervencionesDetalle.Width = 517;
            this.dgvIntervencionesDetalle.ReadOnly = true;
            // 
            // btnQuitarIntervencion
            // 
            this.btnQuitarIntervencion.Location = new System.Drawing.Point(735, 478);
            this.btnQuitarIntervencion.Name = "btnQuitarIntervencion";
            this.btnQuitarIntervencion.Size = new System.Drawing.Size(110, 30);
            this.btnQuitarIntervencion.Text = "Quitar";
            this.btnQuitarIntervencion.TabIndex = 16;
            // 
            // lblNuevoEstado
            // 
            this.lblNuevoEstado.AutoSize = true;
            this.lblNuevoEstado.Location = new System.Drawing.Point(15, 603);
            this.lblNuevoEstado.Name = "lblNuevoEstado";
            this.lblNuevoEstado.Text = "Nuevo estado:";
            this.lblNuevoEstado.TabIndex = 17;
            // 
            // cmbNuevoEstado
            // 
            this.cmbNuevoEstado.Location = new System.Drawing.Point(115, 600);
            this.cmbNuevoEstado.Name = "cmbNuevoEstado";
            this.cmbNuevoEstado.Size = new System.Drawing.Size(220, 23);
            this.cmbNuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoEstado.Items.AddRange(new object[] { "En curso", "En espera del cliente", "Resuelto" });
            this.cmbNuevoEstado.TabIndex = 18;
            // 
            // lblSolucion
            // 
            this.lblSolucion.AutoSize = true;
            this.lblSolucion.Location = new System.Drawing.Point(355, 603);
            this.lblSolucion.Name = "lblSolucion";
            this.lblSolucion.Text = "Solución aplicada:";
            this.lblSolucion.TabIndex = 19;
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(470, 600);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(375, 23);
            this.txtSolucion.TabIndex = 20;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(624, 674);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(742, 674);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 22;
            // 
            // ResolverTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 720);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblTicketsAsignados);
            this.Controls.Add(this.dgvTicketsAsignados);
            this.Controls.Add(this.grpTicket);
            this.Controls.Add(this.grpIntervencion);
            this.Controls.Add(this.dgvIntervenciones);
            this.Controls.Add(this.btnQuitarIntervencion);
            this.Controls.Add(this.lblNuevoEstado);
            this.Controls.Add(this.cmbNuevoEstado);
            this.Controls.Add(this.lblSolucion);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResolverTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolver tickets asignados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketsAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones)).EndInit();
            this.grpTicket.ResumeLayout(false);
            this.grpTicket.PerformLayout();
            this.grpIntervencion.ResumeLayout(false);
            this.grpIntervencion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTicketsAsignados;
        private System.Windows.Forms.DataGridView dgvTicketsAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsignadosNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsignadosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsignadosAsunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsignadosPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsignadosFechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsignadosEstado;
        private System.Windows.Forms.GroupBox grpTicket;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblComentarioOperador;
        private System.Windows.Forms.TextBox txtComentarioOperador;
        private System.Windows.Forms.GroupBox grpIntervencion;
        private System.Windows.Forms.Label lblFechaIntervencion;
        private System.Windows.Forms.DateTimePicker dtpFechaIntervencion;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnAgregarIntervencion;
        private System.Windows.Forms.Label lblDetalleTrabajo;
        private System.Windows.Forms.TextBox txtDetalleTrabajo;
        private System.Windows.Forms.DataGridView dgvIntervenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIntervencionesFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIntervencionesHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIntervencionesDetalle;
        private System.Windows.Forms.Button btnQuitarIntervencion;
        private System.Windows.Forms.Label lblNuevoEstado;
        private System.Windows.Forms.ComboBox cmbNuevoEstado;
        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
