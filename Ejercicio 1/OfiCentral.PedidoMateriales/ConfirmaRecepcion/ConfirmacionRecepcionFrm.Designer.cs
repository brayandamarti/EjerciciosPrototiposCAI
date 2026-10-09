namespace OfiCentral.PedidoMateriales.Formularios.Empleado
{
    partial class ConfirmacionRecepcionFrm
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
            lblEntregasPendientes = new Label();
            dgvEntregas = new DataGridView();
            dgvEntregasNroEntrega = new DataGridViewTextBoxColumn();
            dgvEntregasNroSolicitud = new DataGridViewTextBoxColumn();
            dgvEntregasFechaEntrega = new DataGridViewTextBoxColumn();
            dgvEntregasEntregadoPor = new DataGridViewTextBoxColumn();
            dgvEntregasCantItems = new DataGridViewTextBoxColumn();
            dgvEntregasEstado = new DataGridViewTextBoxColumn();
            lblDetalle = new Label();
            dgvDetalleRecepcion = new DataGridView();
            grpConformidad = new GroupBox();
            rbtConforme = new RadioButton();
            rbtConObservaciones = new RadioButton();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dgvDetalleRecepcionMaterial = new DataGridViewTextBoxColumn();
            dgvDetalleRecepcionCantEntregada = new DataGridViewTextBoxColumn();
            dgvDetalleRecepcionCantRecibida = new DataGridViewTextBoxColumn();
            dgvDetalleRecepcionUnidad = new DataGridViewTextBoxColumn();
            dgvDetalleRecepcionConforme = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleRecepcion).BeginInit();
            grpConformidad.SuspendLayout();
            SuspendLayout();
            // 
            // lblEntregasPendientes
            // 
            lblEntregasPendientes.AutoSize = true;
            lblEntregasPendientes.Location = new Point(15, 12);
            lblEntregasPendientes.Name = "lblEntregasPendientes";
            lblEntregasPendientes.Size = new Size(187, 15);
            lblEntregasPendientes.TabIndex = 0;
            lblEntregasPendientes.Text = "Entregas pendientes de confirmar:";
            // 
            // dgvEntregas
            // 
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.AllowUserToDeleteRows = false;
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntregas.Columns.AddRange(new DataGridViewColumn[] { dgvEntregasNroEntrega, dgvEntregasNroSolicitud, dgvEntregasFechaEntrega, dgvEntregasEntregadoPor, dgvEntregasCantItems, dgvEntregasEstado });
            dgvEntregas.Location = new Point(15, 32);
            dgvEntregas.MultiSelect = false;
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.RowHeadersVisible = false;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.Size = new Size(790, 140);
            dgvEntregas.TabIndex = 1;
            // 
            // dgvEntregasNroEntrega
            // 
            dgvEntregasNroEntrega.HeaderText = "Nº entrega";
            dgvEntregasNroEntrega.Name = "dgvEntregasNroEntrega";
            dgvEntregasNroEntrega.ReadOnly = true;
            // 
            // dgvEntregasNroSolicitud
            // 
            dgvEntregasNroSolicitud.HeaderText = "Nº solicitud";
            dgvEntregasNroSolicitud.Name = "dgvEntregasNroSolicitud";
            dgvEntregasNroSolicitud.ReadOnly = true;
            // 
            // dgvEntregasFechaEntrega
            // 
            dgvEntregasFechaEntrega.HeaderText = "Fecha entrega";
            dgvEntregasFechaEntrega.Name = "dgvEntregasFechaEntrega";
            dgvEntregasFechaEntrega.ReadOnly = true;
            dgvEntregasFechaEntrega.Width = 120;
            // 
            // dgvEntregasEntregadoPor
            // 
            dgvEntregasEntregadoPor.HeaderText = "Entregado por";
            dgvEntregasEntregadoPor.Name = "dgvEntregasEntregadoPor";
            dgvEntregasEntregadoPor.ReadOnly = true;
            dgvEntregasEntregadoPor.Width = 200;
            // 
            // dgvEntregasCantItems
            // 
            dgvEntregasCantItems.HeaderText = "Cant. ítems";
            dgvEntregasCantItems.Name = "dgvEntregasCantItems";
            dgvEntregasCantItems.ReadOnly = true;
            // 
            // dgvEntregasEstado
            // 
            dgvEntregasEstado.HeaderText = "Estado";
            dgvEntregasEstado.Name = "dgvEntregasEstado";
            dgvEntregasEstado.ReadOnly = true;
            dgvEntregasEstado.Width = 170;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(15, 182);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(188, 15);
            lblDetalle.TabIndex = 2;
            lblDetalle.Text = "Detalle de la entrega seleccionada:";
            // 
            // dgvDetalleRecepcion
            // 
            dgvDetalleRecepcion.AllowUserToAddRows = false;
            dgvDetalleRecepcion.AllowUserToDeleteRows = false;
            dgvDetalleRecepcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleRecepcion.Columns.AddRange(new DataGridViewColumn[] { dgvDetalleRecepcionMaterial, dgvDetalleRecepcionCantEntregada, dgvDetalleRecepcionCantRecibida, dgvDetalleRecepcionUnidad, dgvDetalleRecepcionConforme });
            dgvDetalleRecepcion.Location = new Point(15, 202);
            dgvDetalleRecepcion.MultiSelect = false;
            dgvDetalleRecepcion.Name = "dgvDetalleRecepcion";
            dgvDetalleRecepcion.RowHeadersVisible = false;
            dgvDetalleRecepcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleRecepcion.Size = new Size(790, 180);
            dgvDetalleRecepcion.TabIndex = 3;
            // 
            // grpConformidad
            // 
            grpConformidad.Controls.Add(rbtConforme);
            grpConformidad.Controls.Add(rbtConObservaciones);
            grpConformidad.Controls.Add(lblObservaciones);
            grpConformidad.Controls.Add(txtObservaciones);
            grpConformidad.Location = new Point(15, 392);
            grpConformidad.Name = "grpConformidad";
            grpConformidad.Size = new Size(790, 180);
            grpConformidad.TabIndex = 4;
            grpConformidad.TabStop = false;
            grpConformidad.Text = "Conformidad";
            // 
            // rbtConforme
            // 
            rbtConforme.Checked = true;
            rbtConforme.Location = new Point(15, 28);
            rbtConforme.Name = "rbtConforme";
            rbtConforme.Size = new Size(200, 24);
            rbtConforme.TabIndex = 5;
            rbtConforme.TabStop = true;
            rbtConforme.Text = "Recepción conforme";
            // 
            // rbtConObservaciones
            // 
            rbtConObservaciones.Location = new Point(240, 28);
            rbtConObservaciones.Name = "rbtConObservaciones";
            rbtConObservaciones.Size = new Size(230, 24);
            rbtConObservaciones.TabIndex = 6;
            rbtConObservaciones.Text = "Recepción con observaciones";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(15, 62);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(87, 15);
            lblObservaciones.TabIndex = 7;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(15, 82);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(760, 80);
            txtObservaciones.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(584, 594);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 30);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Confirmar";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(702, 594);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            // 
            // dgvDetalleRecepcionMaterial
            // 
            dgvDetalleRecepcionMaterial.HeaderText = "Material";
            dgvDetalleRecepcionMaterial.Name = "dgvDetalleRecepcionMaterial";
            dgvDetalleRecepcionMaterial.ReadOnly = true;
            dgvDetalleRecepcionMaterial.Width = 280;
            // 
            // dgvDetalleRecepcionCantEntregada
            // 
            dgvDetalleRecepcionCantEntregada.HeaderText = "Cant. entregada";
            dgvDetalleRecepcionCantEntregada.Name = "dgvDetalleRecepcionCantEntregada";
            dgvDetalleRecepcionCantEntregada.ReadOnly = true;
            dgvDetalleRecepcionCantEntregada.Width = 130;
            // 
            // dgvDetalleRecepcionCantRecibida
            // 
            dgvDetalleRecepcionCantRecibida.HeaderText = "Cant. recibida";
            dgvDetalleRecepcionCantRecibida.Name = "dgvDetalleRecepcionCantRecibida";
            dgvDetalleRecepcionCantRecibida.Width = 130;
            // 
            // dgvDetalleRecepcionUnidad
            // 
            dgvDetalleRecepcionUnidad.HeaderText = "Unidad";
            dgvDetalleRecepcionUnidad.Name = "dgvDetalleRecepcionUnidad";
            dgvDetalleRecepcionUnidad.ReadOnly = true;
            // 
            // dgvDetalleRecepcionConforme
            // 
            dgvDetalleRecepcionConforme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalleRecepcionConforme.HeaderText = "Conforme";
            dgvDetalleRecepcionConforme.Name = "dgvDetalleRecepcionConforme";
            // 
            // ConfirmacionRecepcionFrm
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(820, 640);
            Controls.Add(lblEntregasPendientes);
            Controls.Add(dgvEntregas);
            Controls.Add(lblDetalle);
            Controls.Add(dgvDetalleRecepcion);
            Controls.Add(grpConformidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ConfirmacionRecepcionFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar recepción de materiales";
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleRecepcion).EndInit();
            grpConformidad.ResumeLayout(false);
            grpConformidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.GroupBox grpConformidad;
        private System.Windows.Forms.RadioButton rbtConforme;
        private System.Windows.Forms.RadioButton rbtConObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DataGridViewTextBoxColumn dgvDetalleRecepcionMaterial;
        private DataGridViewTextBoxColumn dgvDetalleRecepcionCantEntregada;
        private DataGridViewTextBoxColumn dgvDetalleRecepcionCantRecibida;
        private DataGridViewTextBoxColumn dgvDetalleRecepcionUnidad;
        private DataGridViewCheckBoxColumn dgvDetalleRecepcionConforme;
    }
}
