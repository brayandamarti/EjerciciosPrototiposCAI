namespace OfiCentral.PedidoMateriales.Formularios.Deposito
{
    partial class FrmEntregaMateriales
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
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblNroSolicitud = new System.Windows.Forms.Label();
            this.txtNroSolicitud = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.txtNroOrden = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvItemsEntrega = new System.Windows.Forms.DataGridView();
            this.dgvItemsEntregaMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsEntregaCantAprobada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsEntregaCantRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsEntregaCantEntregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsEntregaPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsEntregaUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatosEntrega = new System.Windows.Forms.GroupBox();
            this.lblNroEntrega = new System.Windows.Forms.Label();
            this.txtNroEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBuscar.SuspendLayout();
            this.grpDatosEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Location = new System.Drawing.Point(15, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(810, 110);
            this.grpBuscar.Text = "Buscar solicitud";
            this.grpBuscar.Controls.Add(this.lblNroSolicitud);
            this.grpBuscar.Controls.Add(this.txtNroSolicitud);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.lblNroOrden);
            this.grpBuscar.Controls.Add(this.txtNroOrden);
            this.grpBuscar.Controls.Add(this.lblEstado);
            this.grpBuscar.Controls.Add(this.txtEstado);
            this.grpBuscar.Controls.Add(this.lblEmpleado);
            this.grpBuscar.Controls.Add(this.txtEmpleado);
            this.grpBuscar.Controls.Add(this.lblArea);
            this.grpBuscar.Controls.Add(this.txtArea);
            this.grpBuscar.TabIndex = 0;
            // 
            // lblNroSolicitud
            // 
            this.lblNroSolicitud.AutoSize = true;
            this.lblNroSolicitud.Location = new System.Drawing.Point(15, 32);
            this.lblNroSolicitud.Name = "lblNroSolicitud";
            this.lblNroSolicitud.Text = "Nº de solicitud:";
            this.lblNroSolicitud.TabIndex = 1;
            // 
            // txtNroSolicitud
            // 
            this.txtNroSolicitud.Location = new System.Drawing.Point(125, 29);
            this.txtNroSolicitud.Name = "txtNroSolicitud";
            this.txtNroSolicitud.Size = new System.Drawing.Size(120, 23);
            this.txtNroSolicitud.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(260, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TabIndex = 3;
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Location = new System.Drawing.Point(390, 32);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Text = "Nº orden compra:";
            this.lblNroOrden.TabIndex = 4;
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.Location = new System.Drawing.Point(505, 29);
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.Size = new System.Drawing.Size(120, 23);
            this.txtNroOrden.ReadOnly = true;
            this.txtNroOrden.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(640, 32);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TabIndex = 6;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(695, 29);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 23);
            this.txtEstado.ReadOnly = true;
            this.txtEstado.TabIndex = 7;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 72);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Text = "Solicitante:";
            this.lblEmpleado.TabIndex = 8;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(125, 69);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(230, 23);
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.TabIndex = 9;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(390, 72);
            this.lblArea.Name = "lblArea";
            this.lblArea.Text = "Área:";
            this.lblArea.TabIndex = 10;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(505, 69);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(290, 23);
            this.txtArea.ReadOnly = true;
            this.txtArea.TabIndex = 11;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(15, 132);
            this.lblItems.Name = "lblItems";
            this.lblItems.Text = "Materiales a entregar:";
            this.lblItems.TabIndex = 12;
            // 
            // dgvItemsEntrega
            // 
            this.dgvItemsEntrega.Location = new System.Drawing.Point(15, 152);
            this.dgvItemsEntrega.Name = "dgvItemsEntrega";
            this.dgvItemsEntrega.Size = new System.Drawing.Size(810, 220);
            this.dgvItemsEntrega.AllowUserToAddRows = false;
            this.dgvItemsEntrega.AllowUserToDeleteRows = false;
            this.dgvItemsEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsEntrega.MultiSelect = false;
            this.dgvItemsEntrega.RowHeadersVisible = false;
            this.dgvItemsEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvItemsEntregaMaterial, this.dgvItemsEntregaCantAprobada, this.dgvItemsEntregaCantRecibida, this.dgvItemsEntregaCantEntregar, this.dgvItemsEntregaPendiente, this.dgvItemsEntregaUnidad });
            this.dgvItemsEntrega.TabIndex = 13;
            this.dgvItemsEntregaMaterial.HeaderText = "Material";
            this.dgvItemsEntregaMaterial.Name = "dgvItemsEntregaMaterial";
            this.dgvItemsEntregaMaterial.Width = 260;
            this.dgvItemsEntregaMaterial.ReadOnly = true;
            this.dgvItemsEntregaCantAprobada.HeaderText = "Cant. aprobada";
            this.dgvItemsEntregaCantAprobada.Name = "dgvItemsEntregaCantAprobada";
            this.dgvItemsEntregaCantAprobada.Width = 120;
            this.dgvItemsEntregaCantAprobada.ReadOnly = true;
            this.dgvItemsEntregaCantRecibida.HeaderText = "Recibido de compra";
            this.dgvItemsEntregaCantRecibida.Name = "dgvItemsEntregaCantRecibida";
            this.dgvItemsEntregaCantRecibida.Width = 130;
            this.dgvItemsEntregaCantRecibida.ReadOnly = true;
            this.dgvItemsEntregaCantEntregar.HeaderText = "Cant. a entregar";
            this.dgvItemsEntregaCantEntregar.Name = "dgvItemsEntregaCantEntregar";
            this.dgvItemsEntregaCantEntregar.Width = 120;
            this.dgvItemsEntregaPendiente.HeaderText = "Pendiente";
            this.dgvItemsEntregaPendiente.Name = "dgvItemsEntregaPendiente";
            this.dgvItemsEntregaPendiente.Width = 90;
            this.dgvItemsEntregaPendiente.ReadOnly = true;
            this.dgvItemsEntregaUnidad.HeaderText = "Unidad";
            this.dgvItemsEntregaUnidad.Name = "dgvItemsEntregaUnidad";
            this.dgvItemsEntregaUnidad.Width = 88;
            this.dgvItemsEntregaUnidad.ReadOnly = true;
            // 
            // grpDatosEntrega
            // 
            this.grpDatosEntrega.Location = new System.Drawing.Point(15, 382);
            this.grpDatosEntrega.Name = "grpDatosEntrega";
            this.grpDatosEntrega.Size = new System.Drawing.Size(810, 175);
            this.grpDatosEntrega.Text = "Datos de la entrega";
            this.grpDatosEntrega.Controls.Add(this.lblNroEntrega);
            this.grpDatosEntrega.Controls.Add(this.txtNroEntrega);
            this.grpDatosEntrega.Controls.Add(this.lblFechaEntrega);
            this.grpDatosEntrega.Controls.Add(this.dtpFechaEntrega);
            this.grpDatosEntrega.Controls.Add(this.lblResponsable);
            this.grpDatosEntrega.Controls.Add(this.cmbResponsable);
            this.grpDatosEntrega.Controls.Add(this.lblObservaciones);
            this.grpDatosEntrega.Controls.Add(this.txtObservaciones);
            this.grpDatosEntrega.TabIndex = 14;
            // 
            // lblNroEntrega
            // 
            this.lblNroEntrega.AutoSize = true;
            this.lblNroEntrega.Location = new System.Drawing.Point(15, 32);
            this.lblNroEntrega.Name = "lblNroEntrega";
            this.lblNroEntrega.Text = "Nº de entrega:";
            this.lblNroEntrega.TabIndex = 15;
            // 
            // txtNroEntrega
            // 
            this.txtNroEntrega.Location = new System.Drawing.Point(125, 29);
            this.txtNroEntrega.Name = "txtNroEntrega";
            this.txtNroEntrega.Size = new System.Drawing.Size(120, 23);
            this.txtNroEntrega.ReadOnly = true;
            this.txtNroEntrega.TabIndex = 16;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(270, 32);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Text = "Fecha:";
            this.lblFechaEntrega.TabIndex = 17;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(320, 29);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.TabIndex = 18;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(465, 32);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Text = "Responsable:";
            this.lblResponsable.TabIndex = 19;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.Location = new System.Drawing.Point(560, 29);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(235, 23);
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Items.AddRange(new object[] { "Gómez, Carlos", "Pérez, Laura", "Ruiz, Martín" });
            this.cmbResponsable.TabIndex = 20;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(15, 70);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.TabIndex = 21;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 90);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(780, 70);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(604, 574);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(722, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 24;
            // 
            // FrmEntregaMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 620);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.dgvItemsEntrega);
            this.Controls.Add(this.grpDatosEntrega);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEntregaMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar entrega de materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsEntrega)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpDatosEntrega.ResumeLayout(false);
            this.grpDatosEntrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label lblNroSolicitud;
        private System.Windows.Forms.TextBox txtNroSolicitud;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.TextBox txtNroOrden;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dgvItemsEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsEntregaMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsEntregaCantAprobada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsEntregaCantRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsEntregaCantEntregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsEntregaPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsEntregaUnidad;
        private System.Windows.Forms.GroupBox grpDatosEntrega;
        private System.Windows.Forms.Label lblNroEntrega;
        private System.Windows.Forms.TextBox txtNroEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
