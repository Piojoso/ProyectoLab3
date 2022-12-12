namespace MAB.Forms.CRUD.Reparaciones
{
    partial class frmBuscarReparacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.dtpFinEgreso = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioEgreso = new System.Windows.Forms.DateTimePicker();
            this.cclblFechaEgreso = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.dtpFinIngreso = new System.Windows.Forms.DateTimePicker();
            this.cclblFechaIngreso = new ccLibrary.ccLabel();
            this.dtpInicioIngreso = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 134);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(643, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ccLabel2);
            this.panel1.Controls.Add(this.dtpFinEgreso);
            this.panel1.Controls.Add(this.ccLabel4);
            this.panel1.Controls.Add(this.cclblFechaEgreso);
            this.panel1.Controls.Add(this.ccLabel1);
            this.panel1.Controls.Add(this.dtpInicioIngreso);
            this.panel1.Controls.Add(this.ccLabel3);
            this.panel1.Controls.Add(this.cclblFechaIngreso);
            this.panel1.Controls.Add(this.dtpInicioEgreso);
            this.panel1.Controls.Add(this.dtpFinIngreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 134);
            this.panel1.TabIndex = 13;
            // 
            // ccLabel4
            // 
            this.ccLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(440, 87);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(41, 16);
            this.ccLabel4.TabIndex = 8;
            this.ccLabel4.Text = "Hasta";
            // 
            // ccLabel3
            // 
            this.ccLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(275, 87);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(45, 16);
            this.ccLabel3.TabIndex = 7;
            this.ccLabel3.Text = "Desde";
            // 
            // dtpFinEgreso
            // 
            this.dtpFinEgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFinEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinEgreso.Location = new System.Drawing.Point(487, 83);
            this.dtpFinEgreso.Name = "dtpFinEgreso";
            this.dtpFinEgreso.Size = new System.Drawing.Size(96, 20);
            this.dtpFinEgreso.TabIndex = 6;
            // 
            // dtpInicioEgreso
            // 
            this.dtpInicioEgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInicioEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioEgreso.Location = new System.Drawing.Point(329, 83);
            this.dtpInicioEgreso.Name = "dtpInicioEgreso";
            this.dtpInicioEgreso.Size = new System.Drawing.Size(105, 20);
            this.dtpInicioEgreso.TabIndex = 5;
            // 
            // cclblFechaEgreso
            // 
            this.cclblFechaEgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaEgreso.AutoSize = true;
            this.cclblFechaEgreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaEgreso.Location = new System.Drawing.Point(60, 87);
            this.cclblFechaEgreso.Name = "cclblFechaEgreso";
            this.cclblFechaEgreso.Size = new System.Drawing.Size(175, 16);
            this.cclblFechaEgreso.TabIndex = 3;
            this.cclblFechaEgreso.Text = "Buscar por Fecha de Egreso:";
            // 
            // ccLabel2
            // 
            this.ccLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(440, 35);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(41, 16);
            this.ccLabel2.TabIndex = 6;
            this.ccLabel2.Text = "Hasta";
            // 
            // ccLabel1
            // 
            this.ccLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(275, 35);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(48, 16);
            this.ccLabel1.TabIndex = 5;
            this.ccLabel1.Text = "Desde:";
            // 
            // dtpFinIngreso
            // 
            this.dtpFinIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFinIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinIngreso.Location = new System.Drawing.Point(487, 31);
            this.dtpFinIngreso.Name = "dtpFinIngreso";
            this.dtpFinIngreso.Size = new System.Drawing.Size(96, 20);
            this.dtpFinIngreso.TabIndex = 4;
            // 
            // cclblFechaIngreso
            // 
            this.cclblFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaIngreso.AutoSize = true;
            this.cclblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaIngreso.Location = new System.Drawing.Point(60, 35);
            this.cclblFechaIngreso.Name = "cclblFechaIngreso";
            this.cclblFechaIngreso.Size = new System.Drawing.Size(178, 16);
            this.cclblFechaIngreso.TabIndex = 2;
            this.cclblFechaIngreso.Text = "Buscar por Fecha de Ingreso:";
            // 
            // dtpInicioIngreso
            // 
            this.dtpInicioIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInicioIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioIngreso.Location = new System.Drawing.Point(329, 31);
            this.dtpInicioIngreso.Name = "dtpInicioIngreso";
            this.dtpInicioIngreso.Size = new System.Drawing.Size(105, 20);
            this.dtpInicioIngreso.TabIndex = 3;
            // 
            // frmBuscarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 216);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Reparacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel panel1;
        private ccLibrary.ccLabel ccLabel2;
        private System.Windows.Forms.DateTimePicker dtpFinEgreso;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel cclblFechaEgreso;
        private ccLibrary.ccLabel ccLabel1;
        private System.Windows.Forms.DateTimePicker dtpInicioIngreso;
        private ccLibrary.ccLabel ccLabel3;
        private ccLibrary.ccLabel cclblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpInicioEgreso;
        private System.Windows.Forms.DateTimePicker dtpFinIngreso;
    }
}