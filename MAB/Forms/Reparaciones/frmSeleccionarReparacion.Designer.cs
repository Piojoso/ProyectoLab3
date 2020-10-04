namespace MAB.Forms.Reparaciones
{
    partial class frmSeleccionarReparacion
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
            this.ucDGVTabla = new ucLibrary.ucDGVTabla();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 325);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.Size = new System.Drawing.Size(693, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // ucDGVTabla
            // 
            this.ucDGVTabla.buttonAdd = System.Drawing.Color.ForestGreen;
            this.ucDGVTabla.buttonDelete = System.Drawing.Color.IndianRed;
            this.ucDGVTabla.buttonModify = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucDGVTabla.ButtonPadVisibility = false;
            this.ucDGVTabla.buttonSearch = System.Drawing.Color.SteelBlue;
            this.ucDGVTabla.buttonSeeAll = System.Drawing.Color.DarkGray;
            this.ucDGVTabla.cargarCMS = null;
            this.ucDGVTabla.ColumnHeaderStyle = null;
            this.ucDGVTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDGVTabla.FondoBotones = System.Drawing.Color.Empty;
            this.ucDGVTabla.FullListData = null;
            this.ucDGVTabla.Location = new System.Drawing.Point(0, 0);
            this.ucDGVTabla.Name = "ucDGVTabla";
            this.ucDGVTabla.RowsCellStyle = null;
            this.ucDGVTabla.RowsHeaderStyle = null;
            this.ucDGVTabla.ShortListData = null;
            this.ucDGVTabla.Size = new System.Drawing.Size(693, 325);
            this.ucDGVTabla.TabIndex = 1;
            // 
            // frmSeleccionarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 407);
            this.Controls.Add(this.ucDGVTabla);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionarReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSeleccionarReparacion";
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ucLibrary.ucDGVTabla ucDGVTabla;
    }
}