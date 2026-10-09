namespace OfiCentral.PedidoMateriales.Formularios
{
    partial class FrmMenuPrincipal
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
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.btnNuevaSolicitud = new System.Windows.Forms.Button();
            this.btnConfirmarRecepcion = new System.Windows.Forms.Button();
            this.grpJefeArea = new System.Windows.Forms.GroupBox();
            this.btnAprobarSolicitudes = new System.Windows.Forms.Button();
            this.grpCompras = new System.Windows.Forms.GroupBox();
            this.btnGenerarOrden = new System.Windows.Forms.Button();
            this.grpDeposito = new System.Windows.Forms.GroupBox();
            this.btnRegistrarEntrega = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpEmpleado.SuspendLayout();
            this.grpJefeArea.SuspendLayout();
            this.grpCompras.SuspendLayout();
            this.grpDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Sistema de Pedido de Materiales de Oficina";
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
            // grpEmpleado
            // 
            this.grpEmpleado.Location = new System.Drawing.Point(20, 90);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(230, 115);
            this.grpEmpleado.Text = "Empleado";
            this.grpEmpleado.Controls.Add(this.btnNuevaSolicitud);
            this.grpEmpleado.Controls.Add(this.btnConfirmarRecepcion);
            this.grpEmpleado.TabIndex = 3;
            // 
            // btnNuevaSolicitud
            // 
            this.btnNuevaSolicitud.Location = new System.Drawing.Point(15, 28);
            this.btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            this.btnNuevaSolicitud.Size = new System.Drawing.Size(200, 32);
            this.btnNuevaSolicitud.Text = "Nueva solicitud";
            this.btnNuevaSolicitud.TabIndex = 4;
            // 
            // btnConfirmarRecepcion
            // 
            this.btnConfirmarRecepcion.Location = new System.Drawing.Point(15, 68);
            this.btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            this.btnConfirmarRecepcion.Size = new System.Drawing.Size(200, 32);
            this.btnConfirmarRecepcion.Text = "Confirmar recepción";
            this.btnConfirmarRecepcion.TabIndex = 5;
            // 
            // grpJefeArea
            // 
            this.grpJefeArea.Location = new System.Drawing.Point(270, 90);
            this.grpJefeArea.Name = "grpJefeArea";
            this.grpJefeArea.Size = new System.Drawing.Size(230, 115);
            this.grpJefeArea.Text = "Jefe de área";
            this.grpJefeArea.Controls.Add(this.btnAprobarSolicitudes);
            this.grpJefeArea.TabIndex = 6;
            // 
            // btnAprobarSolicitudes
            // 
            this.btnAprobarSolicitudes.Location = new System.Drawing.Point(15, 28);
            this.btnAprobarSolicitudes.Name = "btnAprobarSolicitudes";
            this.btnAprobarSolicitudes.Size = new System.Drawing.Size(200, 32);
            this.btnAprobarSolicitudes.Text = "Aprobar solicitudes";
            this.btnAprobarSolicitudes.TabIndex = 7;
            // 
            // grpCompras
            // 
            this.grpCompras.Location = new System.Drawing.Point(20, 215);
            this.grpCompras.Name = "grpCompras";
            this.grpCompras.Size = new System.Drawing.Size(230, 80);
            this.grpCompras.Text = "Encargado de compras";
            this.grpCompras.Controls.Add(this.btnGenerarOrden);
            this.grpCompras.TabIndex = 8;
            // 
            // btnGenerarOrden
            // 
            this.btnGenerarOrden.Location = new System.Drawing.Point(15, 28);
            this.btnGenerarOrden.Name = "btnGenerarOrden";
            this.btnGenerarOrden.Size = new System.Drawing.Size(200, 32);
            this.btnGenerarOrden.Text = "Generar orden de compra";
            this.btnGenerarOrden.TabIndex = 9;
            // 
            // grpDeposito
            // 
            this.grpDeposito.Location = new System.Drawing.Point(270, 215);
            this.grpDeposito.Name = "grpDeposito";
            this.grpDeposito.Size = new System.Drawing.Size(230, 80);
            this.grpDeposito.Text = "Depósito";
            this.grpDeposito.Controls.Add(this.btnRegistrarEntrega);
            this.grpDeposito.TabIndex = 10;
            // 
            // btnRegistrarEntrega
            // 
            this.btnRegistrarEntrega.Location = new System.Drawing.Point(15, 28);
            this.btnRegistrarEntrega.Name = "btnRegistrarEntrega";
            this.btnRegistrarEntrega.Size = new System.Drawing.Size(200, 32);
            this.btnRegistrarEntrega.Text = "Registrar entrega";
            this.btnRegistrarEntrega.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(402, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.Text = "Salir";
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.TabIndex = 12;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.CancelButton = this.btnSalir;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.grpJefeArea);
            this.Controls.Add(this.grpCompras);
            this.Controls.Add(this.grpDeposito);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfiCentral S.A. - Pedido de Materiales";
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            this.grpJefeArea.ResumeLayout(false);
            this.grpJefeArea.PerformLayout();
            this.grpCompras.ResumeLayout(false);
            this.grpCompras.PerformLayout();
            this.grpDeposito.ResumeLayout(false);
            this.grpDeposito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.Button btnNuevaSolicitud;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.GroupBox grpJefeArea;
        private System.Windows.Forms.Button btnAprobarSolicitudes;
        private System.Windows.Forms.GroupBox grpCompras;
        private System.Windows.Forms.Button btnGenerarOrden;
        private System.Windows.Forms.GroupBox grpDeposito;
        private System.Windows.Forms.Button btnRegistrarEntrega;
        private System.Windows.Forms.Button btnSalir;
    }
}
