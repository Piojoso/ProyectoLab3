namespace MAB.Forms.Lavarropas
{
    partial class frmBuscarLavarropas
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
            this.cclblMarca = new ccLibrary.ccLabel();
            this.cclblModelo = new ccLibrary.ccLabel();
            this.cclblEstadoGeneral = new ccLibrary.ccLabel();
            this.cctbMarca = new ccLibrary.ccTextBox();
            this.cctbModelo = new ccLibrary.ccTextBox();
            this.cctbEstadoGeneral = new ccLibrary.ccTextBox();
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
            this.ucBottom.Location = new System.Drawing.Point(0, 243);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(580, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // cclblMarca
            // 
            this.cclblMarca.AutoSize = true;
            this.cclblMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarca.Location = new System.Drawing.Point(102, 56);
            this.cclblMarca.Name = "cclblMarca";
            this.cclblMarca.Size = new System.Drawing.Size(45, 16);
            this.cclblMarca.TabIndex = 1;
            this.cclblMarca.Text = "Marca";
            // 
            // cclblModelo
            // 
            this.cclblModelo.AutoSize = true;
            this.cclblModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblModelo.Location = new System.Drawing.Point(102, 114);
            this.cclblModelo.Name = "cclblModelo";
            this.cclblModelo.Size = new System.Drawing.Size(54, 16);
            this.cclblModelo.TabIndex = 2;
            this.cclblModelo.Text = "Modelo";
            // 
            // cclblEstadoGeneral
            // 
            this.cclblEstadoGeneral.AutoSize = true;
            this.cclblEstadoGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstadoGeneral.Location = new System.Drawing.Point(102, 170);
            this.cclblEstadoGeneral.Name = "cclblEstadoGeneral";
            this.cclblEstadoGeneral.Size = new System.Drawing.Size(97, 16);
            this.cclblEstadoGeneral.TabIndex = 3;
            this.cclblEstadoGeneral.Text = "Estado General";
            // 
            // cctbMarca
            // 
            this.cctbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbMarca.CaracterIncorrectErrorMessage = "";
            this.cctbMarca.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbMarca.Location = new System.Drawing.Point(247, 53);
            this.cctbMarca.Name = "cctbMarca";
            this.cctbMarca.Size = new System.Drawing.Size(231, 24);
            this.cctbMarca.TabIndex = 4;
            // 
            // cctbModelo
            // 
            this.cctbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbModelo.CaracterIncorrectErrorMessage = "";
            this.cctbModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbModelo.Location = new System.Drawing.Point(247, 111);
            this.cctbModelo.Name = "cctbModelo";
            this.cctbModelo.Size = new System.Drawing.Size(231, 24);
            this.cctbModelo.TabIndex = 5;
            // 
            // cctbEstadoGeneral
            // 
            this.cctbEstadoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbEstadoGeneral.CaracterIncorrectErrorMessage = "";
            this.cctbEstadoGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbEstadoGeneral.Location = new System.Drawing.Point(247, 167);
            this.cctbEstadoGeneral.Name = "cctbEstadoGeneral";
            this.cctbEstadoGeneral.Size = new System.Drawing.Size(231, 24);
            this.cctbEstadoGeneral.TabIndex = 6;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbEstadoGeneral);
            this.pnlBody.Controls.Add(this.cclblMarca);
            this.pnlBody.Controls.Add(this.cctbModelo);
            this.pnlBody.Controls.Add(this.cclblModelo);
            this.pnlBody.Controls.Add(this.cctbMarca);
            this.pnlBody.Controls.Add(this.cclblEstadoGeneral);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(580, 243);
            this.pnlBody.TabIndex = 7;
            // 
            // frmBuscarLavarropas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 325);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarLavarropas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblMarca;
        private ccLibrary.ccLabel cclblModelo;
        private ccLibrary.ccLabel cclblEstadoGeneral;
        private ccLibrary.ccTextBox cctbMarca;
        private ccLibrary.ccTextBox cctbModelo;
        private ccLibrary.ccTextBox cctbEstadoGeneral;
        private System.Windows.Forms.Panel pnlBody;
    }
}