namespace ClinicaCAI.Atencion.MenuPrincipal
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
            this.grpRecepcion = new System.Windows.Forms.GroupBox();
            this.btnAgendarTurno = new System.Windows.Forms.Button();
            this.grpMedico = new System.Windows.Forms.GroupBox();
            this.btnAtenderPaciente = new System.Windows.Forms.Button();
            this.grpFarmacia = new System.Windows.Forms.GroupBox();
            this.btnEntregarMedicamentos = new System.Windows.Forms.Button();
            this.grpCaja = new System.Windows.Forms.GroupBox();
            this.btnCobrarConsulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpRecepcion.SuspendLayout();
            this.grpMedico.SuspendLayout();
            this.grpFarmacia.SuspendLayout();
            this.grpCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Sistema de Atención Médica - Clínica CAI";
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
            // grpRecepcion
            // 
            this.grpRecepcion.Location = new System.Drawing.Point(20, 90);
            this.grpRecepcion.Name = "grpRecepcion";
            this.grpRecepcion.Size = new System.Drawing.Size(230, 80);
            this.grpRecepcion.Text = "Recepcionista";
            this.grpRecepcion.Controls.Add(this.btnAgendarTurno);
            this.grpRecepcion.TabIndex = 3;
            // 
            // btnAgendarTurno
            // 
            this.btnAgendarTurno.Location = new System.Drawing.Point(15, 28);
            this.btnAgendarTurno.Name = "btnAgendarTurno";
            this.btnAgendarTurno.Size = new System.Drawing.Size(200, 32);
            this.btnAgendarTurno.Text = "Agendar turno";
            this.btnAgendarTurno.TabIndex = 4;
            // 
            // grpMedico
            // 
            this.grpMedico.Location = new System.Drawing.Point(270, 90);
            this.grpMedico.Name = "grpMedico";
            this.grpMedico.Size = new System.Drawing.Size(230, 80);
            this.grpMedico.Text = "Médico";
            this.grpMedico.Controls.Add(this.btnAtenderPaciente);
            this.grpMedico.TabIndex = 5;
            // 
            // btnAtenderPaciente
            // 
            this.btnAtenderPaciente.Location = new System.Drawing.Point(15, 28);
            this.btnAtenderPaciente.Name = "btnAtenderPaciente";
            this.btnAtenderPaciente.Size = new System.Drawing.Size(200, 32);
            this.btnAtenderPaciente.Text = "Atender paciente";
            this.btnAtenderPaciente.TabIndex = 6;
            // 
            // grpFarmacia
            // 
            this.grpFarmacia.Location = new System.Drawing.Point(20, 185);
            this.grpFarmacia.Name = "grpFarmacia";
            this.grpFarmacia.Size = new System.Drawing.Size(230, 80);
            this.grpFarmacia.Text = "Farmacéutico";
            this.grpFarmacia.Controls.Add(this.btnEntregarMedicamentos);
            this.grpFarmacia.TabIndex = 7;
            // 
            // btnEntregarMedicamentos
            // 
            this.btnEntregarMedicamentos.Location = new System.Drawing.Point(15, 28);
            this.btnEntregarMedicamentos.Name = "btnEntregarMedicamentos";
            this.btnEntregarMedicamentos.Size = new System.Drawing.Size(200, 32);
            this.btnEntregarMedicamentos.Text = "Entregar medicamentos";
            this.btnEntregarMedicamentos.TabIndex = 8;
            // 
            // grpCaja
            // 
            this.grpCaja.Location = new System.Drawing.Point(270, 185);
            this.grpCaja.Name = "grpCaja";
            this.grpCaja.Size = new System.Drawing.Size(230, 80);
            this.grpCaja.Text = "Cajero";
            this.grpCaja.Controls.Add(this.btnCobrarConsulta);
            this.grpCaja.TabIndex = 9;
            // 
            // btnCobrarConsulta
            // 
            this.btnCobrarConsulta.Location = new System.Drawing.Point(15, 28);
            this.btnCobrarConsulta.Name = "btnCobrarConsulta";
            this.btnCobrarConsulta.Size = new System.Drawing.Size(200, 32);
            this.btnCobrarConsulta.Text = "Cobrar consulta";
            this.btnCobrarConsulta.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(402, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.TabIndex = 11;
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
            this.Controls.Add(this.grpRecepcion);
            this.Controls.Add(this.grpMedico);
            this.Controls.Add(this.grpFarmacia);
            this.Controls.Add(this.grpCaja);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica CAI - Atención Médica";
            this.grpRecepcion.ResumeLayout(false);
            this.grpRecepcion.PerformLayout();
            this.grpMedico.ResumeLayout(false);
            this.grpMedico.PerformLayout();
            this.grpFarmacia.ResumeLayout(false);
            this.grpFarmacia.PerformLayout();
            this.grpCaja.ResumeLayout(false);
            this.grpCaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.Button btnAgendarTurno;
        private System.Windows.Forms.GroupBox grpMedico;
        private System.Windows.Forms.Button btnAtenderPaciente;
        private System.Windows.Forms.GroupBox grpFarmacia;
        private System.Windows.Forms.Button btnEntregarMedicamentos;
        private System.Windows.Forms.GroupBox grpCaja;
        private System.Windows.Forms.Button btnCobrarConsulta;
        private System.Windows.Forms.Button btnSalir;
    }
}
