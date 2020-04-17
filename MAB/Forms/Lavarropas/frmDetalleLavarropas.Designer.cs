namespace MAB.Forms.Lavarropas
{
    partial class frmDetalleLavarropas
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
            this.btnVerReparaciones = new System.Windows.Forms.Button();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.cclblEstadoGeneral = new ccLibrary.ccLabel();
            this.cclblModeloLavarropas = new ccLibrary.ccLabel();
            this.cclblMarcaLavarropas = new ccLibrary.ccLabel();
            this.cclblIdLavarropas = new ccLibrary.ccLabel();
            this.ccLabel6 = new ccLibrary.ccLabel();
            this.ccLabel5 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel1 = new ccLibrary.ccLabel();
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
            this.ucBottom.Size = new System.Drawing.Size(576, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnVerReparaciones);
            this.pnlBody.Controls.Add(this.btnVerCliente);
            this.pnlBody.Controls.Add(this.cclblEstadoGeneral);
            this.pnlBody.Controls.Add(this.cclblModeloLavarropas);
            this.pnlBody.Controls.Add(this.cclblMarcaLavarropas);
            this.pnlBody.Controls.Add(this.cclblIdLavarropas);
            this.pnlBody.Controls.Add(this.ccLabel6);
            this.pnlBody.Controls.Add(this.ccLabel5);
            this.pnlBody.Controls.Add(this.ccLabel4);
            this.pnlBody.Controls.Add(this.ccLabel3);
            this.pnlBody.Controls.Add(this.ccLabel2);
            this.pnlBody.Controls.Add(this.ccLabel1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(576, 311);
            this.pnlBody.TabIndex = 1;
            // 
            // btnVerReparaciones
            // 
            this.btnVerReparaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerReparaciones.Location = new System.Drawing.Point(360, 243);
            this.btnVerReparaciones.Name = "btnVerReparaciones";
            this.btnVerReparaciones.Size = new System.Drawing.Size(75, 23);
            this.btnVerReparaciones.TabIndex = 11;
            this.btnVerReparaciones.Text = "Ver Todas";
            this.btnVerReparaciones.UseVisualStyleBackColor = true;
            this.btnVerReparaciones.Click += new System.EventHandler(this.btnVerReparaciones_Click);
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerCliente.Location = new System.Drawing.Point(360, 203);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(75, 23);
            this.btnVerCliente.TabIndex = 10;
            this.btnVerCliente.Text = "Ver Cliente";
            this.btnVerCliente.UseVisualStyleBackColor = true;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // cclblEstadoGeneral
            // 
            this.cclblEstadoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblEstadoGeneral.AutoSize = true;
            this.cclblEstadoGeneral.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstadoGeneral.Location = new System.Drawing.Point(360, 167);
            this.cclblEstadoGeneral.Name = "cclblEstadoGeneral";
            this.cclblEstadoGeneral.Size = new System.Drawing.Size(0, 16);
            this.cclblEstadoGeneral.TabIndex = 9;
            // 
            // cclblModeloLavarropas
            // 
            this.cclblModeloLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblModeloLavarropas.AutoSize = true;
            this.cclblModeloLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblModeloLavarropas.Location = new System.Drawing.Point(360, 127);
            this.cclblModeloLavarropas.Name = "cclblModeloLavarropas";
            this.cclblModeloLavarropas.Size = new System.Drawing.Size(0, 16);
            this.cclblModeloLavarropas.TabIndex = 8;
            // 
            // cclblMarcaLavarropas
            // 
            this.cclblMarcaLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMarcaLavarropas.AutoSize = true;
            this.cclblMarcaLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarcaLavarropas.Location = new System.Drawing.Point(360, 87);
            this.cclblMarcaLavarropas.Name = "cclblMarcaLavarropas";
            this.cclblMarcaLavarropas.Size = new System.Drawing.Size(0, 16);
            this.cclblMarcaLavarropas.TabIndex = 7;
            // 
            // cclblIdLavarropas
            // 
            this.cclblIdLavarropas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblIdLavarropas.AutoSize = true;
            this.cclblIdLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblIdLavarropas.Location = new System.Drawing.Point(360, 47);
            this.cclblIdLavarropas.Name = "cclblIdLavarropas";
            this.cclblIdLavarropas.Size = new System.Drawing.Size(0, 16);
            this.cclblIdLavarropas.TabIndex = 6;
            // 
            // ccLabel6
            // 
            this.ccLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel6.AutoSize = true;
            this.ccLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel6.Location = new System.Drawing.Point(141, 247);
            this.ccLabel6.Name = "ccLabel6";
            this.ccLabel6.Size = new System.Drawing.Size(90, 16);
            this.ccLabel6.TabIndex = 5;
            this.ccLabel6.Text = "Reparaciones:";
            // 
            // ccLabel5
            // 
            this.ccLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel5.AutoSize = true;
            this.ccLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel5.Location = new System.Drawing.Point(141, 207);
            this.ccLabel5.Name = "ccLabel5";
            this.ccLabel5.Size = new System.Drawing.Size(50, 16);
            this.ccLabel5.TabIndex = 4;
            this.ccLabel5.Text = "Cliente:";
            // 
            // ccLabel4
            // 
            this.ccLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(141, 167);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(100, 16);
            this.ccLabel4.TabIndex = 3;
            this.ccLabel4.Text = "Estado General:";
            // 
            // ccLabel3
            // 
            this.ccLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(141, 127);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(57, 16);
            this.ccLabel3.TabIndex = 2;
            this.ccLabel3.Text = "Modelo:";
            // 
            // ccLabel2
            // 
            this.ccLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(141, 87);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(48, 16);
            this.ccLabel2.TabIndex = 1;
            this.ccLabel2.Text = "Marca:";
            // 
            // ccLabel1
            // 
            this.ccLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(141, 47);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(22, 16);
            this.ccLabel1.TabIndex = 0;
            this.ccLabel1.Text = "Id:";
            // 
            // frmDetalleLavarropas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 393);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleLavarropas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnVerReparaciones;
        private System.Windows.Forms.Button btnVerCliente;
        private ccLibrary.ccLabel cclblEstadoGeneral;
        private ccLibrary.ccLabel cclblModeloLavarropas;
        private ccLibrary.ccLabel cclblMarcaLavarropas;
        private ccLibrary.ccLabel cclblIdLavarropas;
        private ccLibrary.ccLabel ccLabel6;
        private ccLibrary.ccLabel ccLabel5;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel3;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel1;
    }
}