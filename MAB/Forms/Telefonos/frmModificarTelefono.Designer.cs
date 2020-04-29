namespace MAB.Forms.Telefonos
{
    partial class frmModificarTelefono
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
            this.cclblNombreCliente = new ccLibrary.ccLabel();
            this.cclblTelefono = new ccLibrary.ccLabel();
            this.cctbNumTelefono = new ccLibrary.ccTextBox();
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
            this.ucBottom.Location = new System.Drawing.Point(0, 164);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(551, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(113, 44);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(47, 16);
            this.cclblCliente.TabIndex = 1;
            this.cclblCliente.Text = "Cliente";
            // 
            // cclblNombreCliente
            // 
            this.cclblNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombreCliente.AutoSize = true;
            this.cclblNombreCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombreCliente.Location = new System.Drawing.Point(204, 44);
            this.cclblNombreCliente.Name = "cclblNombreCliente";
            this.cclblNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.cclblNombreCliente.TabIndex = 2;
            // 
            // cclblTelefono
            // 
            this.cclblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTelefono.AutoSize = true;
            this.cclblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTelefono.Location = new System.Drawing.Point(113, 104);
            this.cclblTelefono.Name = "cclblTelefono";
            this.cclblTelefono.Size = new System.Drawing.Size(59, 16);
            this.cclblTelefono.TabIndex = 3;
            this.cclblTelefono.Text = "Telefono";
            // 
            // cctbNumTelefono
            // 
            this.cctbNumTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbNumTelefono.CaracterIncorrectErrorMessage = "";
            this.cctbNumTelefono.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbNumTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbNumTelefono.Location = new System.Drawing.Point(207, 101);
            this.cctbNumTelefono.Name = "cctbNumTelefono";
            this.cctbNumTelefono.Size = new System.Drawing.Size(231, 24);
            this.cctbNumTelefono.TabIndex = 4;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbNumTelefono);
            this.pnlBody.Controls.Add(this.cclblCliente);
            this.pnlBody.Controls.Add(this.cclblTelefono);
            this.pnlBody.Controls.Add(this.cclblNombreCliente);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(551, 164);
            this.pnlBody.TabIndex = 5;
            // 
            // frmModificarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 246);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarTelefono";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccLabel cclblNombreCliente;
        private ccLibrary.ccLabel cclblTelefono;
        private ccLibrary.ccTextBox cctbNumTelefono;
        private System.Windows.Forms.Panel pnlBody;
    }
}