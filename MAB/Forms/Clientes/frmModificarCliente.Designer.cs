namespace MAB.Forms.CRUD.Clientes
{
    partial class frmModificarCliente
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
            this.cclblTelefono = new ccLibrary.ccLabel();
            this.cclblDireccion = new ccLibrary.ccLabel();
            this.cclblApellido = new ccLibrary.ccLabel();
            this.cclblNombre = new ccLibrary.ccLabel();
            this.cctbNombre = new ccLibrary.ccTextBox();
            this.cctbApellido = new ccLibrary.ccTextBox();
            this.cctbDireccion = new ccLibrary.ccTextBox();
            this.cclblNumTelefonos = new ccLibrary.ccLabel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 247);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(585, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // cclblTelefono
            // 
            this.cclblTelefono.AutoSize = true;
            this.cclblTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTelefono.Location = new System.Drawing.Point(119, 190);
            this.cclblTelefono.Name = "cclblTelefono";
            this.cclblTelefono.Size = new System.Drawing.Size(65, 16);
            this.cclblTelefono.TabIndex = 0;
            this.cclblTelefono.Text = "Telefonos";
            // 
            // cclblDireccion
            // 
            this.cclblDireccion.AutoSize = true;
            this.cclblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblDireccion.Location = new System.Drawing.Point(119, 141);
            this.cclblDireccion.Name = "cclblDireccion";
            this.cclblDireccion.Size = new System.Drawing.Size(62, 16);
            this.cclblDireccion.TabIndex = 0;
            this.cclblDireccion.Text = "Direccion";
            // 
            // cclblApellido
            // 
            this.cclblApellido.AutoSize = true;
            this.cclblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblApellido.Location = new System.Drawing.Point(119, 92);
            this.cclblApellido.Name = "cclblApellido";
            this.cclblApellido.Size = new System.Drawing.Size(56, 16);
            this.cclblApellido.TabIndex = 0;
            this.cclblApellido.Text = "Apellido";
            // 
            // cclblNombre
            // 
            this.cclblNombre.AutoSize = true;
            this.cclblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombre.Location = new System.Drawing.Point(119, 43);
            this.cclblNombre.Name = "cclblNombre";
            this.cclblNombre.Size = new System.Drawing.Size(57, 16);
            this.cclblNombre.TabIndex = 0;
            this.cclblNombre.Text = "Nombre";
            // 
            // cctbNombre
            // 
            this.cctbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbNombre.CaracterIncorrectErrorMessage = "";
            this.cctbNombre.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbNombre.Location = new System.Drawing.Point(235, 40);
            this.cctbNombre.Name = "cctbNombre";
            this.cctbNombre.Size = new System.Drawing.Size(231, 24);
            this.cctbNombre.TabIndex = 2;
            // 
            // cctbApellido
            // 
            this.cctbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbApellido.CaracterIncorrectErrorMessage = "";
            this.cctbApellido.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbApellido.Location = new System.Drawing.Point(235, 89);
            this.cctbApellido.Name = "cctbApellido";
            this.cctbApellido.Size = new System.Drawing.Size(231, 24);
            this.cctbApellido.TabIndex = 3;
            // 
            // cctbDireccion
            // 
            this.cctbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbDireccion.CaracterIncorrectErrorMessage = "";
            this.cctbDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbDireccion.Location = new System.Drawing.Point(235, 138);
            this.cctbDireccion.Name = "cctbDireccion";
            this.cctbDireccion.Size = new System.Drawing.Size(231, 24);
            this.cctbDireccion.TabIndex = 4;
            // 
            // cclblNumTelefonos
            // 
            this.cclblNumTelefonos.AutoSize = true;
            this.cclblNumTelefonos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNumTelefonos.Location = new System.Drawing.Point(232, 190);
            this.cclblNumTelefonos.Name = "cclblNumTelefonos";
            this.cclblNumTelefonos.Size = new System.Drawing.Size(15, 16);
            this.cclblNumTelefonos.TabIndex = 5;
            this.cclblNumTelefonos.Text = "0";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Location = new System.Drawing.Point(391, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnModificar);
            this.pnlBody.Controls.Add(this.cclblNombre);
            this.pnlBody.Controls.Add(this.cclblNumTelefonos);
            this.pnlBody.Controls.Add(this.cclblApellido);
            this.pnlBody.Controls.Add(this.cctbDireccion);
            this.pnlBody.Controls.Add(this.cclblDireccion);
            this.pnlBody.Controls.Add(this.cctbApellido);
            this.pnlBody.Controls.Add(this.cclblTelefono);
            this.pnlBody.Controls.Add(this.cctbNombre);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(585, 247);
            this.pnlBody.TabIndex = 7;
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 329);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblNombre;
        private ccLibrary.ccLabel cclblApellido;
        private ccLibrary.ccLabel cclblDireccion;
        private ccLibrary.ccLabel cclblTelefono;
        private ccLibrary.ccTextBox cctbNombre;
        private ccLibrary.ccTextBox cctbApellido;
        private ccLibrary.ccTextBox cctbDireccion;
        private ccLibrary.ccLabel cclblNumTelefonos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlBody;
    }
}