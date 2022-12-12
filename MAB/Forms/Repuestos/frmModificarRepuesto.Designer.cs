namespace MAB.Forms.Repuestos
{
    partial class frmModificarRepuesto
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
            this.cctbStock = new ccLibrary.ccTextBox();
            this.cctbPrecio = new ccLibrary.ccTextBox();
            this.cctbDescripcion = new ccLibrary.ccTextBox();
            this.cctbNombre = new ccLibrary.ccTextBox();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 248);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(600, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbStock);
            this.pnlBody.Controls.Add(this.cctbPrecio);
            this.pnlBody.Controls.Add(this.cctbDescripcion);
            this.pnlBody.Controls.Add(this.cctbNombre);
            this.pnlBody.Controls.Add(this.ccLabel1);
            this.pnlBody.Controls.Add(this.ccLabel4);
            this.pnlBody.Controls.Add(this.ccLabel2);
            this.pnlBody.Controls.Add(this.ccLabel3);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(600, 248);
            this.pnlBody.TabIndex = 1;
            // 
            // cctbStock
            // 
            this.cctbStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbStock.CaracterIncorrectErrorMessage = "";
            this.cctbStock.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbStock.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbStock.Location = new System.Drawing.Point(258, 187);
            this.cctbStock.Name = "cctbStock";
            this.cctbStock.Size = new System.Drawing.Size(231, 24);
            this.cctbStock.TabIndex = 16;
            // 
            // cctbPrecio
            // 
            this.cctbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbPrecio.CaracterIncorrectErrorMessage = "";
            this.cctbPrecio.DataType = ccLibrary.ccTextBox.dataType.Numerico;
            this.cctbPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbPrecio.Location = new System.Drawing.Point(258, 137);
            this.cctbPrecio.Name = "cctbPrecio";
            this.cctbPrecio.Size = new System.Drawing.Size(231, 24);
            this.cctbPrecio.TabIndex = 15;
            // 
            // cctbDescripcion
            // 
            this.cctbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbDescripcion.CaracterIncorrectErrorMessage = "";
            this.cctbDescripcion.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbDescripcion.Location = new System.Drawing.Point(258, 87);
            this.cctbDescripcion.Name = "cctbDescripcion";
            this.cctbDescripcion.Size = new System.Drawing.Size(231, 24);
            this.cctbDescripcion.TabIndex = 14;
            // 
            // cctbNombre
            // 
            this.cctbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbNombre.CaracterIncorrectErrorMessage = "";
            this.cctbNombre.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbNombre.Location = new System.Drawing.Point(258, 37);
            this.cctbNombre.Name = "cctbNombre";
            this.cctbNombre.Size = new System.Drawing.Size(231, 24);
            this.cctbNombre.TabIndex = 13;
            // 
            // ccLabel1
            // 
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(112, 40);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(57, 16);
            this.ccLabel1.TabIndex = 9;
            this.ccLabel1.Text = "Nombre";
            // 
            // ccLabel4
            // 
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(112, 190);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(39, 16);
            this.ccLabel4.TabIndex = 12;
            this.ccLabel4.Text = "Stock";
            // 
            // ccLabel2
            // 
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(112, 90);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(76, 16);
            this.ccLabel2.TabIndex = 10;
            this.ccLabel2.Text = "Descripcion";
            // 
            // ccLabel3
            // 
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(112, 140);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(44, 16);
            this.ccLabel3.TabIndex = 11;
            this.ccLabel3.Text = "Precio";
            // 
            // frmModificarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarRepuesto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccTextBox cctbStock;
        private ccLibrary.ccTextBox cctbPrecio;
        private ccLibrary.ccTextBox cctbDescripcion;
        private ccLibrary.ccTextBox cctbNombre;
        private ccLibrary.ccLabel ccLabel1;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel3;
    }
}