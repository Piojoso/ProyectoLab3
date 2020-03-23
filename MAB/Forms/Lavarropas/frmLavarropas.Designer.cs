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
            this.ucBackGround1 = new MAB.UC.ucBackGround();
            this.SuspendLayout();
            // 
            // ucBackGround1
            // 
            this.ucBackGround1.Accion1 = null;
            this.ucBackGround1.Accion2 = null;
            this.ucBackGround1.Accion3 = null;
            this.ucBackGround1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBackGround1.Location = new System.Drawing.Point(0, 0);
            this.ucBackGround1.Name = "ucBackGround1";
            this.ucBackGround1.Size = new System.Drawing.Size(800, 450);
            this.ucBackGround1.TabIndex = 0;
            this.ucBackGround1.Titulo = null;
            // 
            // frmLavarropas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucBackGround1);
            this.Name = "frmLavarropas";
            this.Text = "frmLavarropas";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucBackGround ucBackGround1;
    }
}