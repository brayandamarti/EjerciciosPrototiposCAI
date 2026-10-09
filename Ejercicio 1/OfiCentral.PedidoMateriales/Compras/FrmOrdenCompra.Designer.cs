namespace OfiCentral.PedidoMateriales.Formularios.Compras
{
    partial class FrmOrdenCompra
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
            this.lblSolicitudesAprobadas = new System.Windows.Forms.Label();
            this.dgvSolicitudesAprobadas = new System.Windows.Forms.DataGridView();
            this.dgvSolicitudesAprobadasSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvSolicitudesAprobadasNroSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesAprobadasArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesAprobadasEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesAprobadasFechaAprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitudesAprobadasAprobadaPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarItems = new System.Windows.Forms.Button();
            this.grpDatosOrden = new System.Windows.Forms.GroupBox();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.txtNroOrden = new System.Windows.Forms.TextBox();
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblCondicionPago = new System.Windows.Forms.Label();
            this.cmbCondicionPago = new System.Windows.Forms.ComboBox();
            this.lblItemsOrden = new System.Windows.Forms.Label();
            this.dgvItemsOrden = new System.Windows.Forms.DataGridView();
            this.dgvItemsOrdenCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsOrdenMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsOrdenCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsOrdenUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsOrdenPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemsOrdenSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatosOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSolicitudesAprobadas
            // 
            this.lblSolicitudesAprobadas.AutoSize = true;
            this.lblSolicitudesAprobadas.Location = new System.Drawing.Point(15, 12);
            this.lblSolicitudesAprobadas.Name = "lblSolicitudesAprobadas";
            this.lblSolicitudesAprobadas.Text = "Solicitudes aprobadas pendientes de compra:";
            this.lblSolicitudesAprobadas.TabIndex = 0;
            // 
            // dgvSolicitudesAprobadas
            // 
            this.dgvSolicitudesAprobadas.Location = new System.Drawing.Point(15, 32);
            this.dgvSolicitudesAprobadas.Name = "dgvSolicitudesAprobadas";
            this.dgvSolicitudesAprobadas.Size = new System.Drawing.Size(850, 130);
            this.dgvSolicitudesAprobadas.AllowUserToAddRows = false;
            this.dgvSolicitudesAprobadas.AllowUserToDeleteRows = false;
            this.dgvSolicitudesAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesAprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudesAprobadas.MultiSelect = false;
            this.dgvSolicitudesAprobadas.RowHeadersVisible = false;
            this.dgvSolicitudesAprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvSolicitudesAprobadasSeleccionar, this.dgvSolicitudesAprobadasNroSolicitud, this.dgvSolicitudesAprobadasArea, this.dgvSolicitudesAprobadasEmpleado, this.dgvSolicitudesAprobadasFechaAprobacion, this.dgvSolicitudesAprobadasAprobadaPor });
            this.dgvSolicitudesAprobadas.TabIndex = 1;
            this.dgvSolicitudesAprobadasSeleccionar.HeaderText = "Incluir";
            this.dgvSolicitudesAprobadasSeleccionar.Name = "dgvSolicitudesAprobadasSeleccionar";
            this.dgvSolicitudesAprobadasSeleccionar.Width = 60;
            this.dgvSolicitudesAprobadasNroSolicitud.HeaderText = "Nº solicitud";
            this.dgvSolicitudesAprobadasNroSolicitud.Name = "dgvSolicitudesAprobadasNroSolicitud";
            this.dgvSolicitudesAprobadasNroSolicitud.Width = 100;
            this.dgvSolicitudesAprobadasNroSolicitud.ReadOnly = true;
            this.dgvSolicitudesAprobadasArea.HeaderText = "Área";
            this.dgvSolicitudesAprobadasArea.Name = "dgvSolicitudesAprobadasArea";
            this.dgvSolicitudesAprobadasArea.Width = 160;
            this.dgvSolicitudesAprobadasArea.ReadOnly = true;
            this.dgvSolicitudesAprobadasEmpleado.HeaderText = "Empleado";
            this.dgvSolicitudesAprobadasEmpleado.Name = "dgvSolicitudesAprobadasEmpleado";
            this.dgvSolicitudesAprobadasEmpleado.Width = 200;
            this.dgvSolicitudesAprobadasEmpleado.ReadOnly = true;
            this.dgvSolicitudesAprobadasFechaAprobacion.HeaderText = "Fecha aprobación";
            this.dgvSolicitudesAprobadasFechaAprobacion.Name = "dgvSolicitudesAprobadasFechaAprobacion";
            this.dgvSolicitudesAprobadasFechaAprobacion.Width = 130;
            this.dgvSolicitudesAprobadasFechaAprobacion.ReadOnly = true;
            this.dgvSolicitudesAprobadasAprobadaPor.HeaderText = "Aprobada por";
            this.dgvSolicitudesAprobadasAprobadaPor.Name = "dgvSolicitudesAprobadasAprobadaPor";
            this.dgvSolicitudesAprobadasAprobadaPor.Width = 180;
            this.dgvSolicitudesAprobadasAprobadaPor.ReadOnly = true;
            // 
            // btnCargarItems
            // 
            this.btnCargarItems.Location = new System.Drawing.Point(655, 168);
            this.btnCargarItems.Name = "btnCargarItems";
            this.btnCargarItems.Size = new System.Drawing.Size(210, 30);
            this.btnCargarItems.Text = "Cargar ítems seleccionados";
            this.btnCargarItems.TabIndex = 2;
            // 
            // grpDatosOrden
            // 
            this.grpDatosOrden.Location = new System.Drawing.Point(15, 205);
            this.grpDatosOrden.Name = "grpDatosOrden";
            this.grpDatosOrden.Size = new System.Drawing.Size(850, 105);
            this.grpDatosOrden.Text = "Datos de la orden de compra";
            this.grpDatosOrden.Controls.Add(this.lblNroOrden);
            this.grpDatosOrden.Controls.Add(this.txtNroOrden);
            this.grpDatosOrden.Controls.Add(this.lblFechaOrden);
            this.grpDatosOrden.Controls.Add(this.dtpFechaOrden);
            this.grpDatosOrden.Controls.Add(this.lblProveedor);
            this.grpDatosOrden.Controls.Add(this.cmbProveedor);
            this.grpDatosOrden.Controls.Add(this.lblCuit);
            this.grpDatosOrden.Controls.Add(this.txtCuit);
            this.grpDatosOrden.Controls.Add(this.lblFechaEntrega);
            this.grpDatosOrden.Controls.Add(this.dtpFechaEntrega);
            this.grpDatosOrden.Controls.Add(this.lblCondicionPago);
            this.grpDatosOrden.Controls.Add(this.cmbCondicionPago);
            this.grpDatosOrden.TabIndex = 3;
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Location = new System.Drawing.Point(15, 30);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Text = "Nº de orden:";
            this.lblNroOrden.TabIndex = 4;
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.Location = new System.Drawing.Point(115, 27);
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.Size = new System.Drawing.Size(110, 23);
            this.txtNroOrden.ReadOnly = true;
            this.txtNroOrden.TabIndex = 5;
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Location = new System.Drawing.Point(245, 30);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Text = "Fecha:";
            this.lblFechaOrden.TabIndex = 6;
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Location = new System.Drawing.Point(300, 27);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.TabIndex = 7;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(445, 30);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Text = "Proveedor:";
            this.lblProveedor.TabIndex = 8;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Location = new System.Drawing.Point(530, 27);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(300, 23);
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Items.AddRange(new object[] { "Librería El Lápiz S.R.L.", "Distribuidora Papelera Sur S.A.", "Insumos Office S.A." });
            this.cmbProveedor.TabIndex = 9;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(15, 68);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Text = "CUIT:";
            this.lblCuit.TabIndex = 10;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(115, 65);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(110, 23);
            this.txtCuit.ReadOnly = true;
            this.txtCuit.TabIndex = 11;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(245, 68);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Text = "Entrega est.:";
            this.lblFechaEntrega.TabIndex = 12;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(330, 65);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(90, 23);
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.TabIndex = 13;
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.AutoSize = true;
            this.lblCondicionPago.Location = new System.Drawing.Point(445, 68);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Text = "Cond. de pago:";
            this.lblCondicionPago.TabIndex = 14;
            // 
            // cmbCondicionPago
            // 
            this.cmbCondicionPago.Location = new System.Drawing.Point(530, 65);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(300, 23);
            this.cmbCondicionPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionPago.Items.AddRange(new object[] { "Contado", "Cuenta corriente 30 días", "Cuenta corriente 60 días" });
            this.cmbCondicionPago.TabIndex = 15;
            // 
            // lblItemsOrden
            // 
            this.lblItemsOrden.AutoSize = true;
            this.lblItemsOrden.Location = new System.Drawing.Point(15, 320);
            this.lblItemsOrden.Name = "lblItemsOrden";
            this.lblItemsOrden.Text = "Ítems de la orden:";
            this.lblItemsOrden.TabIndex = 16;
            // 
            // dgvItemsOrden
            // 
            this.dgvItemsOrden.Location = new System.Drawing.Point(15, 340);
            this.dgvItemsOrden.Name = "dgvItemsOrden";
            this.dgvItemsOrden.Size = new System.Drawing.Size(730, 200);
            this.dgvItemsOrden.AllowUserToAddRows = false;
            this.dgvItemsOrden.AllowUserToDeleteRows = false;
            this.dgvItemsOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsOrden.MultiSelect = false;
            this.dgvItemsOrden.RowHeadersVisible = false;
            this.dgvItemsOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvItemsOrdenCodigo, this.dgvItemsOrdenMaterial, this.dgvItemsOrdenCantidad, this.dgvItemsOrdenUnidad, this.dgvItemsOrdenPrecioUnitario, this.dgvItemsOrdenSubtotal });
            this.dgvItemsOrden.TabIndex = 17;
            this.dgvItemsOrdenCodigo.HeaderText = "Código";
            this.dgvItemsOrdenCodigo.Name = "dgvItemsOrdenCodigo";
            this.dgvItemsOrdenCodigo.Width = 80;
            this.dgvItemsOrdenCodigo.ReadOnly = true;
            this.dgvItemsOrdenMaterial.HeaderText = "Material";
            this.dgvItemsOrdenMaterial.Name = "dgvItemsOrdenMaterial";
            this.dgvItemsOrdenMaterial.Width = 240;
            this.dgvItemsOrdenMaterial.ReadOnly = true;
            this.dgvItemsOrdenCantidad.HeaderText = "Cantidad";
            this.dgvItemsOrdenCantidad.Name = "dgvItemsOrdenCantidad";
            this.dgvItemsOrdenCantidad.Width = 90;
            this.dgvItemsOrdenUnidad.HeaderText = "Unidad";
            this.dgvItemsOrdenUnidad.Name = "dgvItemsOrdenUnidad";
            this.dgvItemsOrdenUnidad.Width = 80;
            this.dgvItemsOrdenUnidad.ReadOnly = true;
            this.dgvItemsOrdenPrecioUnitario.HeaderText = "Precio unitario";
            this.dgvItemsOrdenPrecioUnitario.Name = "dgvItemsOrdenPrecioUnitario";
            this.dgvItemsOrdenPrecioUnitario.Width = 110;
            this.dgvItemsOrdenSubtotal.HeaderText = "Subtotal";
            this.dgvItemsOrdenSubtotal.Name = "dgvItemsOrdenSubtotal";
            this.dgvItemsOrdenSubtotal.Width = 110;
            this.dgvItemsOrdenSubtotal.ReadOnly = true;
            // 
            // btnQuitarItem
            // 
            this.btnQuitarItem.Location = new System.Drawing.Point(755, 340);
            this.btnQuitarItem.Name = "btnQuitarItem";
            this.btnQuitarItem.Size = new System.Drawing.Size(110, 30);
            this.btnQuitarItem.Text = "Quitar ítem";
            this.btnQuitarItem.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(585, 552);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Total ($):";
            this.lblTotal.TabIndex = 19;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(645, 549);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TabIndex = 20;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(15, 585);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Text = "Observaciones:";
            this.lblObservaciones.TabIndex = 21;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 605);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(850, 55);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(644, 674);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Generar orden";
            this.btnAceptar.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(762, 674);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 24;
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 720);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblSolicitudesAprobadas);
            this.Controls.Add(this.dgvSolicitudesAprobadas);
            this.Controls.Add(this.btnCargarItems);
            this.Controls.Add(this.grpDatosOrden);
            this.Controls.Add(this.lblItemsOrden);
            this.Controls.Add(this.dgvItemsOrden);
            this.Controls.Add(this.btnQuitarItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar orden de compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsOrden)).EndInit();
            this.grpDatosOrden.ResumeLayout(false);
            this.grpDatosOrden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSolicitudesAprobadas;
        private System.Windows.Forms.DataGridView dgvSolicitudesAprobadas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvSolicitudesAprobadasSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesAprobadasNroSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesAprobadasArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesAprobadasEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesAprobadasFechaAprobacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSolicitudesAprobadasAprobadaPor;
        private System.Windows.Forms.Button btnCargarItems;
        private System.Windows.Forms.GroupBox grpDatosOrden;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.TextBox txtNroOrden;
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblCondicionPago;
        private System.Windows.Forms.ComboBox cmbCondicionPago;
        private System.Windows.Forms.Label lblItemsOrden;
        private System.Windows.Forms.DataGridView dgvItemsOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsOrdenCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsOrdenMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsOrdenCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsOrdenUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsOrdenPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemsOrdenSubtotal;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
