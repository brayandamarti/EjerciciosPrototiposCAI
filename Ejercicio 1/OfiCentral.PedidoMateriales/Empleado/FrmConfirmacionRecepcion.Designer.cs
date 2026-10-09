namespace OfiCentral.PedidoMateriales.Formularios.Empleado
{
    partial class FrmConfirmacionRecepcion
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
            this.lblEntregasPendientes = new System.Windows.Forms.Label();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.dgvEntregasNroEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEntregasNroSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEntregasFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEntregasEntregadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEntregasCantItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEntregasEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dgvDetalleRecepcion = new System.Windows.Forms.DataGridView();
            this.dgvDetalleRecepcionMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleRecepcionCantEntregada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleRecepcionCantRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleRecepcionUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleRecepcionConforme = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpConformidad = new System.Windows.Forms.GroupBox();
            this.rbtConforme = new System.Windows.Forms.RadioButton();
            this.rbtConObservaciones = new System.Windows.Forms.RadioButton();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpConformidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRecepcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntregasPendientes
            // 
            this.lblEntregasPendientes.AutoSize = true;
            this.lblEntregasPendientes.Location = new System.Drawing.Point(15, 12);
            this.lblEntregasPendientes.Name = "lblEntregasPendientes";
            this.lblEntregasPendientes.Text = "Entregas pendientes de confirmar:";
            this.lblEntregasPendientes.TabIndex = 0;
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.Location = new System.Drawing.Point(15, 32);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.Size = new System.Drawing.Size(790, 140);
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AllowUserToDeleteRows = false;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntregas.MultiSelect = false;
            this.dgvEntregas.RowHeadersVisible = false;
            this.dgvEntregas.ReadOnly = true;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvEntregasNroEntrega, this.dgvEntregasNroSolicitud, this.dgvEntregasFechaEntrega, this.dgvEntregasEntregadoPor, this.dgvEntregasCantItems, this.dgvEntregasEstado });
            this.dgvEntregas.TabIndex = 1;
            this.dgvEntregasNroEntrega.HeaderText = "Nº entrega";
            this.dgvEntregasNroEntrega.Name = "dgvEntregasNroEntrega";
            this.dgvEntregasNroEntrega.Width = 100;
            this.dgvEntregasNroSolicitud.HeaderText = "Nº solicitud";
            this.dgvEntregasNroSolicitud.Name = "dgvEntregasNroSolicitud";
            this.dgvEntregasNroSolicitud.Width = 100;
            this.dgvEntregasFechaEntrega.HeaderText = "Fecha entrega";
            this.dgvEntregasFechaEntrega.Name = "dgvEntregasFechaEntrega";
            this.dgvEntregasFechaEntrega.Width = 120;
            this.dgvEntregasEntregadoPor.HeaderText = "Entregado por";
            this.dgvEntregasEntregadoPor.Name = "dgvEntregasEntregadoPor";
            this.dgvEntregasEntregadoPor.Width = 200;
            this.dgvEntregasCantItems.HeaderText = "Cant. ítems";
            this.dgvEntregasCantItems.Name = "dgvEntregasCantItems";
            this.dgvEntregasCantItems.Width = 100;
            this.dgvEntregasEstado.HeaderText = "Estado";
            this.dgvEntregasEstado.Name = "dgvEntregasEstado";
            this.dgvEntregasEstado.Width = 170;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(15, 182);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Text = "Detalle de la entrega seleccionada:";
            this.lblDetalle.TabIndex = 2;
            // 
            // dgvDetalleRecepcion
            // 
            this.dgvDetalleRecepcion.Location = new System.Drawing.Point(15, 202);
            this.dgvDetalleRecepcion.Name = "dgvDetalleRecepcion";
            this.dgvDetalleRecepcion.Size = new System.Drawing.Size(790, 180);
            this.dgvDetalleRecepcion.AllowUserToAddRows = false;
            this.dgvDetalleRecepcion.AllowUserToDeleteRows = false;
            this.dgvDetalleRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleRecepcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleRecepcion.MultiSelect = false;
            this.dgvDetalleRecepcion.RowHeadersVisible = false;
            this.dgvDetalleRecepcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvDetalleRecepcionMaterial, this.dgvDetalleRecepcionCantEntregada, this.dgvDetalleRecepcionCantRecibida, this.dgvDetalleRecepcionUnidad, this.dgvDetalleRecepcionConforme });
            this.dgvDetalleRecepcion.TabIndex = 3;
            this.dgvDetalleRecepcionMaterial.HeaderText = "Material";
            this.dgvDetalleRecepcionMaterial.Name = "dgvDetalleRecepcionMaterial";
            this.dgvDetalleRecepcionMaterial.Width = 280;
            this.dgvDetalleRecepcionMaterial.ReadOnly = true;
            this.dgvDetalleRecepcionCantEntregada.HeaderText = "Cant. entregada";
            this.dgvDetalleRecepcionCantEntregada.Name = "dgvDetalleRecepcionCantEntregada";
            this.dgvDetalleRecepcionCantEntregada.Width = 130;
            this.dgvDetalleRecepcionCantEntregada.ReadOnly = true;
            this.dgvDetalleRecepcionCantRecibida.HeaderText = "Cant. recibida";
            this.dgvDetalleRecepcionCantRecibida.Name = "dgvDetalleRecepcionCantRecibida";
            this.dgvDetalleRecepcionCantRecibida.Width = 130;
            this.dgvDetalleRecepcionUnidad.HeaderText = "Unidad";
            this.dgvDetalleRecepcionUnidad.Name = "dgvDetalleRecepcionUnidad";
            this.dgvDetalleRecepcionUnidad.Width = 100;
            this.dgvDetalleRecepcionUnidad.ReadOnly = true;
            this.dgvDetalleRecepcionConforme.HeaderText = "Conforme";
            this.dgvDetalleRecepcionConforme.Name = "dgvDetalleRecepcionConforme";
            this.dgvDetalleRecepcionConforme.Width = 100;
            // 
            // grpConformidad
            // 
            this.grpConformidad.Location = new System.Drawing.Point(15, 392);
            this.grpConformidad.Name = "grpConformidad";
            this.grpConformidad.Size = new System.Drawing.Size(790, 180);
            this.grpConformidad.Text = "Conformidad";
            this.grpConformidad.Controls.Add(this.rbtConforme);
            this.grpConformidad.Controls.Add(this.rbtConObservaciones);
            this.grpConformidad.Controls.Add(this.lblObservaciones);
            this.grpConformidad.Controls.Add(this.txtObservaciones);
            this.grpConformidad.TabIndex = 4;
            // 
            // rbtConforme
            // 
            this.rbtConforme.Location = new System.Drawing.Point(15, 28);
            this.rbtConforme.Name = "rbtConforme";
            this.rbtConforme.Size = new System.Drawing.Size(200, 24);
            this.rbtConforme.Text = "Recepción conforme";
            this.rbtConforme.Checked = true;
            this.rbtConforme.TabIndex = 5;
            // 
            // rbtConObservaciones
            // 
            this.rbtConObservaciones.Location = new System.Drawing.Point(240, 28);
            this.rbtConObservaciones.Name = "rbtConObservaciones";
            this.rbtConObservaciones.Size = new System.Drawing.Size(230, 24);
            this.rbtConObservaciones.Text = "Recepción con observaciones";
            this.rbtConObservaciones.TabIndex = 6;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(15, 62);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 82);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(760, 80);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(584, 594);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(702, 594);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 10;
            // 
            // FrmConfirmacionRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblEntregasPendientes);
            this.Controls.Add(this.dgvEntregas);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.dgvDetalleRecepcion);
            this.Controls.Add(this.grpConformidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConfirmacionRecepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar recepción de materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRecepcion)).EndInit();
            this.grpConformidad.ResumeLayout(false);
            this.grpConformidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEntregasPendientes;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEntregasNroEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEntregasNroSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEntregasFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEntregasEntregadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEntregasCantItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEntregasEstado;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleRecepcionMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleRecepcionCantEntregada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleRecepcionCantRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDetalleRecepcionUnidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvDetalleRecepcionConforme;
        private System.Windows.Forms.GroupBox grpConformidad;
        private System.Windows.Forms.RadioButton rbtConforme;
        private System.Windows.Forms.RadioButton rbtConObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
