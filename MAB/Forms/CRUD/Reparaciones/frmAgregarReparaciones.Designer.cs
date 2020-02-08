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
            this.ucTop = new ucLibrary.ucTop();
            this.cclblCliente = new ccLibrary.ccLabel();
            this.cclblLavarropas = new ccLibrary.ccLabel();
            this.cclblErrorAReparar = new ccLibrary.ccLabel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.cctbErrorAReparar = new ccLibrary.ccTextBox();
            this.cboLavarropas = new System.Windows.Forms.ComboBox();
            this.cclblNombreCliente = new ccLibrary.ccLabel();
            this.btnNuevoLavarropas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 300);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(689, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // ucTop
            // 
            this.ucTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTop.Location = new System.Drawing.Point(0, 0);
            this.ucTop.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucTop.Name = "ucTop";
            this.ucTop.Size = new System.Drawing.Size(689, 82);
            this.ucTop.TabIndex = 1;
            this.ucTop.Titulo = null;
            // 
            // cclblCliente
            // 
            this.cclblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblCliente.AutoSize = true;
            this.cclblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente.Location = new System.Drawing.Point(171, 132);
            this.cclblCliente.Name = "cclblCliente";
            this.cclblCliente.Size = new System.Drawing.Size(47, 16);
            this.cclblCliente.TabIndex = 2;
            this.cclblCliente.Text = "Cliente";
            // 
            // cclblLavarropas
            // 
            this.cclblLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblLavarropas.AutoSize = true;
            this.cclblLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblLavarropas.Location = new System.Drawing.Point(171, 183);
            this.cclblLavarropas.Name = "cclblLavarropas";
            this.cclblLavarropas.Size = new System.Drawing.Size(73, 16);
            this.cclblLavarropas.TabIndex = 3;
            this.cclblLavarropas.Text = "Lavarropas";
            // 
            // cclblErrorAReparar
            // 
            this.cclblErrorAReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblErrorAReparar.AutoSize = true;
            this.cclblErrorAReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblErrorAReparar.Location = new System.Drawing.Point(171, 234);
            this.cclblErrorAReparar.Name = "cclblErrorAReparar";
            this.cclblErrorAReparar.Size = new System.Drawing.Size(101, 16);
            this.cclblErrorAReparar.TabIndex = 4;
            this.cclblErrorAReparar.Text = "Error A Reparar";
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCliente.Location = new System.Drawing.Point(287, 128);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(109, 23);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Buscar o Agregar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cctbErrorAReparar
            // 
            this.cctbErrorAReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbErrorAReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbErrorAReparar.Location = new System.Drawing.Point(287, 231);
            this.cctbErrorAReparar.Name = "cctbErrorAReparar";
            this.cctbErrorAReparar.Size = new System.Drawing.Size(231, 24);
            this.cctbErrorAReparar.TabIndex = 6;
            // 
            // cboLavarropas
            // 
            this.cboLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLavarropas.FormattingEnabled = true;
            this.cboLavarropas.Location = new System.Drawing.Point(287, 181);
            this.cboLavarropas.Name = "cboLavarropas";
            this.cboLavarropas.Size = new System.Drawing.Size(150, 21);
            this.cboLavarropas.TabIndex = 7;
            this.cboLavarropas.SelectedIndexChanged += new System.EventHandler(this.cboLavarropas_SelectedIndexChanged);
            // 
            // cclblNombreCliente
            // 
            this.cclblNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblNombreCliente.AutoSize = true;
            this.cclblNombreCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblNombreCliente.Location = new System.Drawing.Point(402, 132);
            this.cclblNombreCliente.Name = "cclblNombreCliente";
            this.cclblNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.cclblNombreCliente.TabIndex = 8;
            // 
            // btnNuevoLavarropas
            // 
            this.btnNuevoLavarropas.Location = new System.Drawing.Point(443, 179);
            this.btnNuevoLavarropas.Name = "btnNuevoLavarropas";
            this.btnNuevoLavarropas.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoLavarropas.TabIndex = 9;
            this.btnNuevoLavarropas.Text = "Nuevo";
            this.btnNuevoLavarropas.UseVisualStyleBackColor = true;
            this.btnNuevoLavarropas.Click += new System.EventHandler(this.btnNuevoLavarropas_Click);
            // 
            // frmAgregarReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 382);
            this.Controls.Add(this.btnNuevoLavarropas);
            this.Controls.Add(this.cclblNombreCliente);
            this.Controls.Add(this.cboLavarropas);
            this.Controls.Add(this.cctbErrorAReparar);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.cclblErrorAReparar);
            this.Controls.Add(this.cclblLavarropas);
            this.Controls.Add(this.cclblCliente);
            this.Controls.Add(this.ucTop);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarReparaciones";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarReparaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ucLibrary.ucTop ucTop;
        private ccLibrary.ccLabel cclblCliente;
        private ccLibrary.ccLabel cclblLavarropas;
        private ccLibrary.ccLabel cclblErrorAReparar;
        private System.Windows.Forms.Button btnCliente;
        private ccLibrary.ccTextBox cctbErrorAReparar;
        private System.Windows.Forms.ComboBox cboLavarropas;
        private ccLibrary.ccLabel cclblNombreCliente;
        private System.Windows.Forms.Button btnNuevoLavarropas;
    }
}