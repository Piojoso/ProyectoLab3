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
            this.ucTop = new ucLibrary.ucTop();
            this.ucBottom = new ucLibrary.ucBottom();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.cclblCliente = new ccLibrary.ccLabel();
            this.cclblIdCliente = new ccLibrary.ccLabel();
            this.cclblTelefono = new ccLibrary.ccLabel();
            this.SuspendLayout();
            // 
            // ucTop
            // 
            this.ucTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTop.Location = new System.Drawing.Point(0, 0);
            this.ucTop.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucTop.Name = "ucTop";
            this.ucTop.Size = new System.Drawing.Size(645, 82);
            this.ucTop.TabIndex = 0;
            this.ucTop.Titulo = null;
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 258);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(645, 82);
            this.ucBottom.TabIndex = 1;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(265, 190);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(231, 20);
            this.tbTelefono.TabIndex = 5;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(149, 130);
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
            this.cclblIdCliente.Location = new System.Drawing.Point(262, 130);
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
            this.cclblTelefono.Location = new System.Drawing.Point(149, 192);
            this.cclblTelefono.Name = "cclblTelefono";
            this.cclblTelefono.Size = new System.Drawing.Size(59, 16);
            this.cclblTelefono.TabIndex = 0;
            this.cclblTelefono.Text = "Telefono";
            // 
            // frmAgregarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 340);
            this.Controls.Add(this.ucBottom);
            this.Controls.Add(this.ucTop);
            this.Controls.Add(this.cclblTelefono);
            this.Controls.Add(this.cclblIdCliente);
            this.Controls.Add(this.cclblCliente);
            this.Controls.Add(this.tbTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarTelefono";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Agregar un nuevo Telefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucLibrary.ucTop ucTop;
        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.TextBox tbTelefono;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccLabel cclblIdCliente;
        private ccLibrary.ccLabel cclblTelefono;
    }
}