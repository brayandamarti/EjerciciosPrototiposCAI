namespace OfiCentral.PedidoMateriales.Formularios.Compras
{
    partial class OrdenCompraFrm
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
            lblSolicitudesAprobadas = new Label();
            dgvSolicitudesAprobadas = new DataGridView();
            btnCargarItems = new Button();
            grpDatosOrden = new GroupBox();
            lblNroOrden = new Label();
            txtNroOrden = new TextBox();
            lblFechaOrden = new Label();
            dtpFechaOrden = new DateTimePicker();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            lblCuit = new Label();
            txtCuit = new TextBox();
            lblFechaEntrega = new Label();
            dtpFechaEntrega = new DateTimePicker();
            lblCondicionPago = new Label();
            cmbCondicionPago = new ComboBox();
            lblItemsOrden = new Label();
            dgvItemsOrden = new DataGridView();
            btnQuitarItem = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dgvSolicitudesAprobadasSeleccionar = new DataGridViewCheckBoxColumn();
            dgvSolicitudesAprobadasNroSolicitud = new DataGridViewTextBoxColumn();
            dgvSolicitudesAprobadasArea = new DataGridViewTextBoxColumn();
            dgvSolicitudesAprobadasEmpleado = new DataGridViewTextBoxColumn();
            dgvSolicitudesAprobadasFechaAprobacion = new DataGridViewTextBoxColumn();
            dgvSolicitudesAprobadasAprobadaPor = new DataGridViewTextBoxColumn();
            dgvItemsOrdenCodigo = new DataGridViewTextBoxColumn();
            dgvItemsOrdenMaterial = new DataGridViewTextBoxColumn();
            dgvItemsOrdenCantidad = new DataGridViewTextBoxColumn();
            dgvItemsOrdenUnidad = new DataGridViewTextBoxColumn();
            dgvItemsOrdenPrecioUnitario = new DataGridViewTextBoxColumn();
            dgvItemsOrdenSubtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudesAprobadas).BeginInit();
            grpDatosOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemsOrden).BeginInit();
            SuspendLayout();
            // 
            // lblSolicitudesAprobadas
            // 
            lblSolicitudesAprobadas.AutoSize = true;
            lblSolicitudesAprobadas.Location = new Point(15, 12);
            lblSolicitudesAprobadas.Name = "lblSolicitudesAprobadas";
            lblSolicitudesAprobadas.Size = new Size(246, 15);
            lblSolicitudesAprobadas.TabIndex = 0;
            lblSolicitudesAprobadas.Text = "Solicitudes aprobadas pendientes de compra:";
            // 
            // dgvSolicitudesAprobadas
            // 
            dgvSolicitudesAprobadas.AllowUserToAddRows = false;
            dgvSolicitudesAprobadas.AllowUserToDeleteRows = false;
            dgvSolicitudesAprobadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudesAprobadas.Columns.AddRange(new DataGridViewColumn[] { dgvSolicitudesAprobadasSeleccionar, dgvSolicitudesAprobadasNroSolicitud, dgvSolicitudesAprobadasArea, dgvSolicitudesAprobadasEmpleado, dgvSolicitudesAprobadasFechaAprobacion, dgvSolicitudesAprobadasAprobadaPor });
            dgvSolicitudesAprobadas.Location = new Point(15, 32);
            dgvSolicitudesAprobadas.MultiSelect = false;
            dgvSolicitudesAprobadas.Name = "dgvSolicitudesAprobadas";
            dgvSolicitudesAprobadas.RowHeadersVisible = false;
            dgvSolicitudesAprobadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudesAprobadas.Size = new Size(850, 130);
            dgvSolicitudesAprobadas.TabIndex = 1;
            // 
            // btnCargarItems
            // 
            btnCargarItems.Location = new Point(655, 168);
            btnCargarItems.Name = "btnCargarItems";
            btnCargarItems.Size = new Size(210, 30);
            btnCargarItems.TabIndex = 2;
            btnCargarItems.Text = "Cargar ítems seleccionados";
            // 
            // grpDatosOrden
            // 
            grpDatosOrden.Controls.Add(lblNroOrden);
            grpDatosOrden.Controls.Add(txtNroOrden);
            grpDatosOrden.Controls.Add(lblFechaOrden);
            grpDatosOrden.Controls.Add(dtpFechaOrden);
            grpDatosOrden.Controls.Add(lblProveedor);
            grpDatosOrden.Controls.Add(cmbProveedor);
            grpDatosOrden.Controls.Add(lblCuit);
            grpDatosOrden.Controls.Add(txtCuit);
            grpDatosOrden.Controls.Add(lblFechaEntrega);
            grpDatosOrden.Controls.Add(dtpFechaEntrega);
            grpDatosOrden.Controls.Add(lblCondicionPago);
            grpDatosOrden.Controls.Add(cmbCondicionPago);
            grpDatosOrden.Location = new Point(15, 205);
            grpDatosOrden.Name = "grpDatosOrden";
            grpDatosOrden.Size = new Size(850, 105);
            grpDatosOrden.TabIndex = 3;
            grpDatosOrden.TabStop = false;
            grpDatosOrden.Text = "Datos de la orden de compra";
            // 
            // lblNroOrden
            // 
            lblNroOrden.AutoSize = true;
            lblNroOrden.Location = new Point(15, 30);
            lblNroOrden.Name = "lblNroOrden";
            lblNroOrden.Size = new Size(74, 15);
            lblNroOrden.TabIndex = 4;
            lblNroOrden.Text = "Nº de orden:";
            // 
            // txtNroOrden
            // 
            txtNroOrden.Location = new Point(115, 27);
            txtNroOrden.Name = "txtNroOrden";
            txtNroOrden.ReadOnly = true;
            txtNroOrden.Size = new Size(110, 23);
            txtNroOrden.TabIndex = 5;
            // 
            // lblFechaOrden
            // 
            lblFechaOrden.AutoSize = true;
            lblFechaOrden.Location = new Point(245, 30);
            lblFechaOrden.Name = "lblFechaOrden";
            lblFechaOrden.Size = new Size(41, 15);
            lblFechaOrden.TabIndex = 6;
            lblFechaOrden.Text = "Fecha:";
            // 
            // dtpFechaOrden
            // 
            dtpFechaOrden.Format = DateTimePickerFormat.Short;
            dtpFechaOrden.Location = new Point(300, 27);
            dtpFechaOrden.Name = "dtpFechaOrden";
            dtpFechaOrden.Size = new Size(120, 23);
            dtpFechaOrden.TabIndex = 7;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(445, 30);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(64, 15);
            lblProveedor.TabIndex = 8;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Items.AddRange(new object[] { "Librería El Lápiz S.R.L.", "Distribuidora Papelera Sur S.A.", "Insumos Office S.A." });
            cmbProveedor.Location = new Point(530, 27);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(300, 23);
            cmbProveedor.TabIndex = 9;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(15, 68);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(36, 15);
            lblCuit.TabIndex = 10;
            lblCuit.Text = "CUIT:";
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(115, 65);
            txtCuit.Name = "txtCuit";
            txtCuit.ReadOnly = true;
            txtCuit.Size = new Size(110, 23);
            txtCuit.TabIndex = 11;
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Location = new Point(245, 68);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(71, 15);
            lblFechaEntrega.TabIndex = 12;
            lblFechaEntrega.Text = "Entrega est.:";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(330, 65);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(90, 23);
            dtpFechaEntrega.TabIndex = 13;
            // 
            // lblCondicionPago
            // 
            lblCondicionPago.AutoSize = true;
            lblCondicionPago.Location = new Point(445, 68);
            lblCondicionPago.Name = "lblCondicionPago";
            lblCondicionPago.Size = new Size(88, 15);
            lblCondicionPago.TabIndex = 14;
            lblCondicionPago.Text = "Cond. de pago:";
            // 
            // cmbCondicionPago
            // 
            cmbCondicionPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicionPago.Items.AddRange(new object[] { "Contado", "Cuenta corriente 30 días", "Cuenta corriente 60 días" });
            cmbCondicionPago.Location = new Point(530, 65);
            cmbCondicionPago.Name = "cmbCondicionPago";
            cmbCondicionPago.Size = new Size(300, 23);
            cmbCondicionPago.TabIndex = 15;
            // 
            // lblItemsOrden
            // 
            lblItemsOrden.AutoSize = true;
            lblItemsOrden.Location = new Point(15, 320);
            lblItemsOrden.Name = "lblItemsOrden";
            lblItemsOrden.Size = new Size(101, 15);
            lblItemsOrden.TabIndex = 16;
            lblItemsOrden.Text = "Ítems de la orden:";
            // 
            // dgvItemsOrden
            // 
            dgvItemsOrden.AllowUserToAddRows = false;
            dgvItemsOrden.AllowUserToDeleteRows = false;
            dgvItemsOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsOrden.Columns.AddRange(new DataGridViewColumn[] { dgvItemsOrdenCodigo, dgvItemsOrdenMaterial, dgvItemsOrdenCantidad, dgvItemsOrdenUnidad, dgvItemsOrdenPrecioUnitario, dgvItemsOrdenSubtotal });
            dgvItemsOrden.Location = new Point(15, 340);
            dgvItemsOrden.MultiSelect = false;
            dgvItemsOrden.Name = "dgvItemsOrden";
            dgvItemsOrden.RowHeadersVisible = false;
            dgvItemsOrden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemsOrden.Size = new Size(730, 200);
            dgvItemsOrden.TabIndex = 17;
            // 
            // btnQuitarItem
            // 
            btnQuitarItem.Location = new Point(755, 340);
            btnQuitarItem.Name = "btnQuitarItem";
            btnQuitarItem.Size = new Size(110, 30);
            btnQuitarItem.TabIndex = 18;
            btnQuitarItem.Text = "Quitar ítem";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(585, 552);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 15);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "Total ($):";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(645, 549);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 20;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(15, 585);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(87, 15);
            lblObservaciones.TabIndex = 21;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(15, 605);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(850, 55);
            txtObservaciones.TabIndex = 22;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(644, 674);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 30);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Generar orden";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(762, 674);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            // 
            // dgvSolicitudesAprobadasSeleccionar
            // 
            dgvSolicitudesAprobadasSeleccionar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSolicitudesAprobadasSeleccionar.HeaderText = "Incluir";
            dgvSolicitudesAprobadasSeleccionar.Name = "dgvSolicitudesAprobadasSeleccionar";
            // 
            // dgvSolicitudesAprobadasNroSolicitud
            // 
            dgvSolicitudesAprobadasNroSolicitud.HeaderText = "Nº solicitud";
            dgvSolicitudesAprobadasNroSolicitud.Name = "dgvSolicitudesAprobadasNroSolicitud";
            dgvSolicitudesAprobadasNroSolicitud.ReadOnly = true;
            // 
            // dgvSolicitudesAprobadasArea
            // 
            dgvSolicitudesAprobadasArea.HeaderText = "Área";
            dgvSolicitudesAprobadasArea.Name = "dgvSolicitudesAprobadasArea";
            dgvSolicitudesAprobadasArea.ReadOnly = true;
            dgvSolicitudesAprobadasArea.Width = 160;
            // 
            // dgvSolicitudesAprobadasEmpleado
            // 
            dgvSolicitudesAprobadasEmpleado.HeaderText = "Empleado";
            dgvSolicitudesAprobadasEmpleado.Name = "dgvSolicitudesAprobadasEmpleado";
            dgvSolicitudesAprobadasEmpleado.ReadOnly = true;
            dgvSolicitudesAprobadasEmpleado.Width = 200;
            // 
            // dgvSolicitudesAprobadasFechaAprobacion
            // 
            dgvSolicitudesAprobadasFechaAprobacion.HeaderText = "Fecha aprobación";
            dgvSolicitudesAprobadasFechaAprobacion.Name = "dgvSolicitudesAprobadasFechaAprobacion";
            dgvSolicitudesAprobadasFechaAprobacion.ReadOnly = true;
            dgvSolicitudesAprobadasFechaAprobacion.Width = 130;
            // 
            // dgvSolicitudesAprobadasAprobadaPor
            // 
            dgvSolicitudesAprobadasAprobadaPor.HeaderText = "Aprobada por";
            dgvSolicitudesAprobadasAprobadaPor.Name = "dgvSolicitudesAprobadasAprobadaPor";
            dgvSolicitudesAprobadasAprobadaPor.ReadOnly = true;
            dgvSolicitudesAprobadasAprobadaPor.Width = 180;
            // 
            // dgvItemsOrdenCodigo
            // 
            dgvItemsOrdenCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItemsOrdenCodigo.HeaderText = "Código";
            dgvItemsOrdenCodigo.Name = "dgvItemsOrdenCodigo";
            dgvItemsOrdenCodigo.ReadOnly = true;
            // 
            // dgvItemsOrdenMaterial
            // 
            dgvItemsOrdenMaterial.HeaderText = "Material";
            dgvItemsOrdenMaterial.Name = "dgvItemsOrdenMaterial";
            dgvItemsOrdenMaterial.ReadOnly = true;
            dgvItemsOrdenMaterial.Width = 240;
            // 
            // dgvItemsOrdenCantidad
            // 
            dgvItemsOrdenCantidad.HeaderText = "Cantidad";
            dgvItemsOrdenCantidad.Name = "dgvItemsOrdenCantidad";
            dgvItemsOrdenCantidad.Width = 90;
            // 
            // dgvItemsOrdenUnidad
            // 
            dgvItemsOrdenUnidad.HeaderText = "Unidad";
            dgvItemsOrdenUnidad.Name = "dgvItemsOrdenUnidad";
            dgvItemsOrdenUnidad.ReadOnly = true;
            dgvItemsOrdenUnidad.Width = 80;
            // 
            // dgvItemsOrdenPrecioUnitario
            // 
            dgvItemsOrdenPrecioUnitario.HeaderText = "Precio unitario";
            dgvItemsOrdenPrecioUnitario.Name = "dgvItemsOrdenPrecioUnitario";
            dgvItemsOrdenPrecioUnitario.Width = 110;
            // 
            // dgvItemsOrdenSubtotal
            // 
            dgvItemsOrdenSubtotal.HeaderText = "Subtotal";
            dgvItemsOrdenSubtotal.Name = "dgvItemsOrdenSubtotal";
            dgvItemsOrdenSubtotal.ReadOnly = true;
            dgvItemsOrdenSubtotal.Width = 110;
            // 
            // OrdenCompraFrm
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(880, 720);
            Controls.Add(lblSolicitudesAprobadas);
            Controls.Add(dgvSolicitudesAprobadas);
            Controls.Add(btnCargarItems);
            Controls.Add(grpDatosOrden);
            Controls.Add(lblItemsOrden);
            Controls.Add(dgvItemsOrden);
            Controls.Add(btnQuitarItem);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(lblObservaciones);
            Controls.Add(txtObservaciones);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "OrdenCompraFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar orden de compra";
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudesAprobadas).EndInit();
            grpDatosOrden.ResumeLayout(false);
            grpDatosOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemsOrden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSolicitudesAprobadas;
        private System.Windows.Forms.DataGridView dgvSolicitudesAprobadas;
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
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DataGridViewCheckBoxColumn dgvSolicitudesAprobadasSeleccionar;
        private DataGridViewTextBoxColumn dgvSolicitudesAprobadasNroSolicitud;
        private DataGridViewTextBoxColumn dgvSolicitudesAprobadasArea;
        private DataGridViewTextBoxColumn dgvSolicitudesAprobadasEmpleado;
        private DataGridViewTextBoxColumn dgvSolicitudesAprobadasFechaAprobacion;
        private DataGridViewTextBoxColumn dgvSolicitudesAprobadasAprobadaPor;
        private DataGridViewTextBoxColumn dgvItemsOrdenCodigo;
        private DataGridViewTextBoxColumn dgvItemsOrdenMaterial;
        private DataGridViewTextBoxColumn dgvItemsOrdenCantidad;
        private DataGridViewTextBoxColumn dgvItemsOrdenUnidad;
        private DataGridViewTextBoxColumn dgvItemsOrdenPrecioUnitario;
        private DataGridViewTextBoxColumn dgvItemsOrdenSubtotal;
    }
}
