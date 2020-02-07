using MAB.UC;

namespace MAB
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucBG = new ucBackGround();
            this.SuspendLayout();
            // 
            // ucBG
            // 
            this.ucBG.Accion1 = null;
            this.ucBG.Accion2 = null;
            this.ucBG.Accion3 = null;
            this.ucBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBG.Location = new System.Drawing.Point(0, 0);
            this.ucBG.Name = "ucBG";
            this.ucBG.Size = new System.Drawing.Size(878, 461);
            this.ucBG.TabIndex = 0;
            this.ucBG.Titulo = null;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 461);
            this.Controls.Add(this.ucBG);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucBackGround ucBG;
    }
}

