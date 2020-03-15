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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.iconBtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.iconBtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.iconBtnCerrar = new FontAwesome.Sharp.IconButton();
            this.cclblTituloVentana = new ccLibrary.ccLabel();
            this.pnlBG.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.BackColor = System.Drawing.Color.Transparent;
            this.pnlBG.Controls.Add(this.panel2);
            this.pnlBG.Controls.Add(this.pnlBotones);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(823, 25);
            this.pnlBG.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cclblTituloVentana);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 25);
            this.panel2.TabIndex = 5;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.iconBtnMaximizar);
            this.pnlBotones.Controls.Add(this.iconBtnMinimizar);
            this.pnlBotones.Controls.Add(this.iconBtnCerrar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotones.Location = new System.Drawing.Point(733, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(90, 25);
            this.pnlBotones.TabIndex = 4;
            // 
            // iconBtnMaximizar
            // 
            this.iconBtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnMaximizar.FlatAppearance.BorderSize = 0;
            this.iconBtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnMaximizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnMaximizar.IconSize = 20;
            this.iconBtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMaximizar.Location = new System.Drawing.Point(31, 0);
            this.iconBtnMaximizar.Name = "iconBtnMaximizar";
            this.iconBtnMaximizar.Rotation = 0D;
            this.iconBtnMaximizar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnMaximizar.TabIndex = 2;
            this.iconBtnMaximizar.UseVisualStyleBackColor = false;
            // 
            // iconBtnMinimizar
            // 
            this.iconBtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnMinimizar.FlatAppearance.BorderSize = 0;
            this.iconBtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnMinimizar.IconSize = 20;
            this.iconBtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMinimizar.Location = new System.Drawing.Point(3, 0);
            this.iconBtnMinimizar.Name = "iconBtnMinimizar";
            this.iconBtnMinimizar.Rotation = 0D;
            this.iconBtnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnMinimizar.TabIndex = 1;
            this.iconBtnMinimizar.UseVisualStyleBackColor = false;
            // 
            // iconBtnCerrar
            // 
            this.iconBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnCerrar.FlatAppearance.BorderSize = 0;
            this.iconBtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnCerrar.IconSize = 20;
            this.iconBtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnCerrar.Location = new System.Drawing.Point(59, 0);
            this.iconBtnCerrar.Name = "iconBtnCerrar";
            this.iconBtnCerrar.Rotation = 0D;
            this.iconBtnCerrar.Size = new System.Drawing.Size(28, 24);
            this.iconBtnCerrar.TabIndex = 3;
            this.iconBtnCerrar.UseVisualStyleBackColor = false;
            // 
            // cclblTituloVentana
            // 
            this.cclblTituloVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cclblTituloVentana.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTituloVentana.Location = new System.Drawing.Point(0, 0);
            this.cclblTituloVentana.Name = "cclblTituloVentana";
            this.cclblTituloVentana.Size = new System.Drawing.Size(733, 25);
            this.cclblTituloVentana.TabIndex = 0;
            this.cclblTituloVentana.Text = "Titulo";
            this.cclblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBG);
            this.Name = "ucTitleBar";
            this.Size = new System.Drawing.Size(823, 25);
            this.pnlBG.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private FontAwesome.Sharp.IconButton iconBtnCerrar;
        private FontAwesome.Sharp.IconButton iconBtnMaximizar;
        private FontAwesome.Sharp.IconButton iconBtnMinimizar;
        private ccLibrary.ccLabel cclblTituloVentana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBotones;
    }
}
