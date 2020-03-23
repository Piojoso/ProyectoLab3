namespace MAB.Forms.CRUD.Telefonos
{
    partial class frmTelefonos
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
            this.ucBackGround = new MAB.UC.ucBackGround();
            this.SuspendLayout();
            // 
            // ucBackGround
            // 
            this.ucBackGround.Accion1 = null;
            this.ucBackGround.Accion2 = null;
            this.ucBackGround.Accion3 = null;
            this.ucBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBackGround.Location = new System.Drawing.Point(0, 0);
            this.ucBackGround.Name = "ucBackGround";
            this.ucBackGround.Size = new System.Drawing.Size(716, 420);
            this.ucBackGround.TabIndex = 0;
            this.ucBackGround.Titulo = null;
            // 
            // frmTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 420);
            this.Controls.Add(this.ucBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelefonos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTelefonos";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucBackGround ucBackGround;
    }
}