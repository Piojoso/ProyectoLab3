namespace MAB.Forms.CRUD.Reparaciones
{
    partial class frmModificarReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.ucBottom = new ucLibrary.ucBottom();
            this.cclblFechaIngreso = new ccLibrary.ccLabel();
            this.cclblFechaEgreso = new ccLibrary.ccLabel();
            this.cclblErrorReparar = new ccLibrary.ccLabel();
            this.cclblEstadoReparacion = new ccLibrary.ccLabel();
            this.cclblMesesGarantia = new ccLibrary.ccLabel();
            this.cclblReparacionRealizada = new ccLibrary.ccLabel();
            this.cclblManoObra = new ccLibrary.ccLabel();
            this.cclblTotalRepuestos = new ccLibrary.ccLabel();
            this.cclblLavarropa = new ccLibrary.ccLabel();
            this.cclblTotal = new ccLibrary.ccLabel();
            this.cclblValorTotal = new ccLibrary.ccLabel();
            this.cctbFallaAReparar = new ccLibrary.ccTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cclblMarcaModelo = new ccLibrary.ccLabel();
            this.cboEstadoReparacion = new System.Windows.Forms.ComboBox();
            this.cctbReparacionRealizada = new ccLibrary.ccTextBox();
            this.cctbManoObra = new ccLibrary.ccTextBox();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.cctbValorRepuestos = new ccLibrary.ccTextBox();
            this.nudGarantia = new System.Windows.Forms.NumericUpDown();
            this.dtpGarantia = new System.Windows.Forms.DateTimePicker();
            this.cclblFinaliza = new ccLibrary.ccLabel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cclblNombreApellidoCliente = new ccLibrary.ccLabel();
            this.cclblCliente = new ccLibrary.ccLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudGarantia)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 344);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(780, 82);
            this.ucBottom.TabIndex = 1;
            // 
            // cclblFechaIngreso
            // 
            this.cclblFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaIngreso.AutoSize = true;
            this.cclblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaIngreso.Location = new System.Drawing.Point(371, 91);
            this.cclblFechaIngreso.Name = "cclblFechaIngreso";
            this.cclblFechaIngreso.Size = new System.Drawing.Size(108, 16);
            this.cclblFechaIngreso.TabIndex = 2;
            this.cclblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // cclblFechaEgreso
            // 
            this.cclblFechaEgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaEgreso.AutoSize = true;
            this.cclblFechaEgreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaEgreso.Location = new System.Drawing.Point(60, 287);
            this.cclblFechaEgreso.Name = "cclblFechaEgreso";
            this.cclblFechaEgreso.Size = new System.Drawing.Size(105, 16);
            this.cclblFechaEgreso.TabIndex = 3;
            this.cclblFechaEgreso.Text = "Fecha de Egreso";
            // 
            // cclblErrorReparar
            // 
            this.cclblErrorReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblErrorReparar.AutoSize = true;
            this.cclblErrorReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblErrorReparar.Location = new System.Drawing.Point(60, 140);
            this.cclblErrorReparar.Name = "cclblErrorReparar";
            this.cclblErrorReparar.Size = new System.Drawing.Size(96, 16);
            this.cclblErrorReparar.TabIndex = 4;
            this.cclblErrorReparar.Text = "Falla a Reparar";
            // 
            // cclblEstadoReparacion
            // 
            this.cclblEstadoReparacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblEstadoReparacion.AutoSize = true;
            this.cclblEstadoReparacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstadoReparacion.Location = new System.Drawing.Point(60, 91);
            this.cclblEstadoReparacion.Name = "cclblEstadoReparacion";
            this.cclblEstadoReparacion.Size = new System.Drawing.Size(151, 16);
            this.cclblEstadoReparacion.TabIndex = 5;
            this.cclblEstadoReparacion.Text = "Estado de la Reparacion";
            // 
            // cclblMesesGarantia
            // 
            this.cclblMesesGarantia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMesesGarantia.AutoSize = true;
            this.cclblMesesGarantia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMesesGarantia.Location = new System.Drawing.Point(371, 287);
            this.cclblMesesGarantia.Name = "cclblMesesGarantia";
            this.cclblMesesGarantia.Size = new System.Drawing.Size(118, 16);
            this.cclblMesesGarantia.TabIndex = 6;
            this.cclblMesesGarantia.Text = "Meses de Garantia";
            // 
            // cclblReparacionRealizada
            // 
            this.cclblReparacionRealizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblReparacionRealizada.AutoSize = true;
            this.cclblReparacionRealizada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblReparacionRealizada.Location = new System.Drawing.Point(60, 189);
            this.cclblReparacionRealizada.Name = "cclblReparacionRealizada";
            this.cclblReparacionRealizada.Size = new System.Drawing.Size(134, 16);
            this.cclblReparacionRealizada.TabIndex = 7;
            this.cclblReparacionRealizada.Text = "Reparacion Realizada";
            // 
            // cclblManoObra
            // 
            this.cclblManoObra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblManoObra.AutoSize = true;
            this.cclblManoObra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblManoObra.Location = new System.Drawing.Point(60, 238);
            this.cclblManoObra.Name = "cclblManoObra";
            this.cclblManoObra.Size = new System.Drawing.Size(95, 16);
            this.cclblManoObra.TabIndex = 8;
            this.cclblManoObra.Text = "Mano de Obra";
            // 
            // cclblTotalRepuestos
            // 
            this.cclblTotalRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTotalRepuestos.AutoSize = true;
            this.cclblTotalRepuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalRepuestos.Location = new System.Drawing.Point(326, 238);
            this.cclblTotalRepuestos.Name = "cclblTotalRepuestos";
            this.cclblTotalRepuestos.Size = new System.Drawing.Size(121, 16);
            this.cclblTotalRepuestos.TabIndex = 9;
            this.cclblTotalRepuestos.Text = "Total de Repuestos";
            // 
            // cclblLavarropa
            // 
            this.cclblLavarropa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblLavarropa.AutoSize = true;
            this.cclblLavarropa.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblLavarropa.Location = new System.Drawing.Point(371, 42);
            this.cclblLavarropa.Name = "cclblLavarropa";
            this.cclblLavarropa.Size = new System.Drawing.Size(76, 16);
            this.cclblLavarropa.TabIndex = 10;
            this.cclblLavarropa.Text = "Lavarropas:";
            // 
            // cclblTotal
            // 
            this.cclblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTotal.AutoSize = true;
            this.cclblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotal.Location = new System.Drawing.Point(645, 238);
            this.cclblTotal.Name = "cclblTotal";
            this.cclblTotal.Size = new System.Drawing.Size(40, 16);
            this.cclblTotal.TabIndex = 11;
            this.cclblTotal.Text = "Total:";
            // 
            // cclblValorTotal
            // 
            this.cclblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblValorTotal.AutoSize = true;
            this.cclblValorTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblValorTotal.Location = new System.Drawing.Point(691, 238);
            this.cclblValorTotal.Name = "cclblValorTotal";
            this.cclblValorTotal.Size = new System.Drawing.Size(15, 16);
            this.cclblValorTotal.TabIndex = 12;
            this.cclblValorTotal.Text = "0";
            // 
            // cctbFallaAReparar
            // 
            this.cctbFallaAReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbFallaAReparar.CaracterIncorrectErrorMessage = "";
            this.cctbFallaAReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbFallaAReparar.Location = new System.Drawing.Point(162, 137);
            this.cctbFallaAReparar.Name = "cctbFallaAReparar";
            this.cctbFallaAReparar.Size = new System.Drawing.Size(544, 24);
            this.cctbFallaAReparar.TabIndex = 13;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(171, 286);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaIngreso.TabIndex = 14;
            // 
            // cclblMarcaModelo
            // 
            this.cclblMarcaModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMarcaModelo.AutoSize = true;
            this.cclblMarcaModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarcaModelo.Location = new System.Drawing.Point(453, 42);
            this.cclblMarcaModelo.Name = "cclblMarcaModelo";
            this.cclblMarcaModelo.Size = new System.Drawing.Size(0, 16);
            this.cclblMarcaModelo.TabIndex = 15;
            // 
            // cboEstadoReparacion
            // 
            this.cboEstadoReparacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstadoReparacion.FormattingEnabled = true;
            this.cboEstadoReparacion.Location = new System.Drawing.Point(217, 89);
            this.cboEstadoReparacion.Name = "cboEstadoReparacion";
            this.cboEstadoReparacion.Size = new System.Drawing.Size(133, 21);
            this.cboEstadoReparacion.TabIndex = 16;
            // 
            // cctbReparacionRealizada
            // 
            this.cctbReparacionRealizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbReparacionRealizada.CaracterIncorrectErrorMessage = "";
            this.cctbReparacionRealizada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbReparacionRealizada.Location = new System.Drawing.Point(200, 186);
            this.cctbReparacionRealizada.Name = "cctbReparacionRealizada";
            this.cctbReparacionRealizada.Size = new System.Drawing.Size(506, 24);
            this.cctbReparacionRealizada.TabIndex = 17;
            // 
            // cctbManoObra
            // 
            this.cctbManoObra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbManoObra.CaracterIncorrectErrorMessage = "";
            this.cctbManoObra.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbManoObra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbManoObra.Location = new System.Drawing.Point(161, 235);
            this.cctbManoObra.Name = "cctbManoObra";
            this.cctbManoObra.Size = new System.Drawing.Size(153, 24);
            this.cctbManoObra.TabIndex = 18;
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Location = new System.Drawing.Point(485, 89);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(221, 20);
            this.dtpFechaEgreso.TabIndex = 19;
            // 
            // cctbValorRepuestos
            // 
            this.cctbValorRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbValorRepuestos.CaracterIncorrectErrorMessage = "";
            this.cctbValorRepuestos.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbValorRepuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbValorRepuestos.Location = new System.Drawing.Point(453, 235);
            this.cctbValorRepuestos.Name = "cctbValorRepuestos";
            this.cctbValorRepuestos.Size = new System.Drawing.Size(186, 24);
            this.cctbValorRepuestos.TabIndex = 20;
            // 
            // nudGarantia
            // 
            this.nudGarantia.Location = new System.Drawing.Point(495, 286);
            this.nudGarantia.Name = "nudGarantia";
            this.nudGarantia.Size = new System.Drawing.Size(48, 20);
            this.nudGarantia.TabIndex = 23;
            // 
            // dtpGarantia
            // 
            this.dtpGarantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGarantia.Location = new System.Drawing.Point(608, 283);
            this.dtpGarantia.Name = "dtpGarantia";
            this.dtpGarantia.Size = new System.Drawing.Size(98, 20);
            this.dtpGarantia.TabIndex = 24;
            // 
            // cclblFinaliza
            // 
            this.cclblFinaliza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFinaliza.AutoSize = true;
            this.cclblFinaliza.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFinaliza.Location = new System.Drawing.Point(549, 287);
            this.cclblFinaliza.Name = "cclblFinaliza";
            this.cclblFinaliza.Size = new System.Drawing.Size(53, 16);
            this.cclblFinaliza.TabIndex = 25;
            this.cclblFinaliza.Text = "Finaliza:";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cclblNombreApellidoCliente);
            this.pnlBody.Controls.Add(this.cclblCliente);
            this.pnlBody.Controls.Add(this.cclblLavarropa);
            this.pnlBody.Controls.Add(this.cclblFinaliza);
            this.pnlBody.Controls.Add(this.cclblFechaIngreso);
            this.pnlBody.Controls.Add(this.dtpGarantia);
            this.pnlBody.Controls.Add(this.cclblFechaEgreso);
            this.pnlBody.Controls.Add(this.nudGarantia);
            this.pnlBody.Controls.Add(this.cclblErrorReparar);
            this.pnlBody.Controls.Add(this.cclblEstadoReparacion);
            this.pnlBody.Controls.Add(this.cctbValorRepuestos);
            this.pnlBody.Controls.Add(this.cclblMesesGarantia);
            this.pnlBody.Controls.Add(this.dtpFechaEgreso);
            this.pnlBody.Controls.Add(this.cclblReparacionRealizada);
            this.pnlBody.Controls.Add(this.cctbManoObra);
            this.pnlBody.Controls.Add(this.cclblManoObra);
            this.pnlBody.Controls.Add(this.cctbReparacionRealizada);
            this.pnlBody.Controls.Add(this.cclblTotalRepuestos);
            this.pnlBody.Controls.Add(this.cboEstadoReparacion);
            this.pnlBody.Controls.Add(this.cclblTotal);
            this.pnlBody.Controls.Add(this.cclblMarcaModelo);
            this.pnlBody.Controls.Add(this.cclblValorTotal);
            this.pnlBody.Controls.Add(this.dtpFechaIngreso);
            this.pnlBody.Controls.Add(this.cctbFallaAReparar);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(780, 344);
            this.pnlBody.TabIndex = 26;
            // 
            // cclblNombreApellidoCliente
            // 
            this.cclblNombreApellidoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombreApellidoCliente.AutoSize = true;
            this.cclblNombreApellidoCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombreApellidoCliente.Location = new System.Drawing.Point(116, 42);
            this.cclblNombreApellidoCliente.Name = "cclblNombreApellidoCliente";
            this.cclblNombreApellidoCliente.Size = new System.Drawing.Size(0, 16);
            this.cclblNombreApellidoCliente.TabIndex = 27;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(60, 42);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(50, 16);
            this.cclblCliente.TabIndex = 26;
            this.cclblCliente.Text = "Cliente:";
            // 
            // frmModificarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 426);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.nudGarantia)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblFechaIngreso;
        private ccLibrary.ccLabel cclblFechaEgreso;
        private ccLibrary.ccLabel cclblErrorReparar;
        private ccLibrary.ccLabel cclblEstadoReparacion;
        private ccLibrary.ccLabel cclblMesesGarantia;
        private ccLibrary.ccLabel cclblReparacionRealizada;
        private ccLibrary.ccLabel cclblManoObra;
        private ccLibrary.ccLabel cclblTotalRepuestos;
        private ccLibrary.ccLabel cclblLavarropa;
        private ccLibrary.ccLabel cclblTotal;
        private ccLibrary.ccLabel cclblValorTotal;
        private ccLibrary.ccTextBox cctbFallaAReparar;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private ccLibrary.ccLabel cclblMarcaModelo;
        private System.Windows.Forms.ComboBox cboEstadoReparacion;
        private ccLibrary.ccTextBox cctbReparacionRealizada;
        private ccLibrary.ccTextBox cctbManoObra;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private ccLibrary.ccTextBox cctbValorRepuestos;
        private System.Windows.Forms.NumericUpDown nudGarantia;
        private System.Windows.Forms.DateTimePicker dtpGarantia;
        private ccLibrary.ccLabel cclblFinaliza;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccLabel cclblNombreApellidoCliente;
        private ccLibrary.ccLabel cclblCliente;
    }
}