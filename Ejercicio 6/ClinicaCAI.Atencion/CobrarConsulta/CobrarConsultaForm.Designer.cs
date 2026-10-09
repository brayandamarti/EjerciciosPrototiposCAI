namespace ClinicaCAI.Atencion.CobrarConsulta
{
    partial class CobrarConsultaForm
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
            this.lblPendientes = new System.Windows.Forms.Label();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.dgvPendientesHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPendientesPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPendientesMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPendientesEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPendientesObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpImporte = new System.Windows.Forms.GroupBox();
            this.lblValorConsulta = new System.Windows.Forms.Label();
            this.txtValorConsulta = new System.Windows.Forms.TextBox();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.txtCobertura = new System.Windows.Forms.TextBox();
            this.lblCoseguro = new System.Windows.Forms.Label();
            this.txtCoseguro = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblAutorizacion = new System.Windows.Forms.Label();
            this.txtAutorizacion = new System.Windows.Forms.TextBox();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtDebito = new System.Windows.Forms.RadioButton();
            this.rbtCredito = new System.Windows.Forms.RadioButton();
            this.rbtTransferencia = new System.Windows.Forms.RadioButton();
            this.lblImporteRecibido = new System.Windows.Forms.Label();
            this.txtImporteRecibido = new System.Windows.Forms.TextBox();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.lblNroOperacion = new System.Windows.Forms.Label();
            this.txtNroOperacion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpImporte.SuspendLayout();
            this.grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(15, 12);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Text = "Consultas pendientes de cobro:";
            this.lblPendientes.TabIndex = 0;
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.Location = new System.Drawing.Point(15, 32);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.Size = new System.Drawing.Size(750, 160);
            this.dgvPendientes.AllowUserToAddRows = false;
            this.dgvPendientes.AllowUserToDeleteRows = false;
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendientes.MultiSelect = false;
            this.dgvPendientes.RowHeadersVisible = false;
            this.dgvPendientes.ReadOnly = true;
            this.dgvPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvPendientesHora, this.dgvPendientesPaciente, this.dgvPendientesMedico, this.dgvPendientesEspecialidad, this.dgvPendientesObraSocial });
            this.dgvPendientes.TabIndex = 1;
            this.dgvPendientesHora.HeaderText = "Hora";
            this.dgvPendientesHora.Name = "dgvPendientesHora";
            this.dgvPendientesHora.Width = 70;
            this.dgvPendientesPaciente.HeaderText = "Paciente";
            this.dgvPendientesPaciente.Name = "dgvPendientesPaciente";
            this.dgvPendientesPaciente.Width = 220;
            this.dgvPendientesMedico.HeaderText = "Médico";
            this.dgvPendientesMedico.Name = "dgvPendientesMedico";
            this.dgvPendientesMedico.Width = 180;
            this.dgvPendientesEspecialidad.HeaderText = "Especialidad";
            this.dgvPendientesEspecialidad.Name = "dgvPendientesEspecialidad";
            this.dgvPendientesEspecialidad.Width = 140;
            this.dgvPendientesObraSocial.HeaderText = "Obra social";
            this.dgvPendientesObraSocial.Name = "dgvPendientesObraSocial";
            this.dgvPendientesObraSocial.Width = 137;
            // 
            // grpImporte
            // 
            this.grpImporte.Location = new System.Drawing.Point(15, 202);
            this.grpImporte.Name = "grpImporte";
            this.grpImporte.Size = new System.Drawing.Size(750, 145);
            this.grpImporte.Text = "Importe";
            this.grpImporte.Controls.Add(this.lblValorConsulta);
            this.grpImporte.Controls.Add(this.txtValorConsulta);
            this.grpImporte.Controls.Add(this.lblCobertura);
            this.grpImporte.Controls.Add(this.txtCobertura);
            this.grpImporte.Controls.Add(this.lblCoseguro);
            this.grpImporte.Controls.Add(this.txtCoseguro);
            this.grpImporte.Controls.Add(this.lblTotal);
            this.grpImporte.Controls.Add(this.txtTotal);
            this.grpImporte.Controls.Add(this.lblAutorizacion);
            this.grpImporte.Controls.Add(this.txtAutorizacion);
            this.grpImporte.TabIndex = 2;
            // 
            // lblValorConsulta
            // 
            this.lblValorConsulta.AutoSize = true;
            this.lblValorConsulta.Location = new System.Drawing.Point(15, 32);
            this.lblValorConsulta.Name = "lblValorConsulta";
            this.lblValorConsulta.Text = "Valor de la consulta ($):";
            this.lblValorConsulta.TabIndex = 3;
            // 
            // txtValorConsulta
            // 
            this.txtValorConsulta.Location = new System.Drawing.Point(190, 29);
            this.txtValorConsulta.Name = "txtValorConsulta";
            this.txtValorConsulta.Size = new System.Drawing.Size(120, 23);
            this.txtValorConsulta.ReadOnly = true;
            this.txtValorConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorConsulta.TabIndex = 4;
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Location = new System.Drawing.Point(360, 32);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Text = "Cobertura obra social ($):";
            this.lblCobertura.TabIndex = 5;
            // 
            // txtCobertura
            // 
            this.txtCobertura.Location = new System.Drawing.Point(540, 29);
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.Size = new System.Drawing.Size(120, 23);
            this.txtCobertura.ReadOnly = true;
            this.txtCobertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCobertura.TabIndex = 6;
            // 
            // lblCoseguro
            // 
            this.lblCoseguro.AutoSize = true;
            this.lblCoseguro.Location = new System.Drawing.Point(15, 70);
            this.lblCoseguro.Name = "lblCoseguro";
            this.lblCoseguro.Text = "Coseguro (%):";
            this.lblCoseguro.TabIndex = 7;
            // 
            // txtCoseguro
            // 
            this.txtCoseguro.Location = new System.Drawing.Point(190, 67);
            this.txtCoseguro.Name = "txtCoseguro";
            this.txtCoseguro.Size = new System.Drawing.Size(120, 23);
            this.txtCoseguro.ReadOnly = true;
            this.txtCoseguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCoseguro.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(360, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Total a cobrar ($):";
            this.lblTotal.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(540, 67);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 23);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TabIndex = 10;
            // 
            // lblAutorizacion
            // 
            this.lblAutorizacion.AutoSize = true;
            this.lblAutorizacion.Location = new System.Drawing.Point(15, 108);
            this.lblAutorizacion.Name = "lblAutorizacion";
            this.lblAutorizacion.Text = "Nº autorización OS:";
            this.lblAutorizacion.TabIndex = 11;
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.Location = new System.Drawing.Point(190, 105);
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(470, 23);
            this.txtAutorizacion.TabIndex = 12;
            // 
            // grpPago
            // 
            this.grpPago.Location = new System.Drawing.Point(15, 355);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(750, 180);
            this.grpPago.Text = "Forma de pago";
            this.grpPago.Controls.Add(this.rbtEfectivo);
            this.grpPago.Controls.Add(this.rbtDebito);
            this.grpPago.Controls.Add(this.rbtCredito);
            this.grpPago.Controls.Add(this.rbtTransferencia);
            this.grpPago.Controls.Add(this.lblImporteRecibido);
            this.grpPago.Controls.Add(this.txtImporteRecibido);
            this.grpPago.Controls.Add(this.lblVuelto);
            this.grpPago.Controls.Add(this.txtVuelto);
            this.grpPago.Controls.Add(this.lblComprobante);
            this.grpPago.Controls.Add(this.cmbComprobante);
            this.grpPago.Controls.Add(this.lblNroOperacion);
            this.grpPago.Controls.Add(this.txtNroOperacion);
            this.grpPago.TabIndex = 13;
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.Location = new System.Drawing.Point(15, 28);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(100, 24);
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.Checked = true;
            this.rbtEfectivo.TabIndex = 14;
            // 
            // rbtDebito
            // 
            this.rbtDebito.Location = new System.Drawing.Point(125, 28);
            this.rbtDebito.Name = "rbtDebito";
            this.rbtDebito.Size = new System.Drawing.Size(90, 24);
            this.rbtDebito.Text = "Débito";
            this.rbtDebito.TabIndex = 15;
            // 
            // rbtCredito
            // 
            this.rbtCredito.Location = new System.Drawing.Point(225, 28);
            this.rbtCredito.Name = "rbtCredito";
            this.rbtCredito.Size = new System.Drawing.Size(90, 24);
            this.rbtCredito.Text = "Crédito";
            this.rbtCredito.TabIndex = 16;
            // 
            // rbtTransferencia
            // 
            this.rbtTransferencia.Location = new System.Drawing.Point(325, 28);
            this.rbtTransferencia.Name = "rbtTransferencia";
            this.rbtTransferencia.Size = new System.Drawing.Size(130, 24);
            this.rbtTransferencia.Text = "Transferencia";
            this.rbtTransferencia.TabIndex = 17;
            // 
            // lblImporteRecibido
            // 
            this.lblImporteRecibido.AutoSize = true;
            this.lblImporteRecibido.Location = new System.Drawing.Point(15, 70);
            this.lblImporteRecibido.Name = "lblImporteRecibido";
            this.lblImporteRecibido.Text = "Importe recibido ($):";
            this.lblImporteRecibido.TabIndex = 18;
            // 
            // txtImporteRecibido
            // 
            this.txtImporteRecibido.Location = new System.Drawing.Point(160, 67);
            this.txtImporteRecibido.Name = "txtImporteRecibido";
            this.txtImporteRecibido.Size = new System.Drawing.Size(120, 23);
            this.txtImporteRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteRecibido.TabIndex = 19;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(310, 70);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Text = "Vuelto ($):";
            this.lblVuelto.TabIndex = 20;
            // 
            // txtVuelto
            // 
            this.txtVuelto.Location = new System.Drawing.Point(390, 67);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(120, 23);
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVuelto.TabIndex = 21;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(15, 108);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Text = "Comprobante:";
            this.lblComprobante.TabIndex = 22;
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.Location = new System.Drawing.Point(160, 105);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(200, 23);
            this.cmbComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComprobante.Items.AddRange(new object[] { "Factura B", "Factura C", "Recibo" });
            this.cmbComprobante.TabIndex = 23;
            // 
            // lblNroOperacion
            // 
            this.lblNroOperacion.AutoSize = true;
            this.lblNroOperacion.Location = new System.Drawing.Point(380, 108);
            this.lblNroOperacion.Name = "lblNroOperacion";
            this.lblNroOperacion.Text = "Nº operación:";
            this.lblNroOperacion.TabIndex = 24;
            // 
            // txtNroOperacion
            // 
            this.txtNroOperacion.Location = new System.Drawing.Point(470, 105);
            this.txtNroOperacion.Name = "txtNroOperacion";
            this.txtNroOperacion.Size = new System.Drawing.Size(260, 23);
            this.txtNroOperacion.TabIndex = 25;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(544, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 30);
            this.btnAceptar.Text = "Cobrar";
            this.btnAceptar.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.TabIndex = 27;
            // 
            // CobrarConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 600);
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.dgvPendientes);
            this.Controls.Add(this.grpImporte);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CobrarConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro de consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.grpImporte.ResumeLayout(false);
            this.grpImporte.PerformLayout();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPendientesHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPendientesPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPendientesMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPendientesEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPendientesObraSocial;
        private System.Windows.Forms.GroupBox grpImporte;
        private System.Windows.Forms.Label lblValorConsulta;
        private System.Windows.Forms.TextBox txtValorConsulta;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.TextBox txtCobertura;
        private System.Windows.Forms.Label lblCoseguro;
        private System.Windows.Forms.TextBox txtCoseguro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblAutorizacion;
        private System.Windows.Forms.TextBox txtAutorizacion;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtDebito;
        private System.Windows.Forms.RadioButton rbtCredito;
        private System.Windows.Forms.RadioButton rbtTransferencia;
        private System.Windows.Forms.Label lblImporteRecibido;
        private System.Windows.Forms.TextBox txtImporteRecibido;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.ComboBox cmbComprobante;
        private System.Windows.Forms.Label lblNroOperacion;
        private System.Windows.Forms.TextBox txtNroOperacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
