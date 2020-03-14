namespace ucLibrary
{
    partial class ucTitleBar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBG = new System.Windows.Forms.Panel();
            this.iconBtnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconBtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.iconBtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.cclblTituloVentana = new ccLibrary.ccLabel();
            this.pnlBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlBG.Controls.Add(this.iconBtnCerrar);
            this.pnlBG.Controls.Add(this.iconBtnMaximizar);
            this.pnlBG.Controls.Add(this.iconBtnMinimizar);
            this.pnlBG.Controls.Add(this.cclblTituloVentana);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(823, 25);
            this.pnlBG.TabIndex = 1;
            // 
            // iconBtnCerrar
            // 
            this.iconBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCerrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnCerrar.FlatAppearance.BorderSize = 0;
            this.iconBtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnCerrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnCerrar.IconSize = 20;
            this.iconBtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnCerrar.Location = new System.Drawing.Point(795, 0);
            this.iconBtnCerrar.Name = "iconBtnCerrar";
            this.iconBtnCerrar.Rotation = 0D;
            this.iconBtnCerrar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnCerrar.TabIndex = 3;
            this.iconBtnCerrar.UseVisualStyleBackColor = false;
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
            this.iconBtnMaximizar.IconSize = 20;
            this.iconBtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMaximizar.Location = new System.Drawing.Point(767, 0);
            this.iconBtnMaximizar.Name = "iconBtnMaximizar";
            this.iconBtnMaximizar.Rotation = 0D;
            this.iconBtnMaximizar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnMaximizar.TabIndex = 2;
            this.iconBtnMaximizar.UseVisualStyleBackColor = false;
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
            this.iconBtnMinimizar.IconSize = 20;
            this.iconBtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMinimizar.Location = new System.Drawing.Point(739, 0);
            this.iconBtnMinimizar.Name = "iconBtnMinimizar";
            this.iconBtnMinimizar.Rotation = 0D;
            this.iconBtnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnMinimizar.TabIndex = 1;
            this.iconBtnMinimizar.UseVisualStyleBackColor = false;
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
            // ucTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBG);
            this.Name = "ucTitleBar";
            this.Size = new System.Drawing.Size(823, 25);
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private FontAwesome.Sharp.IconButton iconBtnCerrar;
        private FontAwesome.Sharp.IconButton iconBtnMaximizar;
        private FontAwesome.Sharp.IconButton iconBtnMinimizar;
        private ccLibrary.ccLabel cclblTituloVentana;
    }
}
