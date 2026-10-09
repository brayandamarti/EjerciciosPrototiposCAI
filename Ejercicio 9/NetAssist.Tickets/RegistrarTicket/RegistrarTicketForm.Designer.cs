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
            grpCliente = new GroupBox();
            lblNroCliente = new Label();
            txtNroCliente = new TextBox();
            lblRazonSocial = new Label();
            txtRazonSocial = new TextBox();
            lblContacto = new Label();
            txtContacto = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            grpProblema = new GroupBox();
            lblNroTicket = new Label();
            txtNroTicket = new TextBox();
            lblFechaAlta = new Label();
            dtpFechaAlta = new DateTimePicker();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            lblAsunto = new Label();
            txtAsunto = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            grpAdjuntos = new GroupBox();
            lstAdjuntos = new ListBox();
            btnAdjuntar = new Button();
            btnQuitarAdjunto = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            grpCliente.SuspendLayout();
            grpProblema.SuspendLayout();
            grpAdjuntos.SuspendLayout();
            SuspendLayout();
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(lblNroCliente);
            grpCliente.Controls.Add(txtNroCliente);
            grpCliente.Controls.Add(lblRazonSocial);
            grpCliente.Controls.Add(txtRazonSocial);
            grpCliente.Controls.Add(lblContacto);
            grpCliente.Controls.Add(txtContacto);
            grpCliente.Controls.Add(lblTelefono);
            grpCliente.Controls.Add(txtTelefono);
            grpCliente.Location = new Point(15, 12);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(750, 110);
            grpCliente.TabIndex = 0;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del cliente";
            // 
            // lblNroCliente
            // 
            lblNroCliente.AutoSize = true;
            lblNroCliente.Location = new Point(15, 30);
            lblNroCliente.Name = "lblNroCliente";
            lblNroCliente.Size = new Size(78, 15);
            lblNroCliente.TabIndex = 1;
            lblNroCliente.Text = "Nº de cliente:";
            // 
            // txtNroCliente
            // 
            txtNroCliente.Location = new Point(120, 27);
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.ReadOnly = true;
            txtNroCliente.Size = new Size(120, 23);
            txtNroCliente.TabIndex = 2;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(265, 30);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(47, 15);
            lblRazonSocial.TabIndex = 3;
            lblRazonSocial.Text = "Cliente:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(330, 27);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.ReadOnly = true;
            txtRazonSocial.Size = new Size(400, 23);
            txtRazonSocial.TabIndex = 4;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(15, 68);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(59, 15);
            lblContacto.TabIndex = 5;
            lblContacto.Text = "Contacto:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(120, 65);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(250, 23);
            txtContacto.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(390, 68);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(460, 65);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(270, 23);
            txtTelefono.TabIndex = 8;
            // 
            // grpProblema
            // 
            grpProblema.Controls.Add(lblNroTicket);
            grpProblema.Controls.Add(txtNroTicket);
            grpProblema.Controls.Add(lblFechaAlta);
            grpProblema.Controls.Add(dtpFechaAlta);
            grpProblema.Controls.Add(lblCategoria);
            grpProblema.Controls.Add(cmbCategoria);
            grpProblema.Controls.Add(lblPrioridad);
            grpProblema.Controls.Add(cmbPrioridad);
            grpProblema.Controls.Add(lblAsunto);
            grpProblema.Controls.Add(txtAsunto);
            grpProblema.Controls.Add(lblDescripcion);
            grpProblema.Controls.Add(txtDescripcion);
            grpProblema.Location = new Point(15, 130);
            grpProblema.Name = "grpProblema";
            grpProblema.Size = new Size(750, 300);
            grpProblema.TabIndex = 9;
            grpProblema.TabStop = false;
            grpProblema.Text = "Descripción del problema";
            // 
            // lblNroTicket
            // 
            lblNroTicket.AutoSize = true;
            lblNroTicket.Location = new Point(15, 30);
            lblNroTicket.Name = "lblNroTicket";
            lblNroTicket.Size = new Size(72, 15);
            lblNroTicket.TabIndex = 10;
            lblNroTicket.Text = "Nº de ticket:";
            // 
            // txtNroTicket
            // 
            txtNroTicket.Location = new Point(120, 27);
            txtNroTicket.Name = "txtNroTicket";
            txtNroTicket.ReadOnly = true;
            txtNroTicket.Size = new Size(120, 23);
            txtNroTicket.TabIndex = 11;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(265, 30);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(41, 15);
            lblFechaAlta.TabIndex = 12;
            lblFechaAlta.Text = "Fecha:";
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Format = DateTimePickerFormat.Short;
            dtpFechaAlta.Location = new Point(330, 27);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(120, 23);
            dtpFechaAlta.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(15, 68);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Items.AddRange(new object[] { "Conectividad / Internet", "Correo electrónico", "Hardware", "Software / Aplicaciones", "Impresoras", "Seguridad / Accesos" });
            cmbCategoria.Location = new Point(120, 65);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(250, 23);
            cmbCategoria.TabIndex = 15;
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(390, 68);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(58, 15);
            lblPrioridad.TabIndex = 16;
            lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.Items.AddRange(new object[] { "Baja", "Media", "Alta", "Crítica" });
            cmbPrioridad.Location = new Point(460, 65);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(270, 23);
            cmbPrioridad.TabIndex = 17;
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Location = new Point(15, 106);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(48, 15);
            lblAsunto.TabIndex = 18;
            lblAsunto.Text = "Asunto:";
            // 
            // txtAsunto
            // 
            txtAsunto.Location = new Point(120, 103);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(610, 23);
            txtAsunto.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(15, 142);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 20;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(120, 139);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(610, 140);
            txtDescripcion.TabIndex = 21;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // grpAdjuntos
            // 
            grpAdjuntos.Controls.Add(lstAdjuntos);
            grpAdjuntos.Controls.Add(btnAdjuntar);
            grpAdjuntos.Controls.Add(btnQuitarAdjunto);
            grpAdjuntos.Location = new Point(15, 438);
            grpAdjuntos.Name = "grpAdjuntos";
            grpAdjuntos.Size = new Size(750, 100);
            grpAdjuntos.TabIndex = 22;
            grpAdjuntos.TabStop = false;
            grpAdjuntos.Text = "Archivos adjuntos";
            // 
            // lstAdjuntos
            // 
            lstAdjuntos.ItemHeight = 15;
            lstAdjuntos.Location = new Point(15, 25);
            lstAdjuntos.Name = "lstAdjuntos";
            lstAdjuntos.Size = new Size(600, 64);
            lstAdjuntos.TabIndex = 23;
            lstAdjuntos.SelectedIndexChanged += lstAdjuntos_SelectedIndexChanged;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.Location = new Point(630, 25);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(100, 30);
            btnAdjuntar.TabIndex = 24;
            btnAdjuntar.Text = "Adjuntar...";
            // 
            // btnQuitarAdjunto
            // 
            btnQuitarAdjunto.Location = new Point(630, 60);
            btnQuitarAdjunto.Name = "btnQuitarAdjunto";
            btnQuitarAdjunto.Size = new Size(100, 30);
            btnQuitarAdjunto.TabIndex = 25;
            btnQuitarAdjunto.Text = "Quitar";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(544, 554);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 30);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "Registrar";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(662, 554);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            // 
            // RegistrarTicketForm
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(780, 600);
            Controls.Add(grpCliente);
            Controls.Add(grpProblema);
            Controls.Add(grpAdjuntos);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegistrarTicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar ticket de soporte";
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpProblema.ResumeLayout(false);
            grpProblema.PerformLayout();
            grpAdjuntos.ResumeLayout(false);
            ResumeLayout(false);
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
