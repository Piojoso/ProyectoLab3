namespace MAB.Forms.Entregas
{
    partial class frmAgregarEntrega
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.cclblCliente = new ccLibrary.ccLabel();
            this.cclblNumReparacion = new ccLibrary.ccLabel();
            this.cctbMonto = new ccLibrary.ccTextBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 255);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(616, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dtpFechaEntrega);
            this.pnlBody.Controls.Add(this.cctbMonto);
            this.pnlBody.Controls.Add(this.cclblNumReparacion);
            this.pnlBody.Controls.Add(this.cclblCliente);
            this.pnlBody.Controls.Add(this.ccLabel4);
            this.pnlBody.Controls.Add(this.ccLabel3);
            this.pnlBody.Controls.Add(this.ccLabel2);
            this.pnlBody.Controls.Add(this.ccLabel1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(616, 255);
            this.pnlBody.TabIndex = 1;
            // 
            // ccLabel1
            // 
            this.ccLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(127, 40);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(50, 16);
            this.ccLabel1.TabIndex = 0;
            this.ccLabel1.Text = "Cliente:";
            // 
            // ccLabel2
            // 
            this.ccLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(127, 93);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(97, 16);
            this.ccLabel2.TabIndex = 1;
            this.ccLabel2.Text = "Nº Reparacion:";
            // 
            // ccLabel3
            // 
            this.ccLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(127, 146);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(50, 16);
            this.ccLabel3.TabIndex = 2;
            this.ccLabel3.Text = "Monto:";
            // 
            // ccLabel4
            // 
            this.ccLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(127, 199);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(112, 16);
            this.ccLabel4.TabIndex = 3;
            this.ccLabel4.Text = "Fecha de Entrega:";
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(256, 40);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(0, 16);
            this.cclblCliente.TabIndex = 4;
            // 
            // cclblNumReparacion
            // 
            this.cclblNumReparacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNumReparacion.AutoSize = true;
            this.cclblNumReparacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNumReparacion.Location = new System.Drawing.Point(256, 93);
            this.cclblNumReparacion.Name = "cclblNumReparacion";
            this.cclblNumReparacion.Size = new System.Drawing.Size(0, 16);
            this.cclblNumReparacion.TabIndex = 5;
            // 
            // cctbMonto
            // 
            this.cctbMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbMonto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbMonto.Location = new System.Drawing.Point(259, 143);
            this.cctbMonto.Name = "cctbMonto";
            this.cctbMonto.Size = new System.Drawing.Size(231, 24);
            this.cctbMonto.TabIndex = 6;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(259, 195);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaEntrega.TabIndex = 7;
            // 
            // frmAgregarEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 337);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarEntrega";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private ccLibrary.ccTextBox cctbMonto;
        private ccLibrary.ccLabel cclblNumReparacion;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel3;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel1;
    }
}