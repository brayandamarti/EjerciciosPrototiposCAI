namespace NetAssist.Tickets.DerivarTicket
{
    partial class DerivarTicketForm
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.dgvTicketsNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsAsunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTicketsPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAnalisis = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoriaConfirmada = new System.Windows.Forms.Label();
            this.cmbCategoriaConfirmada = new System.Windows.Forms.ComboBox();
            this.lblPrioridadAsignada = new System.Windows.Forms.Label();
            this.cmbPrioridadAsignada = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            this.grpAnalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Location = new System.Drawing.Point(15, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(850, 70);
            this.grpFiltros.Text = "Filtros";
            this.grpFiltros.Controls.Add(this.lblEstado);
            this.grpFiltros.Controls.Add(this.cmbEstado);
            this.grpFiltros.Controls.Add(this.lblCategoria);
            this.grpFiltros.Controls.Add(this.cmbCategoria);
            this.grpFiltros.Controls.Add(this.lblPrioridad);
            this.grpFiltros.Controls.Add(this.cmbPrioridad);
            this.grpFiltros.Controls.Add(this.btnBuscar);
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
            this.cmbEstado.Size = new System.Drawing.Size(150, 23);
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] { "Abierto", "Derivado", "Todos" });
            this.cmbEstado.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(240, 32);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Location = new System.Drawing.Point(315, 29);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 23);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] { "Conectividad / Internet", "Correo electrónico", "Hardware", "Software / Aplicaciones", "Impresoras", "Seguridad / Accesos" });
            this.cmbCategoria.TabIndex = 4;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(535, 32);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Text = "Prioridad:";
            this.lblPrioridad.TabIndex = 5;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Location = new System.Drawing.Point(605, 29);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(100, 23);
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Items.AddRange(new object[] { "Baja", "Media", "Alta", "Crítica" });
            this.cmbPrioridad.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(725, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 7;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(15, 92);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Text = "Tickets recibidos:";
            this.lblTickets.TabIndex = 8;
            // 
            // dgvTickets
            // 
            this.dgvTickets.Location = new System.Drawing.Point(15, 112);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.Size = new System.Drawing.Size(850, 180);
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvTicketsNroTicket, this.dgvTicketsFechaAlta, this.dgvTicketsCliente, this.dgvTicketsAsunto, this.dgvTicketsCategoria, this.dgvTicketsPrioridad });
            this.dgvTickets.TabIndex = 9;
            this.dgvTicketsNroTicket.HeaderText = "Nº ticket";
            this.dgvTicketsNroTicket.Name = "dgvTicketsNroTicket";
            this.dgvTicketsNroTicket.Width = 90;
            this.dgvTicketsFechaAlta.HeaderText = "Fecha alta";
            this.dgvTicketsFechaAlta.Name = "dgvTicketsFechaAlta";
            this.dgvTicketsFechaAlta.Width = 110;
            this.dgvTicketsCliente.HeaderText = "Cliente";
            this.dgvTicketsCliente.Name = "dgvTicketsCliente";
            this.dgvTicketsCliente.Width = 200;
            this.dgvTicketsAsunto.HeaderText = "Asunto";
            this.dgvTicketsAsunto.Name = "dgvTicketsAsunto";
            this.dgvTicketsAsunto.Width = 230;
            this.dgvTicketsCategoria.HeaderText = "Categoría";
            this.dgvTicketsCategoria.Name = "dgvTicketsCategoria";
            this.dgvTicketsCategoria.Width = 120;
            this.dgvTicketsPrioridad.HeaderText = "Prioridad";
            this.dgvTicketsPrioridad.Name = "dgvTicketsPrioridad";
            this.dgvTicketsPrioridad.Width = 97;
            // 
            // grpAnalisis
            // 
            this.grpAnalisis.Location = new System.Drawing.Point(15, 302);
            this.grpAnalisis.Name = "grpAnalisis";
            this.grpAnalisis.Size = new System.Drawing.Size(850, 320);
            this.grpAnalisis.Text = "Análisis y derivación del ticket seleccionado";
            this.grpAnalisis.Controls.Add(this.lblDescripcion);
            this.grpAnalisis.Controls.Add(this.txtDescripcion);
            this.grpAnalisis.Controls.Add(this.lblCategoriaConfirmada);
            this.grpAnalisis.Controls.Add(this.cmbCategoriaConfirmada);
            this.grpAnalisis.Controls.Add(this.lblPrioridadAsignada);
            this.grpAnalisis.Controls.Add(this.cmbPrioridadAsignada);
            this.grpAnalisis.Controls.Add(this.lblTecnico);
            this.grpAnalisis.Controls.Add(this.cmbTecnico);
            this.grpAnalisis.Controls.Add(this.lblFechaLimite);
            this.grpAnalisis.Controls.Add(this.dtpFechaLimite);
            this.grpAnalisis.Controls.Add(this.lblComentario);
            this.grpAnalisis.Controls.Add(this.txtComentario);
            this.grpAnalisis.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción del cliente:";
            this.lblDescripcion.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 48);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(820, 80);
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.TabIndex = 12;
            // 
            // lblCategoriaConfirmada
            // 
            this.lblCategoriaConfirmada.AutoSize = true;
            this.lblCategoriaConfirmada.Location = new System.Drawing.Point(15, 145);
            this.lblCategoriaConfirmada.Name = "lblCategoriaConfirmada";
            this.lblCategoriaConfirmada.Text = "Categoría:";
            this.lblCategoriaConfirmada.TabIndex = 13;
            // 
            // cmbCategoriaConfirmada
            // 
            this.cmbCategoriaConfirmada.Location = new System.Drawing.Point(115, 142);
            this.cmbCategoriaConfirmada.Name = "cmbCategoriaConfirmada";
            this.cmbCategoriaConfirmada.Size = new System.Drawing.Size(250, 23);
            this.cmbCategoriaConfirmada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaConfirmada.Items.AddRange(new object[] { "Conectividad / Internet", "Correo electrónico", "Hardware", "Software / Aplicaciones", "Impresoras", "Seguridad / Accesos" });
            this.cmbCategoriaConfirmada.TabIndex = 14;
            // 
            // lblPrioridadAsignada
            // 
            this.lblPrioridadAsignada.AutoSize = true;
            this.lblPrioridadAsignada.Location = new System.Drawing.Point(390, 145);
            this.lblPrioridadAsignada.Name = "lblPrioridadAsignada";
            this.lblPrioridadAsignada.Text = "Prioridad:";
            this.lblPrioridadAsignada.TabIndex = 15;
            // 
            // cmbPrioridadAsignada
            // 
            this.cmbPrioridadAsignada.Location = new System.Drawing.Point(470, 142);
            this.cmbPrioridadAsignada.Name = "cmbPrioridadAsignada";
            this.cmbPrioridadAsignada.Size = new System.Drawing.Size(150, 23);
            this.cmbPrioridadAsignada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridadAsignada.Items.AddRange(new object[] { "Baja", "Media", "Alta", "Crítica" });
            this.cmbPrioridadAsignada.TabIndex = 16;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(15, 183);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Text = "Técnico asignado:";
            this.lblTecnico.TabIndex = 17;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.Location = new System.Drawing.Point(135, 180);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(230, 23);
            this.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnico.Items.AddRange(new object[] { "Fernández, Lucas", "Méndez, Sofía", "Torres, Diego" });
            this.cmbTecnico.TabIndex = 18;
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Location = new System.Drawing.Point(390, 183);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Text = "Fecha límite:";
            this.lblFechaLimite.TabIndex = 19;
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Location = new System.Drawing.Point(470, 180);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(150, 23);
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.TabIndex = 20;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(15, 220);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Text = "Comentario para el técnico:";
            this.lblComentario.TabIndex = 21;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(15, 240);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(820, 65);
            this.txtComentario.Multiline = true;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(644, 634);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Derivar";
            this.btnAceptar.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(762, 634);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 24;
            // 
            // DerivarTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 680);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.grpAnalisis);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DerivarTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizar y derivar tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpAnalisis.ResumeLayout(false);
            this.grpAnalisis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsAsunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTicketsPrioridad;
        private System.Windows.Forms.GroupBox grpAnalisis;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoriaConfirmada;
        private System.Windows.Forms.ComboBox cmbCategoriaConfirmada;
        private System.Windows.Forms.Label lblPrioridadAsignada;
        private System.Windows.Forms.ComboBox cmbPrioridadAsignada;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
