namespace MAB.Forms.CRUD.Telefonos
{
    partial class frmAgregarTelefono
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
            this.cclblCliente = new ccLibrary.ccLabel();
            this.cclblIdCliente = new ccLibrary.ccLabel();
            this.cclblTelefono = new ccLibrary.ccLabel();
            this.cctbTelefono = new ccLibrary.ccTextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 156);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(563, 82);
            this.ucBottom.TabIndex = 1;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(110, 42);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(47, 16);
            this.cclblCliente.TabIndex = 0;
            this.cclblCliente.Text = "Cliente";
            // 
            // cclblIdCliente
            // 
            this.cclblIdCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblIdCliente.AutoSize = true;
            this.cclblIdCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblIdCliente.Location = new System.Drawing.Point(219, 42);
            this.cclblIdCliente.Name = "cclblIdCliente";
            this.cclblIdCliente.Size = new System.Drawing.Size(15, 16);
            this.cclblIdCliente.TabIndex = 0;
            this.cclblIdCliente.Text = "0";
            // 
            // cclblTelefono
            // 
            this.cclblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTelefono.AutoSize = true;
            this.cclblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTelefono.Location = new System.Drawing.Point(110, 101);
            this.cclblTelefono.Name = "cclblTelefono";
            this.cclblTelefono.Size = new System.Drawing.Size(59, 16);
            this.cclblTelefono.TabIndex = 0;
            this.cclblTelefono.Text = "Telefono";
            // 
            // cctbTelefono
            // 
            this.cctbTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbTelefono.Location = new System.Drawing.Point(222, 101);
            this.cctbTelefono.Name = "cctbTelefono";
            this.cctbTelefono.Size = new System.Drawing.Size(231, 24);
            this.cctbTelefono.TabIndex = 6;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbTelefono);
            this.pnlBody.Controls.Add(this.cclblCliente);
            this.pnlBody.Controls.Add(this.cclblIdCliente);
            this.pnlBody.Controls.Add(this.cclblTelefono);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(563, 156);
            this.pnlBody.TabIndex = 7;
            // 
            // frmAgregarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 238);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarTelefono";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Agregar un nuevo Telefono";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccLabel cclblIdCliente;
        private ccLibrary.ccLabel cclblTelefono;
        private ccLibrary.ccTextBox cctbTelefono;
        private System.Windows.Forms.Panel pnlBody;
    }
}