namespace NetAssist.Tickets.NotificacionCierre
{
    partial class NotificacionCierreForm
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
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.dgvNotificacionesNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotificacionesAsunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotificacionesFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotificacionesFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNotificacionesTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetalleCierre = new System.Windows.Forms.GroupBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.lblTiempoResolucion = new System.Windows.Forms.Label();
            this.txtTiempoResolucion = new System.Windows.Forms.TextBox();
            this.lblSolucion = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.grpEncuesta = new System.Windows.Forms.GroupBox();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.rbtMuyBuena = new System.Windows.Forms.RadioButton();
            this.rbtBuena = new System.Windows.Forms.RadioButton();
            this.rbtRegular = new System.Windows.Forms.RadioButton();
            this.rbtMala = new System.Windows.Forms.RadioButton();
            this.lblProblemaResuelto = new System.Windows.Forms.Label();
            this.cmbProblemaResuelto = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDetalleCierre.SuspendLayout();
            this.grpEncuesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Location = new System.Drawing.Point(15, 12);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Text = "Tickets cerrados:";
            this.lblNotificaciones.TabIndex = 0;
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.Location = new System.Drawing.Point(15, 32);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(750, 140);
            this.dgvNotificaciones.AllowUserToAddRows = false;
            this.dgvNotificaciones.AllowUserToDeleteRows = false;
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotificaciones.MultiSelect = false;
            this.dgvNotificaciones.RowHeadersVisible = false;
            this.dgvNotificaciones.ReadOnly = true;
            this.dgvNotificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvNotificacionesNroTicket, this.dgvNotificacionesAsunto, this.dgvNotificacionesFechaAlta, this.dgvNotificacionesFechaCierre, this.dgvNotificacionesTecnico });
            this.dgvNotificaciones.TabIndex = 1;
            this.dgvNotificacionesNroTicket.HeaderText = "Nº ticket";
            this.dgvNotificacionesNroTicket.Name = "dgvNotificacionesNroTicket";
            this.dgvNotificacionesNroTicket.Width = 90;
            this.dgvNotificacionesAsunto.HeaderText = "Asunto";
            this.dgvNotificacionesAsunto.Name = "dgvNotificacionesAsunto";
            this.dgvNotificacionesAsunto.Width = 260;
            this.dgvNotificacionesFechaAlta.HeaderText = "Fecha alta";
            this.dgvNotificacionesFechaAlta.Name = "dgvNotificacionesFechaAlta";
            this.dgvNotificacionesFechaAlta.Width = 110;
            this.dgvNotificacionesFechaCierre.HeaderText = "Fecha cierre";
            this.dgvNotificacionesFechaCierre.Name = "dgvNotificacionesFechaCierre";
            this.dgvNotificacionesFechaCierre.Width = 110;
            this.dgvNotificacionesTecnico.HeaderText = "Técnico";
            this.dgvNotificacionesTecnico.Name = "dgvNotificacionesTecnico";
            this.dgvNotificacionesTecnico.Width = 177;
            // 
            // grpDetalleCierre
            // 
            this.grpDetalleCierre.Location = new System.Drawing.Point(15, 182);
            this.grpDetalleCierre.Name = "grpDetalleCierre";
            this.grpDetalleCierre.Size = new System.Drawing.Size(750, 150);
            this.grpDetalleCierre.Text = "Detalle del cierre";
            this.grpDetalleCierre.Controls.Add(this.lblTecnico);
            this.grpDetalleCierre.Controls.Add(this.txtTecnico);
            this.grpDetalleCierre.Controls.Add(this.lblTiempoResolucion);
            this.grpDetalleCierre.Controls.Add(this.txtTiempoResolucion);
            this.grpDetalleCierre.Controls.Add(this.lblSolucion);
            this.grpDetalleCierre.Controls.Add(this.txtSolucion);
            this.grpDetalleCierre.TabIndex = 2;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(15, 30);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Text = "Técnico:";
            this.lblTecnico.TabIndex = 3;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(120, 27);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(250, 23);
            this.txtTecnico.ReadOnly = true;
            this.txtTecnico.TabIndex = 4;
            // 
            // lblTiempoResolucion
            // 
            this.lblTiempoResolucion.AutoSize = true;
            this.lblTiempoResolucion.Location = new System.Drawing.Point(390, 30);
            this.lblTiempoResolucion.Name = "lblTiempoResolucion";
            this.lblTiempoResolucion.Text = "Tiempo total:";
            this.lblTiempoResolucion.TabIndex = 5;
            // 
            // txtTiempoResolucion
            // 
            this.txtTiempoResolucion.Location = new System.Drawing.Point(490, 27);
            this.txtTiempoResolucion.Name = "txtTiempoResolucion";
            this.txtTiempoResolucion.Size = new System.Drawing.Size(240, 23);
            this.txtTiempoResolucion.ReadOnly = true;
            this.txtTiempoResolucion.TabIndex = 6;
            // 
            // lblSolucion
            // 
            this.lblSolucion.AutoSize = true;
            this.lblSolucion.Location = new System.Drawing.Point(15, 66);
            this.lblSolucion.Name = "lblSolucion";
            this.lblSolucion.Text = "Solución:";
            this.lblSolucion.TabIndex = 7;
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(120, 63);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(610, 70);
            this.txtSolucion.ReadOnly = true;
            this.txtSolucion.Multiline = true;
            this.txtSolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolucion.TabIndex = 8;
            // 
            // grpEncuesta
            // 
            this.grpEncuesta.Location = new System.Drawing.Point(15, 340);
            this.grpEncuesta.Name = "grpEncuesta";
            this.grpEncuesta.Size = new System.Drawing.Size(750, 200);
            this.grpEncuesta.Text = "Encuesta de satisfacción";
            this.grpEncuesta.Controls.Add(this.lblSatisfaccion);
            this.grpEncuesta.Controls.Add(this.rbtMuyBuena);
            this.grpEncuesta.Controls.Add(this.rbtBuena);
            this.grpEncuesta.Controls.Add(this.rbtRegular);
            this.grpEncuesta.Controls.Add(this.rbtMala);
            this.grpEncuesta.Controls.Add(this.lblProblemaResuelto);
            this.grpEncuesta.Controls.Add(this.cmbProblemaResuelto);
            this.grpEncuesta.Controls.Add(this.lblComentario);
            this.grpEncuesta.Controls.Add(this.txtComentario);
            this.grpEncuesta.TabIndex = 9;
            // 
            // lblSatisfaccion
            // 
            this.lblSatisfaccion.AutoSize = true;
            this.lblSatisfaccion.Location = new System.Drawing.Point(15, 30);
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            this.lblSatisfaccion.Text = "¿Cómo califica la atención recibida?";
            this.lblSatisfaccion.TabIndex = 10;
            // 
            // rbtMuyBuena
            // 
            this.rbtMuyBuena.Location = new System.Drawing.Point(15, 55);
            this.rbtMuyBuena.Name = "rbtMuyBuena";
            this.rbtMuyBuena.Size = new System.Drawing.Size(110, 24);
            this.rbtMuyBuena.Text = "Muy buena";
            this.rbtMuyBuena.TabIndex = 11;
            // 
            // rbtBuena
            // 
            this.rbtBuena.Location = new System.Drawing.Point(135, 55);
            this.rbtBuena.Name = "rbtBuena";
            this.rbtBuena.Size = new System.Drawing.Size(90, 24);
            this.rbtBuena.Text = "Buena";
            this.rbtBuena.Checked = true;
            this.rbtBuena.TabIndex = 12;
            // 
            // rbtRegular
            // 
            this.rbtRegular.Location = new System.Drawing.Point(235, 55);
            this.rbtRegular.Name = "rbtRegular";
            this.rbtRegular.Size = new System.Drawing.Size(90, 24);
            this.rbtRegular.Text = "Regular";
            this.rbtRegular.TabIndex = 13;
            // 
            // rbtMala
            // 
            this.rbtMala.Location = new System.Drawing.Point(335, 55);
            this.rbtMala.Name = "rbtMala";
            this.rbtMala.Size = new System.Drawing.Size(90, 24);
            this.rbtMala.Text = "Mala";
            this.rbtMala.TabIndex = 14;
            // 
            // lblProblemaResuelto
            // 
            this.lblProblemaResuelto.AutoSize = true;
            this.lblProblemaResuelto.Location = new System.Drawing.Point(470, 30);
            this.lblProblemaResuelto.Name = "lblProblemaResuelto";
            this.lblProblemaResuelto.Text = "¿Se resolvió el problema?";
            this.lblProblemaResuelto.TabIndex = 15;
            // 
            // cmbProblemaResuelto
            // 
            this.cmbProblemaResuelto.Location = new System.Drawing.Point(470, 53);
            this.cmbProblemaResuelto.Name = "cmbProblemaResuelto";
            this.cmbProblemaResuelto.Size = new System.Drawing.Size(260, 23);
            this.cmbProblemaResuelto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProblemaResuelto.Items.AddRange(new object[] { "Sí", "Parcialmente", "No" });
            this.cmbProblemaResuelto.TabIndex = 16;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(15, 92);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Text = "Comentarios:";
            this.lblComentario.TabIndex = 17;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(15, 112);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(715, 70);
            this.txtComentario.Multiline = true;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(544, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Enviar";
            this.btnAceptar.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 20;
            // 
            // NotificacionCierreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 600);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.grpDetalleCierre);
            this.Controls.Add(this.grpEncuesta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NotificacionCierreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones de cierre de tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.grpDetalleCierre.ResumeLayout(false);
            this.grpDetalleCierre.PerformLayout();
            this.grpEncuesta.ResumeLayout(false);
            this.grpEncuesta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNotificacionesNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNotificacionesAsunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNotificacionesFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNotificacionesFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNotificacionesTecnico;
        private System.Windows.Forms.GroupBox grpDetalleCierre;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Label lblTiempoResolucion;
        private System.Windows.Forms.TextBox txtTiempoResolucion;
        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.GroupBox grpEncuesta;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.RadioButton rbtMuyBuena;
        private System.Windows.Forms.RadioButton rbtBuena;
        private System.Windows.Forms.RadioButton rbtRegular;
        private System.Windows.Forms.RadioButton rbtMala;
        private System.Windows.Forms.Label lblProblemaResuelto;
        private System.Windows.Forms.ComboBox cmbProblemaResuelto;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
