namespace NetAssist.Tickets.RegistrarTicket
{
    partial class RegistrarTicketForm
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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grpProblema = new System.Windows.Forms.GroupBox();
            this.lblNroTicket = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.grpAdjuntos = new System.Windows.Forms.GroupBox();
            this.lstAdjuntos = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.btnQuitarAdjunto = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpProblema.SuspendLayout();
            this.grpAdjuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Location = new System.Drawing.Point(15, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(750, 110);
            this.grpCliente.Text = "Datos del cliente";
            this.grpCliente.Controls.Add(this.lblNroCliente);
            this.grpCliente.Controls.Add(this.txtNroCliente);
            this.grpCliente.Controls.Add(this.lblRazonSocial);
            this.grpCliente.Controls.Add(this.txtRazonSocial);
            this.grpCliente.Controls.Add(this.lblContacto);
            this.grpCliente.Controls.Add(this.txtContacto);
            this.grpCliente.Controls.Add(this.lblTelefono);
            this.grpCliente.Controls.Add(this.txtTelefono);
            this.grpCliente.TabIndex = 0;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(15, 30);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Text = "Nº de cliente:";
            this.lblNroCliente.TabIndex = 1;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(120, 27);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(120, 23);
            this.txtNroCliente.ReadOnly = true;
            this.txtNroCliente.TabIndex = 2;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(265, 30);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Text = "Cliente:";
            this.lblRazonSocial.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(330, 27);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(400, 23);
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.TabIndex = 4;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(15, 68);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Text = "Contacto:";
            this.lblContacto.TabIndex = 5;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(120, 65);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(250, 23);
            this.txtContacto.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(390, 68);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(460, 65);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(270, 23);
            this.txtTelefono.TabIndex = 8;
            // 
            // grpProblema
            // 
            this.grpProblema.Location = new System.Drawing.Point(15, 130);
            this.grpProblema.Name = "grpProblema";
            this.grpProblema.Size = new System.Drawing.Size(750, 300);
            this.grpProblema.Text = "Descripción del problema";
            this.grpProblema.Controls.Add(this.lblNroTicket);
            this.grpProblema.Controls.Add(this.txtNroTicket);
            this.grpProblema.Controls.Add(this.lblFechaAlta);
            this.grpProblema.Controls.Add(this.dtpFechaAlta);
            this.grpProblema.Controls.Add(this.lblCategoria);
            this.grpProblema.Controls.Add(this.cmbCategoria);
            this.grpProblema.Controls.Add(this.lblPrioridad);
            this.grpProblema.Controls.Add(this.cmbPrioridad);
            this.grpProblema.Controls.Add(this.lblAsunto);
            this.grpProblema.Controls.Add(this.txtAsunto);
            this.grpProblema.Controls.Add(this.lblDescripcion);
            this.grpProblema.Controls.Add(this.txtDescripcion);
            this.grpProblema.TabIndex = 9;
            // 
            // lblNroTicket
            // 
            this.lblNroTicket.AutoSize = true;
            this.lblNroTicket.Location = new System.Drawing.Point(15, 30);
            this.lblNroTicket.Name = "lblNroTicket";
            this.lblNroTicket.Text = "Nº de ticket:";
            this.lblNroTicket.TabIndex = 10;
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(120, 27);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(120, 23);
            this.txtNroTicket.ReadOnly = true;
            this.txtNroTicket.TabIndex = 11;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(265, 30);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Text = "Fecha:";
            this.lblFechaAlta.TabIndex = 12;
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(330, 27);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.TabIndex = 13;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 68);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.TabIndex = 14;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Location = new System.Drawing.Point(120, 65);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 23);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] { "Conectividad / Internet", "Correo electrónico", "Hardware", "Software / Aplicaciones", "Impresoras", "Seguridad / Accesos" });
            this.cmbCategoria.TabIndex = 15;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(390, 68);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Text = "Prioridad:";
            this.lblPrioridad.TabIndex = 16;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Location = new System.Drawing.Point(460, 65);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(270, 23);
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Items.AddRange(new object[] { "Baja", "Media", "Alta", "Crítica" });
            this.cmbPrioridad.TabIndex = 17;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(15, 106);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Text = "Asunto:";
            this.lblAsunto.TabIndex = 18;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(120, 103);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(610, 23);
            this.txtAsunto.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 142);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 139);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(610, 140);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.TabIndex = 21;
            // 
            // grpAdjuntos
            // 
            this.grpAdjuntos.Location = new System.Drawing.Point(15, 438);
            this.grpAdjuntos.Name = "grpAdjuntos";
            this.grpAdjuntos.Size = new System.Drawing.Size(750, 100);
            this.grpAdjuntos.Text = "Archivos adjuntos";
            this.grpAdjuntos.Controls.Add(this.lstAdjuntos);
            this.grpAdjuntos.Controls.Add(this.btnAdjuntar);
            this.grpAdjuntos.Controls.Add(this.btnQuitarAdjunto);
            this.grpAdjuntos.TabIndex = 22;
            // 
            // lstAdjuntos
            // 
            this.lstAdjuntos.Location = new System.Drawing.Point(15, 25);
            this.lstAdjuntos.Name = "lstAdjuntos";
            this.lstAdjuntos.Size = new System.Drawing.Size(600, 64);
            this.lstAdjuntos.TabIndex = 23;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(630, 25);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(100, 30);
            this.btnAdjuntar.Text = "Adjuntar...";
            this.btnAdjuntar.TabIndex = 24;
            // 
            // btnQuitarAdjunto
            // 
            this.btnQuitarAdjunto.Location = new System.Drawing.Point(630, 60);
            this.btnQuitarAdjunto.Name = "btnQuitarAdjunto";
            this.btnQuitarAdjunto.Size = new System.Drawing.Size(100, 30);
            this.btnQuitarAdjunto.Text = "Quitar";
            this.btnQuitarAdjunto.TabIndex = 25;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(544, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 27;
            // 
            // RegistrarTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 600);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpProblema);
            this.Controls.Add(this.grpAdjuntos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegistrarTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar ticket de soporte";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProblema.ResumeLayout(false);
            this.grpProblema.PerformLayout();
            this.grpAdjuntos.ResumeLayout(false);
            this.grpAdjuntos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox grpProblema;
        private System.Windows.Forms.Label lblNroTicket;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox grpAdjuntos;
        private System.Windows.Forms.ListBox lstAdjuntos;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Button btnQuitarAdjunto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
