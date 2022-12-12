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
            this.components = new System.ComponentModel.Container();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.cmsClickDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiMinimizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiMaximizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cclblTituloVentana = new ccLibrary.ccLabel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.iconBtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.iconBtnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconBtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.pnlBG.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.cmsClickDerecho.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.BackColor = System.Drawing.Color.Transparent;
            this.pnlBG.Controls.Add(this.pnlTitle);
            this.pnlBG.Controls.Add(this.pnlBotones);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(823, 25);
            this.pnlBG.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.ContextMenuStrip = this.cmsClickDerecho;
            this.pnlTitle.Controls.Add(this.cclblTituloVentana);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(733, 25);
            this.pnlTitle.TabIndex = 5;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            // 
            // cmsClickDerecho
            // 
            this.cmsClickDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiRestaurar,
            this.cmsiMinimizar,
            this.cmsiMaximizar,
            this.toolStripSeparator1,
            this.cmsiCerrar});
            this.cmsClickDerecho.Name = "cmsClickDerecho";
            this.cmsClickDerecho.Size = new System.Drawing.Size(181, 120);
            // 
            // cmsiRestaurar
            // 
            this.cmsiRestaurar.Enabled = false;
            this.cmsiRestaurar.Name = "cmsiRestaurar";
            this.cmsiRestaurar.Size = new System.Drawing.Size(180, 22);
            this.cmsiRestaurar.Text = "Restaurar";
            this.cmsiRestaurar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // cmsiMinimizar
            // 
            this.cmsiMinimizar.Name = "cmsiMinimizar";
            this.cmsiMinimizar.Size = new System.Drawing.Size(180, 22);
            this.cmsiMinimizar.Text = "Minimizar";
            this.cmsiMinimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // cmsiMaximizar
            // 
            this.cmsiMaximizar.Name = "cmsiMaximizar";
            this.cmsiMaximizar.Size = new System.Drawing.Size(180, 22);
            this.cmsiMaximizar.Text = "Maximizar";
            this.cmsiMaximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmsiCerrar
            // 
            this.cmsiCerrar.Name = "cmsiCerrar";
            this.cmsiCerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cmsiCerrar.Size = new System.Drawing.Size(180, 22);
            this.cmsiCerrar.Text = "Cerrar";
            this.cmsiCerrar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cmsiCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // cclblTituloVentana
            // 
            this.cclblTituloVentana.AutoSize = true;
            this.cclblTituloVentana.ContextMenuStrip = this.cmsClickDerecho;
            this.cclblTituloVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cclblTituloVentana.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTituloVentana.Location = new System.Drawing.Point(0, 0);
            this.cclblTituloVentana.Name = "cclblTituloVentana";
            this.cclblTituloVentana.Size = new System.Drawing.Size(83, 16);
            this.cclblTituloVentana.TabIndex = 0;
            this.cclblTituloVentana.Text = "Window Title";
            this.cclblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cclblTituloVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.iconBtnMaximizar);
            this.pnlBotones.Controls.Add(this.iconBtnCerrar);
            this.pnlBotones.Controls.Add(this.iconBtnMinimizar);
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
            this.iconBtnMaximizar.ContextMenuStrip = this.cmsClickDerecho;
            this.iconBtnMaximizar.FlatAppearance.BorderSize = 0;
            this.iconBtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnMaximizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnMaximizar.IconSize = 20;
            this.iconBtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMaximizar.Location = new System.Drawing.Point(30, 0);
            this.iconBtnMaximizar.Name = "iconBtnMaximizar";
            this.iconBtnMaximizar.Rotation = 0D;
            this.iconBtnMaximizar.Size = new System.Drawing.Size(30, 25);
            this.iconBtnMaximizar.TabIndex = 2;
            this.iconBtnMaximizar.UseVisualStyleBackColor = false;
            this.iconBtnMaximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // iconBtnCerrar
            // 
            this.iconBtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnCerrar.ContextMenuStrip = this.cmsClickDerecho;
            this.iconBtnCerrar.FlatAppearance.BorderSize = 0;
            this.iconBtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnCerrar.IconSize = 20;
            this.iconBtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnCerrar.Location = new System.Drawing.Point(60, 0);
            this.iconBtnCerrar.Name = "iconBtnCerrar";
            this.iconBtnCerrar.Rotation = 0D;
            this.iconBtnCerrar.Size = new System.Drawing.Size(30, 25);
            this.iconBtnCerrar.TabIndex = 3;
            this.iconBtnCerrar.UseVisualStyleBackColor = false;
            this.iconBtnCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // iconBtnMinimizar
            // 
            this.iconBtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnMinimizar.ContextMenuStrip = this.cmsClickDerecho;
            this.iconBtnMinimizar.FlatAppearance.BorderSize = 0;
            this.iconBtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBtnMinimizar.IconSize = 20;
            this.iconBtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnMinimizar.Location = new System.Drawing.Point(0, 0);
            this.iconBtnMinimizar.Name = "iconBtnMinimizar";
            this.iconBtnMinimizar.Rotation = 0D;
            this.iconBtnMinimizar.Size = new System.Drawing.Size(30, 25);
            this.iconBtnMinimizar.TabIndex = 1;
            this.iconBtnMinimizar.UseVisualStyleBackColor = false;
            this.iconBtnMinimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // ucTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBG);
            this.MinimumSize = new System.Drawing.Size(180, 25);
            this.Name = "ucTitleBar";
            this.Size = new System.Drawing.Size(823, 25);
            this.pnlBG.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.cmsClickDerecho.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private FontAwesome.Sharp.IconButton iconBtnCerrar;
        private FontAwesome.Sharp.IconButton iconBtnMaximizar;
        private FontAwesome.Sharp.IconButton iconBtnMinimizar;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlBotones;
        private ccLibrary.ccLabel cclblTituloVentana;
        private System.Windows.Forms.ContextMenuStrip cmsClickDerecho;
        private System.Windows.Forms.ToolStripMenuItem cmsiRestaurar;
        private System.Windows.Forms.ToolStripMenuItem cmsiMinimizar;
        private System.Windows.Forms.ToolStripMenuItem cmsiMaximizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsiCerrar;
    }
}
