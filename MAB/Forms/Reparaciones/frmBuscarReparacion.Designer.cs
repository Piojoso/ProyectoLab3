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
            this.ucTop = new ucLibrary.ucTop();
            this.cclblFechaIngreso = new ccLibrary.ccLabel();
            this.cclblFechaEgreso = new ccLibrary.ccLabel();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpInicioIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFinIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioEgreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFinEgreso = new System.Windows.Forms.DateTimePicker();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.tlpBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 284);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(710, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // ucTop
            // 
            this.ucTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTop.Location = new System.Drawing.Point(0, 0);
            this.ucTop.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucTop.Name = "ucTop";
            this.ucTop.Size = new System.Drawing.Size(710, 82);
            this.ucTop.TabIndex = 1;
            this.ucTop.Titulo = null;
            // 
            // cclblFechaIngreso
            // 
            this.cclblFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaIngreso.AutoSize = true;
            this.cclblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaIngreso.Location = new System.Drawing.Point(120, 13);
            this.cclblFechaIngreso.Name = "cclblFechaIngreso";
            this.cclblFechaIngreso.Size = new System.Drawing.Size(108, 16);
            this.cclblFechaIngreso.TabIndex = 2;
            this.cclblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // cclblFechaEgreso
            // 
            this.cclblFechaEgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaEgreso.AutoSize = true;
            this.cclblFechaEgreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaEgreso.Location = new System.Drawing.Point(122, 13);
            this.cclblFechaEgreso.Name = "cclblFechaEgreso";
            this.cclblFechaEgreso.Size = new System.Drawing.Size(105, 16);
            this.cclblFechaEgreso.TabIndex = 3;
            this.cclblFechaEgreso.Text = "Fecha de Egreso";
            // 
            // tlpBody
            // 
            this.tlpBody.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBody.ColumnCount = 2;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.Controls.Add(this.panel1, 1, 0);
            this.tlpBody.Controls.Add(this.panel2, 0, 0);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(0, 82);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Size = new System.Drawing.Size(710, 202);
            this.tlpBody.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ccLabel4);
            this.panel1.Controls.Add(this.ccLabel3);
            this.panel1.Controls.Add(this.dtpFinEgreso);
            this.panel1.Controls.Add(this.dtpInicioEgreso);
            this.panel1.Controls.Add(this.cclblFechaEgreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(358, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 196);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccLabel2);
            this.panel2.Controls.Add(this.ccLabel1);
            this.panel2.Controls.Add(this.dtpFinIngreso);
            this.panel2.Controls.Add(this.cclblFechaIngreso);
            this.panel2.Controls.Add(this.dtpInicioIngreso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 196);
            this.panel2.TabIndex = 13;
            // 
            // dtpInicioIngreso
            // 
            this.dtpInicioIngreso.Location = new System.Drawing.Point(112, 66);
            this.dtpInicioIngreso.Name = "dtpInicioIngreso";
            this.dtpInicioIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioIngreso.TabIndex = 3;
            // 
            // dtpFinIngreso
            // 
            this.dtpFinIngreso.Location = new System.Drawing.Point(112, 120);
            this.dtpFinIngreso.Name = "dtpFinIngreso";
            this.dtpFinIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFinIngreso.TabIndex = 4;
            // 
            // dtpInicioEgreso
            // 
            this.dtpInicioEgreso.Location = new System.Drawing.Point(112, 66);
            this.dtpInicioEgreso.Name = "dtpInicioEgreso";
            this.dtpInicioEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioEgreso.TabIndex = 5;
            // 
            // dtpFinEgreso
            // 
            this.dtpFinEgreso.Location = new System.Drawing.Point(112, 120);
            this.dtpFinEgreso.Name = "dtpFinEgreso";
            this.dtpFinEgreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFinEgreso.TabIndex = 6;
            // 
            // ccLabel1
            // 
            this.ccLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(37, 70);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(38, 16);
            this.ccLabel1.TabIndex = 5;
            this.ccLabel1.Text = "Inicio";
            // 
            // ccLabel2
            // 
            this.ccLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(37, 124);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(24, 16);
            this.ccLabel2.TabIndex = 6;
            this.ccLabel2.Text = "Fin";
            // 
            // ccLabel3
            // 
            this.ccLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(37, 70);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(38, 16);
            this.ccLabel3.TabIndex = 7;
            this.ccLabel3.Text = "Inicio";
            // 
            // ccLabel4
            // 
            this.ccLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(37, 124);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(24, 16);
            this.ccLabel4.TabIndex = 8;
            this.ccLabel4.Text = "Fin";
            // 
            // frmBuscarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.tlpBody);
            this.Controls.Add(this.ucTop);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Reparacion";
            this.tlpBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ucLibrary.ucTop ucTop;
        private ccLibrary.ccLabel cclblFechaIngreso;
        private ccLibrary.ccLabel cclblFechaEgreso;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpInicioIngreso;
        private System.Windows.Forms.DateTimePicker dtpFinEgreso;
        private System.Windows.Forms.DateTimePicker dtpInicioEgreso;
        private System.Windows.Forms.DateTimePicker dtpFinIngreso;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel3;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel1;
    }
}