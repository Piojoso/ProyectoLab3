﻿using MAB.UC;

namespace MAB.Forms.CRUD.Reparaciones
{
    partial class frmReparaciones
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
            this.ucBG = new MAB.UC.ucBackGround();
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
            this.ucBG.Size = new System.Drawing.Size(744, 412);
            this.ucBG.TabIndex = 0;
            this.ucBG.Titulo = null;
            // 
            // frmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 412);
            this.Controls.Add(this.ucBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReparaciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.frmReparaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucBackGround ucBG;
    }
}