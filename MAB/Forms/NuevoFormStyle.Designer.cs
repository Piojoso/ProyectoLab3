namespace MAB.Forms
{
    partial class NuevoFormStyle
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
            this.iconBtnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconBtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.iconBtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.cclblTituloVentana = new ccLibrary.ccLabel();
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
            this.pnlTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlTitulo.Controls.Add(this.iconBtnCerrar);
            this.pnlTitulo.Controls.Add(this.iconBtnMaximizar);
            this.pnlTitulo.Controls.Add(this.iconBtnMinimizar);
            this.pnlTitulo.Controls.Add(this.cclblTituloVentana);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 25);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // iconBtnCerrar
            // 
            this.iconBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCerrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnCerrar.FlatAppearance.BorderSize = 0;
            this.iconBtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnCerrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnCerrar.IconSize = 16;
            this.iconBtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnCerrar.Location = new System.Drawing.Point(772, 0);
            this.iconBtnCerrar.Name = "iconBtnCerrar";
            this.iconBtnCerrar.Rotation = 0D;
            this.iconBtnCerrar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnCerrar.TabIndex = 3;
            this.iconBtnCerrar.UseVisualStyleBackColor = false;
            this.iconBtnCerrar.Click += new System.EventHandler(this.iconBtnCerrar_Click);
            // 
            // iconBtnMaximizar
            // 
            this.iconBtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMaximizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnMaximizar.FlatAppearance.BorderSize = 0;
            this.iconBtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnMaximizar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnMaximizar.IconSize = 16;
            this.iconBtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMaximizar.Location = new System.Drawing.Point(744, 0);
            this.iconBtnMaximizar.Name = "iconBtnMaximizar";
            this.iconBtnMaximizar.Rotation = 0D;
            this.iconBtnMaximizar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnMaximizar.TabIndex = 2;
            this.iconBtnMaximizar.UseVisualStyleBackColor = false;
            this.iconBtnMaximizar.Click += new System.EventHandler(this.iconBtnMaximizar_Click);
            // 
            // iconBtnMinimizar
            // 
            this.iconBtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMinimizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnMinimizar.FlatAppearance.BorderSize = 0;
            this.iconBtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnMinimizar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnMinimizar.IconSize = 16;
            this.iconBtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMinimizar.Location = new System.Drawing.Point(716, 0);
            this.iconBtnMinimizar.Name = "iconBtnMinimizar";
            this.iconBtnMinimizar.Rotation = 0D;
            this.iconBtnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnMinimizar.TabIndex = 1;
            this.iconBtnMinimizar.UseVisualStyleBackColor = false;
            this.iconBtnMinimizar.Click += new System.EventHandler(this.iconBtnMinimizar_Click);
            // 
            // cclblTituloVentana
            // 
            this.cclblTituloVentana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cclblTituloVentana.AutoSize = true;
            this.cclblTituloVentana.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTituloVentana.Location = new System.Drawing.Point(3, 5);
            this.cclblTituloVentana.Name = "cclblTituloVentana";
            this.cclblTituloVentana.Size = new System.Drawing.Size(35, 16);
            this.cclblTituloVentana.TabIndex = 0;
            this.cclblTituloVentana.Text = "MAB";
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
            this.Text = "NuevoFormStyle";
            this.pnlBG.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNavBar;
        private ccLibrary.ccLabel cclblTituloVentana;
        private ucLibrary.ucBotonera ucBotonera;
        private FontAwesome.Sharp.IconButton iconBtnCerrar;
        private FontAwesome.Sharp.IconButton iconBtnMaximizar;
        private FontAwesome.Sharp.IconButton iconBtnMinimizar;
    }
}