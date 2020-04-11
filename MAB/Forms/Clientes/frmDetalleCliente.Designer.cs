namespace MAB.Forms.Clientes
{
    partial class frmDetalleCliente
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
            this.ucBottom = new ucLibrary.ucBottom();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cclblID = new ccLibrary.ccLabel();
            this.cclblShowNumId = new ccLibrary.ccLabel();
            this.cclblNombre = new ccLibrary.ccLabel();
            this.cclblShowNombre = new ccLibrary.ccLabel();
            this.cclblApellido = new ccLibrary.ccLabel();
            this.cclblShowApellido = new ccLibrary.ccLabel();
            this.cclblDireccion = new ccLibrary.ccLabel();
            this.cclblShowDireccion = new ccLibrary.ccLabel();
            this.cclblTelefono = new ccLibrary.ccLabel();
            this.cclblShowNumTelefonos = new ccLibrary.ccLabel();
            this.cclblLavarropas = new ccLibrary.ccLabel();
            this.cclblShowNumLavarropas = new ccLibrary.ccLabel();
            this.btnVerTelefonos = new System.Windows.Forms.Button();
            this.btnVerLavarropas = new System.Windows.Forms.Button();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 311);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(708, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnVerLavarropas);
            this.pnlBody.Controls.Add(this.btnVerTelefonos);
            this.pnlBody.Controls.Add(this.cclblShowNumLavarropas);
            this.pnlBody.Controls.Add(this.cclblLavarropas);
            this.pnlBody.Controls.Add(this.cclblShowNumTelefonos);
            this.pnlBody.Controls.Add(this.cclblTelefono);
            this.pnlBody.Controls.Add(this.cclblShowDireccion);
            this.pnlBody.Controls.Add(this.cclblDireccion);
            this.pnlBody.Controls.Add(this.cclblShowApellido);
            this.pnlBody.Controls.Add(this.cclblApellido);
            this.pnlBody.Controls.Add(this.cclblShowNombre);
            this.pnlBody.Controls.Add(this.cclblNombre);
            this.pnlBody.Controls.Add(this.cclblShowNumId);
            this.pnlBody.Controls.Add(this.cclblID);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(708, 311);
            this.pnlBody.TabIndex = 1;
            // 
            // cclblID
            // 
            this.cclblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblID.AutoSize = true;
            this.cclblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblID.Location = new System.Drawing.Point(172, 42);
            this.cclblID.Name = "cclblID";
            this.cclblID.Size = new System.Drawing.Size(22, 16);
            this.cclblID.TabIndex = 0;
            this.cclblID.Text = "Id:";
            // 
            // cclblShowNumId
            // 
            this.cclblShowNumId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblShowNumId.AutoSize = true;
            this.cclblShowNumId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblShowNumId.Location = new System.Drawing.Point(371, 42);
            this.cclblShowNumId.Name = "cclblShowNumId";
            this.cclblShowNumId.Size = new System.Drawing.Size(0, 16);
            this.cclblShowNumId.TabIndex = 1;
            // 
            // cclblNombre
            // 
            this.cclblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombre.AutoSize = true;
            this.cclblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombre.Location = new System.Drawing.Point(172, 84);
            this.cclblNombre.Name = "cclblNombre";
            this.cclblNombre.Size = new System.Drawing.Size(60, 16);
            this.cclblNombre.TabIndex = 2;
            this.cclblNombre.Text = "Nombre:";
            // 
            // cclblShowNombre
            // 
            this.cclblShowNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblShowNombre.AutoSize = true;
            this.cclblShowNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblShowNombre.Location = new System.Drawing.Point(371, 84);
            this.cclblShowNombre.Name = "cclblShowNombre";
            this.cclblShowNombre.Size = new System.Drawing.Size(0, 16);
            this.cclblShowNombre.TabIndex = 3;
            // 
            // cclblApellido
            // 
            this.cclblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblApellido.AutoSize = true;
            this.cclblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblApellido.Location = new System.Drawing.Point(172, 126);
            this.cclblApellido.Name = "cclblApellido";
            this.cclblApellido.Size = new System.Drawing.Size(59, 16);
            this.cclblApellido.TabIndex = 4;
            this.cclblApellido.Text = "Apellido:";
            // 
            // cclblShowApellido
            // 
            this.cclblShowApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblShowApellido.AutoSize = true;
            this.cclblShowApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblShowApellido.Location = new System.Drawing.Point(371, 126);
            this.cclblShowApellido.Name = "cclblShowApellido";
            this.cclblShowApellido.Size = new System.Drawing.Size(0, 16);
            this.cclblShowApellido.TabIndex = 5;
            // 
            // cclblDireccion
            // 
            this.cclblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblDireccion.AutoSize = true;
            this.cclblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblDireccion.Location = new System.Drawing.Point(172, 168);
            this.cclblDireccion.Name = "cclblDireccion";
            this.cclblDireccion.Size = new System.Drawing.Size(65, 16);
            this.cclblDireccion.TabIndex = 6;
            this.cclblDireccion.Text = "Direccion:";
            // 
            // cclblShowDireccion
            // 
            this.cclblShowDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblShowDireccion.AutoSize = true;
            this.cclblShowDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblShowDireccion.Location = new System.Drawing.Point(371, 168);
            this.cclblShowDireccion.Name = "cclblShowDireccion";
            this.cclblShowDireccion.Size = new System.Drawing.Size(0, 16);
            this.cclblShowDireccion.TabIndex = 7;
            // 
            // cclblTelefono
            // 
            this.cclblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTelefono.AutoSize = true;
            this.cclblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTelefono.Location = new System.Drawing.Point(172, 210);
            this.cclblTelefono.Name = "cclblTelefono";
            this.cclblTelefono.Size = new System.Drawing.Size(139, 16);
            this.cclblTelefono.TabIndex = 8;
            this.cclblTelefono.Text = "Numero de Telefonos:";
            // 
            // cclblShowNumTelefonos
            // 
            this.cclblShowNumTelefonos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblShowNumTelefonos.AutoSize = true;
            this.cclblShowNumTelefonos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblShowNumTelefonos.Location = new System.Drawing.Point(371, 210);
            this.cclblShowNumTelefonos.Name = "cclblShowNumTelefonos";
            this.cclblShowNumTelefonos.Size = new System.Drawing.Size(0, 16);
            this.cclblShowNumTelefonos.TabIndex = 9;
            // 
            // cclblLavarropas
            // 
            this.cclblLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblLavarropas.AutoSize = true;
            this.cclblLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblLavarropas.Location = new System.Drawing.Point(172, 252);
            this.cclblLavarropas.Name = "cclblLavarropas";
            this.cclblLavarropas.Size = new System.Drawing.Size(147, 16);
            this.cclblLavarropas.TabIndex = 10;
            this.cclblLavarropas.Text = "Numero de Lavarropas:";
            // 
            // cclblShowNumLavarropas
            // 
            this.cclblShowNumLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblShowNumLavarropas.AutoSize = true;
            this.cclblShowNumLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblShowNumLavarropas.Location = new System.Drawing.Point(371, 252);
            this.cclblShowNumLavarropas.Name = "cclblShowNumLavarropas";
            this.cclblShowNumLavarropas.Size = new System.Drawing.Size(0, 16);
            this.cclblShowNumLavarropas.TabIndex = 11;
            // 
            // btnVerTelefonos
            // 
            this.btnVerTelefonos.Location = new System.Drawing.Point(461, 206);
            this.btnVerTelefonos.Name = "btnVerTelefonos";
            this.btnVerTelefonos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTelefonos.TabIndex = 12;
            this.btnVerTelefonos.Text = "Ver Mas";
            this.btnVerTelefonos.UseVisualStyleBackColor = true;
            this.btnVerTelefonos.Click += new System.EventHandler(this.btnVerTelefonos_Click);
            // 
            // btnVerLavarropas
            // 
            this.btnVerLavarropas.Location = new System.Drawing.Point(461, 248);
            this.btnVerLavarropas.Name = "btnVerLavarropas";
            this.btnVerLavarropas.Size = new System.Drawing.Size(75, 23);
            this.btnVerLavarropas.TabIndex = 13;
            this.btnVerLavarropas.Text = "Ver Mas";
            this.btnVerLavarropas.UseVisualStyleBackColor = true;
            this.btnVerLavarropas.Click += new System.EventHandler(this.btnVerLavarropas_Click);
            // 
            // frmDetalleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 393);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnVerLavarropas;
        private System.Windows.Forms.Button btnVerTelefonos;
        private ccLibrary.ccLabel cclblShowNumLavarropas;
        private ccLibrary.ccLabel cclblLavarropas;
        private ccLibrary.ccLabel cclblShowNumTelefonos;
        private ccLibrary.ccLabel cclblTelefono;
        private ccLibrary.ccLabel cclblShowDireccion;
        private ccLibrary.ccLabel cclblDireccion;
        private ccLibrary.ccLabel cclblShowApellido;
        private ccLibrary.ccLabel cclblApellido;
        private ccLibrary.ccLabel cclblShowNombre;
        private ccLibrary.ccLabel cclblNombre;
        private ccLibrary.ccLabel cclblShowNumId;
        private ccLibrary.ccLabel cclblID;
    }
}