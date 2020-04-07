namespace MAB.Forms.CRUD.Lavarropas
{
    partial class frmLavarropas
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
            this.ucDGVTabla = new ucLibrary.ucDGVTabla();
            this.SuspendLayout();
            // 
            // ucDGVTabla
            // 
            this.ucDGVTabla.buttonAdd = System.Drawing.Color.ForestGreen;
            this.ucDGVTabla.buttonDelete = System.Drawing.Color.IndianRed;
            this.ucDGVTabla.buttonModify = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucDGVTabla.buttonSearch = System.Drawing.Color.SteelBlue;
            this.ucDGVTabla.buttonSeeAll = System.Drawing.Color.DarkGray;
            this.ucDGVTabla.cargarCMS = null;
            this.ucDGVTabla.ColumnHeaderStyle = null;
            this.ucDGVTabla.Columns = null;
            this.ucDGVTabla.DeleteVisibility = false;
            this.ucDGVTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDGVTabla.FondoBotones = System.Drawing.Color.Teal;
            this.ucDGVTabla.FullListData = null;
            this.ucDGVTabla.Location = new System.Drawing.Point(0, 0);
            this.ucDGVTabla.Name = "ucDGVTabla";
            this.ucDGVTabla.RowsCellStyle = null;
            this.ucDGVTabla.RowsHeaderStyle = null;
            this.ucDGVTabla.ShortListData = null;
            this.ucDGVTabla.Size = new System.Drawing.Size(806, 436);
            this.ucDGVTabla.TabIndex = 0;
            // 
            // frmLavarropas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 436);
            this.Controls.Add(this.ucDGVTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLavarropas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucDGVTabla ucDGVTabla;
    }
}