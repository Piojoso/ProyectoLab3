using ucLibrary;

namespace MAB.Forms.CRUD.Clientes
{
    partial class frmAgregarCliente
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cctbDireccion = new ccLibrary.ccTextBox();
            this.ccLblApellido = new ccLibrary.ccLabel();
            this.cctbApellido = new ccLibrary.ccTextBox();
            this.cclblDireccion = new ccLibrary.ccLabel();
            this.cctbNombre = new ccLibrary.ccTextBox();
            this.cclblNombre = new ccLibrary.ccLabel();
            this.ucBottom = new ucLibrary.ucBottom();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.cctbDireccion);
            this.pnlBody.Controls.Add(this.ccLblApellido);
            this.pnlBody.Controls.Add(this.cctbApellido);
            this.pnlBody.Controls.Add(this.cclblDireccion);
            this.pnlBody.Controls.Add(this.cctbNombre);
            this.pnlBody.Controls.Add(this.cclblNombre);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(583, 199);
            this.pnlBody.TabIndex = 18;
            // 
            // cctbDireccion
            // 
            this.cctbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbDireccion.CaracterIncorrectErrorMessage = "";
            this.cctbDireccion.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbDireccion.Location = new System.Drawing.Point(246, 137);
            this.cctbDireccion.Name = "cctbDireccion";
            this.cctbDireccion.Size = new System.Drawing.Size(231, 24);
            this.cctbDireccion.TabIndex = 17;
            // 
            // ccLblApellido
            // 
            this.ccLblApellido.AutoSize = true;
            this.ccLblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLblApellido.Location = new System.Drawing.Point(130, 91);
            this.ccLblApellido.Name = "ccLblApellido";
            this.ccLblApellido.Size = new System.Drawing.Size(56, 16);
            this.ccLblApellido.TabIndex = 0;
            this.ccLblApellido.Text = "Apellido";
            // 
            // cctbApellido
            // 
            this.cctbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbApellido.CaracterIncorrectErrorMessage = "";
            this.cctbApellido.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbApellido.Location = new System.Drawing.Point(246, 88);
            this.cctbApellido.Name = "cctbApellido";
            this.cctbApellido.Size = new System.Drawing.Size(231, 24);
            this.cctbApellido.TabIndex = 16;
            // 
            // cclblDireccion
            // 
            this.cclblDireccion.AutoSize = true;
            this.cclblDireccion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblDireccion.Location = new System.Drawing.Point(130, 140);
            this.cclblDireccion.Name = "cclblDireccion";
            this.cclblDireccion.Size = new System.Drawing.Size(62, 16);
            this.cclblDireccion.TabIndex = 0;
            this.cclblDireccion.Text = "Direccion";
            // 
            // cctbNombre
            // 
            this.cctbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbNombre.CaracterIncorrectErrorMessage = "";
            this.cctbNombre.DataType = ccLibrary.ccTextBox.dataType.Alfabetico;
            this.cctbNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbNombre.Location = new System.Drawing.Point(246, 37);
            this.cctbNombre.Name = "cctbNombre";
            this.cctbNombre.Size = new System.Drawing.Size(231, 24);
            this.cctbNombre.TabIndex = 15;
            // 
            // cclblNombre
            // 
            this.cclblNombre.AutoSize = true;
            this.cclblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombre.Location = new System.Drawing.Point(130, 40);
            this.cclblNombre.Name = "cclblNombre";
            this.cclblNombre.Size = new System.Drawing.Size(57, 16);
            this.cclblNombre.TabIndex = 0;
            this.cclblNombre.Text = "Nombre";
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 199);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(583, 82);
            this.ucBottom.TabIndex = 14;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 281);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nuevo Cliente";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ucBottom ucBottom;
        private ccLibrary.ccLabel ccLblApellido;
        private ccLibrary.ccLabel cclblDireccion;
        private ccLibrary.ccLabel cclblNombre;
        private ccLibrary.ccTextBox cctbNombre;
        private ccLibrary.ccTextBox cctbApellido;
        private ccLibrary.ccTextBox cctbDireccion;
        private System.Windows.Forms.Panel pnlBody;
    }
}