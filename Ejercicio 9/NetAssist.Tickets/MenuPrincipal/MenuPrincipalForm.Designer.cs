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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnRegistrarTicket = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.grpOperador = new System.Windows.Forms.GroupBox();
            this.btnDerivarTickets = new System.Windows.Forms.Button();
            this.grpTecnico = new System.Windows.Forms.GroupBox();
            this.btnResolverTickets = new System.Windows.Forms.Button();
            this.grpJefeSoporte = new System.Windows.Forms.GroupBox();
            this.btnEvaluarSoporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpOperador.SuspendLayout();
            this.grpTecnico.SuspendLayout();
            this.grpJefeSoporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Gestión de Tickets de Soporte Técnico";
            this.lblTitulo.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(22, 55);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "Usuario conectado:";
            this.lblUsuario.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(150, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 23);
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.TabIndex = 2;
            // 
            // grpCliente
            // 
            this.grpCliente.Location = new System.Drawing.Point(20, 90);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(230, 115);
            this.grpCliente.Text = "Cliente";
            this.grpCliente.Controls.Add(this.btnRegistrarTicket);
            this.grpCliente.Controls.Add(this.btnNotificaciones);
            this.grpCliente.TabIndex = 3;
            // 
            // btnRegistrarTicket
            // 
            this.btnRegistrarTicket.Location = new System.Drawing.Point(15, 28);
            this.btnRegistrarTicket.Name = "btnRegistrarTicket";
            this.btnRegistrarTicket.Size = new System.Drawing.Size(200, 32);
            this.btnRegistrarTicket.Text = "Registrar ticket";
            this.btnRegistrarTicket.TabIndex = 4;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Location = new System.Drawing.Point(15, 68);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(200, 32);
            this.btnNotificaciones.Text = "Notificaciones de cierre";
            this.btnNotificaciones.TabIndex = 5;
            // 
            // grpOperador
            // 
            this.grpOperador.Location = new System.Drawing.Point(270, 90);
            this.grpOperador.Name = "grpOperador";
            this.grpOperador.Size = new System.Drawing.Size(230, 115);
            this.grpOperador.Text = "Operador";
            this.grpOperador.Controls.Add(this.btnDerivarTickets);
            this.grpOperador.TabIndex = 6;
            // 
            // btnDerivarTickets
            // 
            this.btnDerivarTickets.Location = new System.Drawing.Point(15, 28);
            this.btnDerivarTickets.Name = "btnDerivarTickets";
            this.btnDerivarTickets.Size = new System.Drawing.Size(200, 32);
            this.btnDerivarTickets.Text = "Analizar y derivar tickets";
            this.btnDerivarTickets.TabIndex = 7;
            // 
            // grpTecnico
            // 
            this.grpTecnico.Location = new System.Drawing.Point(20, 215);
            this.grpTecnico.Name = "grpTecnico";
            this.grpTecnico.Size = new System.Drawing.Size(230, 80);
            this.grpTecnico.Text = "Técnico";
            this.grpTecnico.Controls.Add(this.btnResolverTickets);
            this.grpTecnico.TabIndex = 8;
            // 
            // btnResolverTickets
            // 
            this.btnResolverTickets.Location = new System.Drawing.Point(15, 28);
            this.btnResolverTickets.Name = "btnResolverTickets";
            this.btnResolverTickets.Size = new System.Drawing.Size(200, 32);
            this.btnResolverTickets.Text = "Resolver tickets asignados";
            this.btnResolverTickets.TabIndex = 9;
            // 
            // grpJefeSoporte
            // 
            this.grpJefeSoporte.Location = new System.Drawing.Point(270, 215);
            this.grpJefeSoporte.Name = "grpJefeSoporte";
            this.grpJefeSoporte.Size = new System.Drawing.Size(230, 80);
            this.grpJefeSoporte.Text = "Jefe de soporte";
            this.grpJefeSoporte.Controls.Add(this.btnEvaluarSoporte);
            this.grpJefeSoporte.TabIndex = 10;
            // 
            // btnEvaluarSoporte
            // 
            this.btnEvaluarSoporte.Location = new System.Drawing.Point(15, 28);
            this.btnEvaluarSoporte.Name = "btnEvaluarSoporte";
            this.btnEvaluarSoporte.Size = new System.Drawing.Size(200, 32);
            this.btnEvaluarSoporte.Text = "Evaluar desempeño";
            this.btnEvaluarSoporte.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(402, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.TabIndex = 12;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.CancelButton = this.btnSalir;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpOperador);
            this.Controls.Add(this.grpTecnico);
            this.Controls.Add(this.grpJefeSoporte);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetAssist - Gestión de Tickets de Soporte";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpOperador.ResumeLayout(false);
            this.grpOperador.PerformLayout();
            this.grpTecnico.ResumeLayout(false);
            this.grpTecnico.PerformLayout();
            this.grpJefeSoporte.ResumeLayout(false);
            this.grpJefeSoporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
