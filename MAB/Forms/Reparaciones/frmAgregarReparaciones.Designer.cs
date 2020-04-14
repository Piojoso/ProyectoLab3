using MAB.UC;

namespace MAB.Forms.CRUD.Reparaciones
{
    partial class frmAgregarReparaciones
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
            this.cclblCliente = new ccLibrary.ccLabel();
            this.cclblLavarropas = new ccLibrary.ccLabel();
            this.cclblErrorAReparar = new ccLibrary.ccLabel();
            this.cctbErrorAReparar = new ccLibrary.ccTextBox();
            this.cclblNombreCliente = new ccLibrary.ccLabel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cclblFechaIngreso = new ccLibrary.ccLabel();
            this.cclblMarcaLavarropas = new ccLibrary.ccLabel();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 222);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(657, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(141, 30);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(50, 16);
            this.cclblCliente.TabIndex = 2;
            this.cclblCliente.Text = "Cliente:";
            // 
            // cclblLavarropas
            // 
            this.cclblLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblLavarropas.AutoSize = true;
            this.cclblLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblLavarropas.Location = new System.Drawing.Point(141, 79);
            this.cclblLavarropas.Name = "cclblLavarropas";
            this.cclblLavarropas.Size = new System.Drawing.Size(76, 16);
            this.cclblLavarropas.TabIndex = 3;
            this.cclblLavarropas.Text = "Lavarropas:";
            // 
            // cclblErrorAReparar
            // 
            this.cclblErrorAReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblErrorAReparar.AutoSize = true;
            this.cclblErrorAReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblErrorAReparar.Location = new System.Drawing.Point(141, 128);
            this.cclblErrorAReparar.Name = "cclblErrorAReparar";
            this.cclblErrorAReparar.Size = new System.Drawing.Size(104, 16);
            this.cclblErrorAReparar.TabIndex = 4;
            this.cclblErrorAReparar.Text = "Error A Reparar:";
            // 
            // cctbErrorAReparar
            // 
            this.cctbErrorAReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbErrorAReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbErrorAReparar.Location = new System.Drawing.Point(278, 125);
            this.cctbErrorAReparar.Name = "cctbErrorAReparar";
            this.cctbErrorAReparar.Size = new System.Drawing.Size(231, 24);
            this.cctbErrorAReparar.TabIndex = 6;
            // 
            // cclblNombreCliente
            // 
            this.cclblNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombreCliente.AutoSize = true;
            this.cclblNombreCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombreCliente.Location = new System.Drawing.Point(284, 30);
            this.cclblNombreCliente.Name = "cclblNombreCliente";
            this.cclblNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.cclblNombreCliente.TabIndex = 8;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dtpFechaIngreso);
            this.pnlBody.Controls.Add(this.cclblMarcaLavarropas);
            this.pnlBody.Controls.Add(this.cclblFechaIngreso);
            this.pnlBody.Controls.Add(this.cctbErrorAReparar);
            this.pnlBody.Controls.Add(this.cclblCliente);
            this.pnlBody.Controls.Add(this.cclblNombreCliente);
            this.pnlBody.Controls.Add(this.cclblLavarropas);
            this.pnlBody.Controls.Add(this.cclblErrorAReparar);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(657, 222);
            this.pnlBody.TabIndex = 10;
            // 
            // cclblFechaIngreso
            // 
            this.cclblFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaIngreso.AutoSize = true;
            this.cclblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaIngreso.Location = new System.Drawing.Point(141, 177);
            this.cclblFechaIngreso.Name = "cclblFechaIngreso";
            this.cclblFechaIngreso.Size = new System.Drawing.Size(111, 16);
            this.cclblFechaIngreso.TabIndex = 9;
            this.cclblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // cclblMarcaLavarropas
            // 
            this.cclblMarcaLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMarcaLavarropas.AutoSize = true;
            this.cclblMarcaLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarcaLavarropas.Location = new System.Drawing.Point(284, 79);
            this.cclblMarcaLavarropas.Name = "cclblMarcaLavarropas";
            this.cclblMarcaLavarropas.Size = new System.Drawing.Size(0, 16);
            this.cclblMarcaLavarropas.TabIndex = 10;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(278, 173);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(231, 20);
            this.dtpFechaIngreso.TabIndex = 11;
            // 
            // frmAgregarReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 304);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarReparaciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccLabel cclblLavarropas;
        private ccLibrary.ccLabel cclblErrorAReparar;
        private ccLibrary.ccTextBox cctbErrorAReparar;
        private ccLibrary.ccLabel cclblNombreCliente;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccLabel cclblMarcaLavarropas;
        private ccLibrary.ccLabel cclblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
    }
}