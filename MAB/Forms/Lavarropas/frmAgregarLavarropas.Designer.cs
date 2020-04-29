namespace MAB.Forms.Lavarropas
{
    partial class frmAgregarLavarropas
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
            this.cctbEstado = new ccLibrary.ccTextBox();
            this.cctbModelo = new ccLibrary.ccTextBox();
            this.cctbMarca = new ccLibrary.ccTextBox();
            this.cclblEstado = new ccLibrary.ccLabel();
            this.cclblModelo = new ccLibrary.ccLabel();
            this.cclblMarca = new ccLibrary.ccLabel();
            this.cclblNombreCliente = new ccLibrary.ccLabel();
            this.cclblCliente = new ccLibrary.ccLabel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 253);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(669, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbEstado);
            this.pnlBody.Controls.Add(this.cctbModelo);
            this.pnlBody.Controls.Add(this.cctbMarca);
            this.pnlBody.Controls.Add(this.cclblEstado);
            this.pnlBody.Controls.Add(this.cclblModelo);
            this.pnlBody.Controls.Add(this.cclblMarca);
            this.pnlBody.Controls.Add(this.cclblNombreCliente);
            this.pnlBody.Controls.Add(this.cclblCliente);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(669, 253);
            this.pnlBody.TabIndex = 1;
            // 
            // cctbEstado
            // 
            this.cctbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbEstado.CaracterIncorrectErrorMessage = "";
            this.cctbEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbEstado.Location = new System.Drawing.Point(298, 185);
            this.cctbEstado.Name = "cctbEstado";
            this.cctbEstado.Size = new System.Drawing.Size(231, 24);
            this.cctbEstado.TabIndex = 7;
            // 
            // cctbModelo
            // 
            this.cctbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbModelo.CaracterIncorrectErrorMessage = "";
            this.cctbModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbModelo.Location = new System.Drawing.Point(298, 135);
            this.cctbModelo.Name = "cctbModelo";
            this.cctbModelo.Size = new System.Drawing.Size(231, 24);
            this.cctbModelo.TabIndex = 6;
            // 
            // cctbMarca
            // 
            this.cctbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbMarca.CaracterIncorrectErrorMessage = "";
            this.cctbMarca.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbMarca.Location = new System.Drawing.Point(298, 85);
            this.cctbMarca.Name = "cctbMarca";
            this.cctbMarca.Size = new System.Drawing.Size(231, 24);
            this.cctbMarca.TabIndex = 5;
            // 
            // cclblEstado
            // 
            this.cclblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblEstado.AutoSize = true;
            this.cclblEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstado.Location = new System.Drawing.Point(140, 188);
            this.cclblEstado.Name = "cclblEstado";
            this.cclblEstado.Size = new System.Drawing.Size(97, 16);
            this.cclblEstado.TabIndex = 4;
            this.cclblEstado.Text = "Estado General";
            // 
            // cclblModelo
            // 
            this.cclblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblModelo.AutoSize = true;
            this.cclblModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblModelo.Location = new System.Drawing.Point(140, 138);
            this.cclblModelo.Name = "cclblModelo";
            this.cclblModelo.Size = new System.Drawing.Size(54, 16);
            this.cclblModelo.TabIndex = 3;
            this.cclblModelo.Text = "Modelo";
            // 
            // cclblMarca
            // 
            this.cclblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMarca.AutoSize = true;
            this.cclblMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarca.Location = new System.Drawing.Point(140, 88);
            this.cclblMarca.Name = "cclblMarca";
            this.cclblMarca.Size = new System.Drawing.Size(45, 16);
            this.cclblMarca.TabIndex = 2;
            this.cclblMarca.Text = "Marca";
            // 
            // cclblNombreCliente
            // 
            this.cclblNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombreCliente.AutoSize = true;
            this.cclblNombreCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombreCliente.Location = new System.Drawing.Point(295, 43);
            this.cclblNombreCliente.Name = "cclblNombreCliente";
            this.cclblNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.cclblNombreCliente.TabIndex = 1;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(140, 43);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(47, 16);
            this.cclblCliente.TabIndex = 0;
            this.cclblCliente.Text = "Cliente";
            // 
            // frmAgregarLavarropas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 335);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarLavarropas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccLabel cclblNombreCliente;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccTextBox cctbEstado;
        private ccLibrary.ccTextBox cctbModelo;
        private ccLibrary.ccTextBox cctbMarca;
        private ccLibrary.ccLabel cclblEstado;
        private ccLibrary.ccLabel cclblModelo;
        private ccLibrary.ccLabel cclblMarca;
    }
}