namespace NetAssist.Tickets.MenuPrincipal
{
    partial class MenuPrincipalForm
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            grpCliente = new GroupBox();
            btnRegistrarTicket = new Button();
            btnNotificaciones = new Button();
            grpOperador = new GroupBox();
            btnDerivarTickets = new Button();
            grpTecnico = new GroupBox();
            btnResolverTickets = new Button();
            grpJefeSoporte = new GroupBox();
            btnEvaluarSoporte = new Button();
            btnSalir = new Button();
            grpCliente.SuspendLayout();
            grpOperador.SuspendLayout();
            grpTecnico.SuspendLayout();
            grpJefeSoporte.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Tickets de Soporte Técnico";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(22, 55);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario conectado:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(150, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(340, 23);
            txtUsuario.TabIndex = 2;
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(btnRegistrarTicket);
            grpCliente.Controls.Add(btnNotificaciones);
            grpCliente.Location = new Point(20, 90);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(230, 115);
            grpCliente.TabIndex = 3;
            grpCliente.TabStop = false;
            grpCliente.Text = "Cliente";
            // 
            // btnRegistrarTicket
            // 
            btnRegistrarTicket.Location = new Point(15, 28);
            btnRegistrarTicket.Name = "btnRegistrarTicket";
            btnRegistrarTicket.Size = new Size(200, 32);
            btnRegistrarTicket.TabIndex = 4;
            btnRegistrarTicket.Text = "Registrar ticket";
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.Location = new Point(15, 68);
            btnNotificaciones.Name = "btnNotificaciones";
            btnNotificaciones.Size = new Size(200, 32);
            btnNotificaciones.TabIndex = 5;
            btnNotificaciones.Text = "Notificaciones de cierre";
            // 
            // grpOperador
            // 
            grpOperador.Controls.Add(btnDerivarTickets);
            grpOperador.Location = new Point(270, 90);
            grpOperador.Name = "grpOperador";
            grpOperador.Size = new Size(230, 115);
            grpOperador.TabIndex = 6;
            grpOperador.TabStop = false;
            grpOperador.Text = "Operador";
            // 
            // btnDerivarTickets
            // 
            btnDerivarTickets.Location = new Point(15, 28);
            btnDerivarTickets.Name = "btnDerivarTickets";
            btnDerivarTickets.Size = new Size(200, 32);
            btnDerivarTickets.TabIndex = 7;
            btnDerivarTickets.Text = "Analizar y derivar tickets";
            // 
            // grpTecnico
            // 
            grpTecnico.Controls.Add(btnResolverTickets);
            grpTecnico.Location = new Point(20, 215);
            grpTecnico.Name = "grpTecnico";
            grpTecnico.Size = new Size(230, 80);
            grpTecnico.TabIndex = 8;
            grpTecnico.TabStop = false;
            grpTecnico.Text = "Técnico";
            // 
            // btnResolverTickets
            // 
            btnResolverTickets.Location = new Point(15, 28);
            btnResolverTickets.Name = "btnResolverTickets";
            btnResolverTickets.Size = new Size(200, 32);
            btnResolverTickets.TabIndex = 9;
            btnResolverTickets.Text = "Resolver tickets asignados";
            // 
            // grpJefeSoporte
            // 
            grpJefeSoporte.Controls.Add(btnEvaluarSoporte);
            grpJefeSoporte.Location = new Point(270, 215);
            grpJefeSoporte.Name = "grpJefeSoporte";
            grpJefeSoporte.Size = new Size(230, 80);
            grpJefeSoporte.TabIndex = 10;
            grpJefeSoporte.TabStop = false;
            grpJefeSoporte.Text = "Jefe de soporte";
            // 
            // btnEvaluarSoporte
            // 
            btnEvaluarSoporte.Location = new Point(15, 28);
            btnEvaluarSoporte.Name = "btnEvaluarSoporte";
            btnEvaluarSoporte.Size = new Size(200, 32);
            btnEvaluarSoporte.TabIndex = 11;
            btnEvaluarSoporte.Text = "Evaluar desempeño";
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(402, 354);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(520, 400);
            Controls.Add(lblTitulo);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(grpCliente);
            Controls.Add(grpOperador);
            Controls.Add(grpTecnico);
            Controls.Add(grpJefeSoporte);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MenuPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NetAssist - Gestión de Tickets de Soporte";
            grpCliente.ResumeLayout(false);
            grpOperador.ResumeLayout(false);
            grpTecnico.ResumeLayout(false);
            grpJefeSoporte.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnRegistrarTicket;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.GroupBox grpOperador;
        private System.Windows.Forms.Button btnDerivarTickets;
        private System.Windows.Forms.GroupBox grpTecnico;
        private System.Windows.Forms.Button btnResolverTickets;
        private System.Windows.Forms.GroupBox grpJefeSoporte;
        private System.Windows.Forms.Button btnEvaluarSoporte;
        private System.Windows.Forms.Button btnSalir;
    }
}
