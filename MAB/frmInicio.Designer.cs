namespace MAB.Forms
{
    partial class frmInicio
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
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.ucBotonera = new ucLibrary.ucBotonera();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ucTitleBar = new ucLibrary.ucTitleBar();
            this.pnlBG.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.pnlBody);
            this.pnlBG.Controls.Add(this.pnlTitulo);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(800, 450);
            this.pnlBG.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlContent);
            this.pnlBody.Controls.Add(this.pnlNavBar);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 25);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(800, 425);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(168, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(632, 425);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlNavBar.Controls.Add(this.ucBotonera);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(168, 425);
            this.pnlNavBar.TabIndex = 0;
            // 
            // ucBotonera
            // 
            this.ucBotonera.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ucBotonera.btnAccion1 = "Accion 1";
            this.ucBotonera.btnAccion2 = "Accion 2";
            this.ucBotonera.btnAccion3 = "Accion 3";
            this.ucBotonera.btnAccion4 = "Accion 4";
            this.ucBotonera.btnAccion5 = "Accion 5";
            this.ucBotonera.btnAccion6 = "Accion 6";
            this.ucBotonera.btnAccion7 = "Accion 7";
            this.ucBotonera.ColorAlternativo = System.Drawing.Color.Empty;
            this.ucBotonera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBotonera.Location = new System.Drawing.Point(0, 0);
            this.ucBotonera.Name = "ucBotonera";
            this.ucBotonera.NumBotones = 0;
            this.ucBotonera.Size = new System.Drawing.Size(168, 425);
            this.ucBotonera.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitulo.Controls.Add(this.ucTitleBar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 25);
            this.pnlTitulo.TabIndex = 0;
            // 
            // ucTitleBar
            // 
            this.ucTitleBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTitleBar.ButtonsBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTitleBar.ButtonsForeColor = System.Drawing.Color.WhiteSmoke;
            this.ucTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTitleBar.Location = new System.Drawing.Point(0, 0);
            this.ucTitleBar.MinimumSize = new System.Drawing.Size(180, 25);
            this.ucTitleBar.Name = "ucTitleBar";
            this.ucTitleBar.Size = new System.Drawing.Size(800, 25);
            this.ucTitleBar.TabIndex = 1;
            this.ucTitleBar.TitleAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NuevoFormStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBG);
            this.DoubleBuffered = true;
            this.Name = "NuevoFormStyle";
            this.pnlBG.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNavBar;
        private ucLibrary.ucBotonera ucBotonera;
        private ucLibrary.ucTitleBar ucTitleBar;
    }
}