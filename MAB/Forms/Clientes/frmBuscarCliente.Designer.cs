namespace MAB.Forms.CRUD.Clientes
{
    partial class frmBuscarCliente
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
            this.ucTop = new ucLibrary.ucTop();
            this.ucBottom = new ucLibrary.ucBottom();
            this.cclblNombre = new ccLibrary.ccLabel();
            this.cclblApellido = new ccLibrary.ccLabel();
            this.cclblDireccion = new ccLibrary.ccLabel();
            this.cctbNombre = new ccLibrary.ccTextBox();
            this.cctbApellido = new ccLibrary.ccTextBox();
            this.cctbDireccion = new ccLibrary.ccTextBox();
            this.SuspendLayout();
            // 
            // ucTop
            // 
            this.ucTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTop.Location = new System.Drawing.Point(0, 0);
            this.ucTop.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucTop.Name = "ucTop";
            this.ucTop.Size = new System.Drawing.Size(658, 82);
            this.ucTop.TabIndex = 0;
            this.ucTop.Titulo = null;
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 312);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(658, 82);
            this.ucBottom.TabIndex = 1;
            // 
            // cclblNombre
            // 
            this.cclblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombre.AutoSize = true;
            this.cclblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombre.Location = new System.Drawing.Point(156, 134);
            this.cclblNombre.Name = "cclblNombre";
            this.cclblNombre.Size = new System.Drawing.Size(57, 16);
            this.cclblNombre.TabIndex = 2;
            this.cclblNombre.Text = "Nombre";
            // 
            // cclblApellido
            // 
            this.cclblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblApellido.AutoSize = true;
            this.cclblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblApellido.Location = new System.Drawing.Point(156, 189);
            this.cclblApellido.Name = "cclblApellido";
            this.cclblApellido.Size = new System.Drawing.Size(56, 16);
            this.cclblApellido.TabIndex = 3;
            this.cclblApellido.Text = "Apellido";
            // 
            // cclblDireccion
            // 
            this.cclblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblDireccion.AutoSize = true;
            this.cclblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblDireccion.Location = new System.Drawing.Point(156, 244);
            this.cclblDireccion.Name = "cclblDireccion";
            this.cclblDireccion.Size = new System.Drawing.Size(62, 16);
            this.cclblDireccion.TabIndex = 4;
            this.cclblDireccion.Text = "Direccion";
            // 
            // cctbNombre
            // 
            this.cctbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbNombre.Location = new System.Drawing.Point(272, 131);
            this.cctbNombre.Name = "cctbNombre";
            this.cctbNombre.Size = new System.Drawing.Size(231, 24);
            this.cctbNombre.TabIndex = 5;
            // 
            // cctbApellido
            // 
            this.cctbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbApellido.Location = new System.Drawing.Point(272, 186);
            this.cctbApellido.Name = "cctbApellido";
            this.cctbApellido.Size = new System.Drawing.Size(231, 24);
            this.cctbApellido.TabIndex = 6;
            // 
            // cctbDireccion
            // 
            this.cctbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbDireccion.Location = new System.Drawing.Point(272, 241);
            this.cctbDireccion.Name = "cctbDireccion";
            this.cctbDireccion.Size = new System.Drawing.Size(231, 24);
            this.cctbDireccion.TabIndex = 7;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 394);
            this.Controls.Add(this.cctbDireccion);
            this.Controls.Add(this.cctbApellido);
            this.Controls.Add(this.cctbNombre);
            this.Controls.Add(this.cclblDireccion);
            this.Controls.Add(this.cclblApellido);
            this.Controls.Add(this.cclblNombre);
            this.Controls.Add(this.ucBottom);
            this.Controls.Add(this.ucTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucLibrary.ucTop ucTop;
        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblNombre;
        private ccLibrary.ccLabel cclblApellido;
        private ccLibrary.ccLabel cclblDireccion;
        private ccLibrary.ccTextBox cctbNombre;
        private ccLibrary.ccTextBox cctbApellido;
        private ccLibrary.ccTextBox cctbDireccion;
    }
}