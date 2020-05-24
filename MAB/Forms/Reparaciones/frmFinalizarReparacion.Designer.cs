namespace MAB.Forms.Reparaciones
{
    partial class frmFinalizarReparacion
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
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel5 = new ccLibrary.ccLabel();
            this.ccLabel6 = new ccLibrary.ccLabel();
            this.cclblNumReparacion = new ccLibrary.ccLabel();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.cboEstadoReparacion = new System.Windows.Forms.ComboBox();
            this.cctbMesesGarantia = new ccLibrary.ccTextBox();
            this.cctbManoObra = new ccLibrary.ccTextBox();
            this.cctbTotalRepuestos = new ccLibrary.ccTextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.ccLabel8 = new ccLibrary.ccLabel();
            this.cctbReparacionRealizada = new ccLibrary.ccTextBox();
            this.ccLabel7 = new ccLibrary.ccLabel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 307);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(692, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // ccLabel1
            // 
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(131, 25);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(94, 16);
            this.ccLabel1.TabIndex = 1;
            this.ccLabel1.Text = "Nº Reparacion";
            // 
            // ccLabel2
            // 
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(131, 72);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(137, 16);
            this.ccLabel2.TabIndex = 2;
            this.ccLabel2.Text = "Estado de Reparacion";
            // 
            // ccLabel3
            // 
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(131, 119);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(105, 16);
            this.ccLabel3.TabIndex = 3;
            this.ccLabel3.Text = "Fecha de Egreso";
            // 
            // ccLabel4
            // 
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(42, 166);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(118, 16);
            this.ccLabel4.TabIndex = 4;
            this.ccLabel4.Text = "Meses de Garantia";
            // 
            // ccLabel5
            // 
            this.ccLabel5.AutoSize = true;
            this.ccLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel5.Location = new System.Drawing.Point(378, 166);
            this.ccLabel5.Name = "ccLabel5";
            this.ccLabel5.Size = new System.Drawing.Size(95, 16);
            this.ccLabel5.TabIndex = 5;
            this.ccLabel5.Text = "Mano de Obra";
            // 
            // ccLabel6
            // 
            this.ccLabel6.AutoSize = true;
            this.ccLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel6.Location = new System.Drawing.Point(131, 213);
            this.ccLabel6.Name = "ccLabel6";
            this.ccLabel6.Size = new System.Drawing.Size(121, 16);
            this.ccLabel6.TabIndex = 6;
            this.ccLabel6.Text = "Total de Repuestos";
            // 
            // cclblNumReparacion
            // 
            this.cclblNumReparacion.AutoSize = true;
            this.cclblNumReparacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNumReparacion.Location = new System.Drawing.Point(332, 25);
            this.cclblNumReparacion.Name = "cclblNumReparacion";
            this.cclblNumReparacion.Size = new System.Drawing.Size(0, 16);
            this.cclblNumReparacion.TabIndex = 7;
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaEgreso.Location = new System.Drawing.Point(335, 114);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaEgreso.TabIndex = 8;
            // 
            // cboEstadoReparacion
            // 
            this.cboEstadoReparacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstadoReparacion.FormattingEnabled = true;
            this.cboEstadoReparacion.Location = new System.Drawing.Point(335, 70);
            this.cboEstadoReparacion.Name = "cboEstadoReparacion";
            this.cboEstadoReparacion.Size = new System.Drawing.Size(231, 21);
            this.cboEstadoReparacion.TabIndex = 9;
            // 
            // cctbMesesGarantia
            // 
            this.cctbMesesGarantia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbMesesGarantia.CaracterIncorrectErrorMessage = "";
            this.cctbMesesGarantia.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbMesesGarantia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbMesesGarantia.Location = new System.Drawing.Point(198, 163);
            this.cctbMesesGarantia.Name = "cctbMesesGarantia";
            this.cctbMesesGarantia.Size = new System.Drawing.Size(136, 24);
            this.cctbMesesGarantia.TabIndex = 10;
            // 
            // cctbManoObra
            // 
            this.cctbManoObra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbManoObra.CaracterIncorrectErrorMessage = "";
            this.cctbManoObra.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbManoObra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbManoObra.Location = new System.Drawing.Point(515, 163);
            this.cctbManoObra.Name = "cctbManoObra";
            this.cctbManoObra.Size = new System.Drawing.Size(136, 24);
            this.cctbManoObra.TabIndex = 11;
            // 
            // cctbTotalRepuestos
            // 
            this.cctbTotalRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbTotalRepuestos.CaracterIncorrectErrorMessage = "";
            this.cctbTotalRepuestos.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbTotalRepuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbTotalRepuestos.Location = new System.Drawing.Point(335, 210);
            this.cctbTotalRepuestos.Name = "cctbTotalRepuestos";
            this.cctbTotalRepuestos.Size = new System.Drawing.Size(231, 24);
            this.cctbTotalRepuestos.TabIndex = 12;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnRepuestos);
            this.pnlBody.Controls.Add(this.ccLabel8);
            this.pnlBody.Controls.Add(this.cctbReparacionRealizada);
            this.pnlBody.Controls.Add(this.ccLabel7);
            this.pnlBody.Controls.Add(this.ccLabel1);
            this.pnlBody.Controls.Add(this.cctbTotalRepuestos);
            this.pnlBody.Controls.Add(this.ccLabel2);
            this.pnlBody.Controls.Add(this.cctbManoObra);
            this.pnlBody.Controls.Add(this.ccLabel3);
            this.pnlBody.Controls.Add(this.cctbMesesGarantia);
            this.pnlBody.Controls.Add(this.ccLabel4);
            this.pnlBody.Controls.Add(this.cboEstadoReparacion);
            this.pnlBody.Controls.Add(this.ccLabel5);
            this.pnlBody.Controls.Add(this.dtpFechaEgreso);
            this.pnlBody.Controls.Add(this.ccLabel6);
            this.pnlBody.Controls.Add(this.cclblNumReparacion);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(692, 307);
            this.pnlBody.TabIndex = 13;
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRepuestos.Location = new System.Drawing.Point(495, 256);
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(136, 23);
            this.btnRepuestos.TabIndex = 16;
            this.btnRepuestos.Text = "Ver Repuestos";
            this.btnRepuestos.UseVisualStyleBackColor = true;
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // ccLabel8
            // 
            this.ccLabel8.AutoSize = true;
            this.ccLabel8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel8.Location = new System.Drawing.Point(356, 260);
            this.ccLabel8.Name = "ccLabel8";
            this.ccLabel8.Size = new System.Drawing.Size(117, 16);
            this.ccLabel8.TabIndex = 15;
            this.ccLabel8.Text = "Repuestos Usados";
            // 
            // cctbReparacionRealizada
            // 
            this.cctbReparacionRealizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbReparacionRealizada.CaracterIncorrectErrorMessage = "";
            this.cctbReparacionRealizada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbReparacionRealizada.Location = new System.Drawing.Point(198, 257);
            this.cctbReparacionRealizada.Name = "cctbReparacionRealizada";
            this.cctbReparacionRealizada.Size = new System.Drawing.Size(136, 24);
            this.cctbReparacionRealizada.TabIndex = 14;
            // 
            // ccLabel7
            // 
            this.ccLabel7.AutoSize = true;
            this.ccLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel7.Location = new System.Drawing.Point(42, 260);
            this.ccLabel7.Name = "ccLabel7";
            this.ccLabel7.Size = new System.Drawing.Size(134, 16);
            this.ccLabel7.TabIndex = 13;
            this.ccLabel7.Text = "Reparacion Realizada";
            // 
            // frmFinalizarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 389);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinalizarReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel ccLabel1;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel3;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel5;
        private ccLibrary.ccLabel ccLabel6;
        private ccLibrary.ccLabel cclblNumReparacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.ComboBox cboEstadoReparacion;
        private ccLibrary.ccTextBox cctbMesesGarantia;
        private ccLibrary.ccTextBox cctbManoObra;
        private ccLibrary.ccTextBox cctbTotalRepuestos;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccTextBox cctbReparacionRealizada;
        private ccLibrary.ccLabel ccLabel7;
        private System.Windows.Forms.Button btnRepuestos;
        private ccLibrary.ccLabel ccLabel8;
    }
}