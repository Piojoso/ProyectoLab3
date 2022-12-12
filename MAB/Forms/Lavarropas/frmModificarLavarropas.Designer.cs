namespace MAB.Forms.Lavarropas
{
    partial class frmModificarLavarropas
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
            this.cctbEstadoGeneral = new ccLibrary.ccTextBox();
            this.cctbModelo = new ccLibrary.ccTextBox();
            this.cctbMarca = new ccLibrary.ccTextBox();
            this.cclblEstadoGeneral = new ccLibrary.ccLabel();
            this.cclblModelo = new ccLibrary.ccLabel();
            this.cclblMarca = new ccLibrary.ccLabel();
            this.cclblNumId = new ccLibrary.ccLabel();
            this.cclblId = new ccLibrary.ccLabel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 264);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(623, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbEstadoGeneral);
            this.pnlBody.Controls.Add(this.cctbModelo);
            this.pnlBody.Controls.Add(this.cctbMarca);
            this.pnlBody.Controls.Add(this.cclblEstadoGeneral);
            this.pnlBody.Controls.Add(this.cclblModelo);
            this.pnlBody.Controls.Add(this.cclblMarca);
            this.pnlBody.Controls.Add(this.cclblNumId);
            this.pnlBody.Controls.Add(this.cclblId);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(623, 264);
            this.pnlBody.TabIndex = 1;
            // 
            // cctbEstadoGeneral
            // 
            this.cctbEstadoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbEstadoGeneral.CaracterIncorrectErrorMessage = "";
            this.cctbEstadoGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbEstadoGeneral.Location = new System.Drawing.Point(278, 209);
            this.cctbEstadoGeneral.Name = "cctbEstadoGeneral";
            this.cctbEstadoGeneral.Size = new System.Drawing.Size(231, 24);
            this.cctbEstadoGeneral.TabIndex = 7;
            // 
            // cctbModelo
            // 
            this.cctbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbModelo.CaracterIncorrectErrorMessage = "";
            this.cctbModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbModelo.Location = new System.Drawing.Point(278, 150);
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
            this.cctbMarca.Location = new System.Drawing.Point(278, 91);
            this.cctbMarca.Name = "cctbMarca";
            this.cctbMarca.Size = new System.Drawing.Size(231, 24);
            this.cctbMarca.TabIndex = 5;
            // 
            // cclblEstadoGeneral
            // 
            this.cclblEstadoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblEstadoGeneral.AutoSize = true;
            this.cclblEstadoGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstadoGeneral.Location = new System.Drawing.Point(114, 212);
            this.cclblEstadoGeneral.Name = "cclblEstadoGeneral";
            this.cclblEstadoGeneral.Size = new System.Drawing.Size(97, 16);
            this.cclblEstadoGeneral.TabIndex = 4;
            this.cclblEstadoGeneral.Text = "Estado General";
            // 
            // cclblModelo
            // 
            this.cclblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblModelo.AutoSize = true;
            this.cclblModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblModelo.Location = new System.Drawing.Point(114, 153);
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
            this.cclblMarca.Location = new System.Drawing.Point(114, 94);
            this.cclblMarca.Name = "cclblMarca";
            this.cclblMarca.Size = new System.Drawing.Size(45, 16);
            this.cclblMarca.TabIndex = 2;
            this.cclblMarca.Text = "Marca";
            // 
            // cclblNumId
            // 
            this.cclblNumId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNumId.AutoSize = true;
            this.cclblNumId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNumId.Location = new System.Drawing.Point(275, 35);
            this.cclblNumId.Name = "cclblNumId";
            this.cclblNumId.Size = new System.Drawing.Size(0, 16);
            this.cclblNumId.TabIndex = 1;
            // 
            // cclblId
            // 
            this.cclblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblId.AutoSize = true;
            this.cclblId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblId.Location = new System.Drawing.Point(114, 35);
            this.cclblId.Name = "cclblId";
            this.cclblId.Size = new System.Drawing.Size(19, 16);
            this.cclblId.TabIndex = 0;
            this.cclblId.Text = "Id";
            // 
            // frmModificarLavarropas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 346);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarLavarropas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccLabel cclblEstadoGeneral;
        private ccLibrary.ccLabel cclblModelo;
        private ccLibrary.ccLabel cclblMarca;
        private ccLibrary.ccLabel cclblNumId;
        private ccLibrary.ccLabel cclblId;
        private ccLibrary.ccTextBox cctbEstadoGeneral;
        private ccLibrary.ccTextBox cctbModelo;
        private ccLibrary.ccTextBox cctbMarca;
    }
}