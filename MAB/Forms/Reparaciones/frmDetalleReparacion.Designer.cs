namespace MAB.Forms.Reparaciones
{
    partial class frmDetalleReparacion
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
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cclblTotal = new ccLibrary.ccLabel();
            this.cclblTotalRepuestos = new ccLibrary.ccLabel();
            this.cclblManoObra = new ccLibrary.ccLabel();
            this.cclblMesesGarantia = new ccLibrary.ccLabel();
            this.cclblReparacionRealizada = new ccLibrary.ccLabel();
            this.cclblEstadoReparacion = new ccLibrary.ccLabel();
            this.cclblErrorARepara = new ccLibrary.ccLabel();
            this.cclblFechaEgreso = new ccLibrary.ccLabel();
            this.cclblFechaIngreso = new ccLibrary.ccLabel();
            this.cclblId = new ccLibrary.ccLabel();
            this.btnVerLavarropa = new System.Windows.Forms.Button();
            this.btnVerEntregas = new System.Windows.Forms.Button();
            this.ccLabel11 = new ccLibrary.ccLabel();
            this.ccLabel10 = new ccLibrary.ccLabel();
            this.ccLabel9 = new ccLibrary.ccLabel();
            this.ccLabel8 = new ccLibrary.ccLabel();
            this.ccLabel7 = new ccLibrary.ccLabel();
            this.ccLabel6 = new ccLibrary.ccLabel();
            this.ccLabel5 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.ccLabel12 = new ccLibrary.ccLabel();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 310);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 2;
            this.ucBottom.Size = new System.Drawing.Size(747, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // ccLabel1
            // 
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(43, 35);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(22, 16);
            this.ccLabel1.TabIndex = 1;
            this.ccLabel1.Text = "Id:";
            // 
            // ccLabel2
            // 
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(218, 35);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(111, 16);
            this.ccLabel2.TabIndex = 2;
            this.ccLabel2.Text = "Fecha de Ingreso:";
            // 
            // ccLabel3
            // 
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(499, 35);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(108, 16);
            this.ccLabel3.TabIndex = 3;
            this.ccLabel3.Text = "Fecha de Egreso:";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.ccLabel12);
            this.pnlBody.Controls.Add(this.btnRepuestos);
            this.pnlBody.Controls.Add(this.cclblTotal);
            this.pnlBody.Controls.Add(this.cclblTotalRepuestos);
            this.pnlBody.Controls.Add(this.cclblManoObra);
            this.pnlBody.Controls.Add(this.cclblMesesGarantia);
            this.pnlBody.Controls.Add(this.cclblReparacionRealizada);
            this.pnlBody.Controls.Add(this.cclblEstadoReparacion);
            this.pnlBody.Controls.Add(this.cclblErrorARepara);
            this.pnlBody.Controls.Add(this.cclblFechaEgreso);
            this.pnlBody.Controls.Add(this.cclblFechaIngreso);
            this.pnlBody.Controls.Add(this.cclblId);
            this.pnlBody.Controls.Add(this.btnVerLavarropa);
            this.pnlBody.Controls.Add(this.btnVerEntregas);
            this.pnlBody.Controls.Add(this.ccLabel11);
            this.pnlBody.Controls.Add(this.ccLabel10);
            this.pnlBody.Controls.Add(this.ccLabel9);
            this.pnlBody.Controls.Add(this.ccLabel8);
            this.pnlBody.Controls.Add(this.ccLabel7);
            this.pnlBody.Controls.Add(this.ccLabel6);
            this.pnlBody.Controls.Add(this.ccLabel5);
            this.pnlBody.Controls.Add(this.ccLabel4);
            this.pnlBody.Controls.Add(this.ccLabel3);
            this.pnlBody.Controls.Add(this.ccLabel1);
            this.pnlBody.Controls.Add(this.ccLabel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(747, 310);
            this.pnlBody.TabIndex = 4;
            // 
            // cclblTotal
            // 
            this.cclblTotal.AutoSize = true;
            this.cclblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotal.Location = new System.Drawing.Point(640, 200);
            this.cclblTotal.Name = "cclblTotal";
            this.cclblTotal.Size = new System.Drawing.Size(0, 16);
            this.cclblTotal.TabIndex = 23;
            // 
            // cclblTotalRepuestos
            // 
            this.cclblTotalRepuestos.AutoSize = true;
            this.cclblTotalRepuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalRepuestos.Location = new System.Drawing.Point(504, 200);
            this.cclblTotalRepuestos.Name = "cclblTotalRepuestos";
            this.cclblTotalRepuestos.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalRepuestos.TabIndex = 22;
            // 
            // cclblManoObra
            // 
            this.cclblManoObra.AutoSize = true;
            this.cclblManoObra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblManoObra.Location = new System.Drawing.Point(147, 200);
            this.cclblManoObra.Name = "cclblManoObra";
            this.cclblManoObra.Size = new System.Drawing.Size(0, 16);
            this.cclblManoObra.TabIndex = 21;
            // 
            // cclblMesesGarantia
            // 
            this.cclblMesesGarantia.AutoSize = true;
            this.cclblMesesGarantia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMesesGarantia.Location = new System.Drawing.Point(594, 134);
            this.cclblMesesGarantia.Name = "cclblMesesGarantia";
            this.cclblMesesGarantia.Size = new System.Drawing.Size(0, 16);
            this.cclblMesesGarantia.TabIndex = 20;
            // 
            // cclblReparacionRealizada
            // 
            this.cclblReparacionRealizada.AutoSize = true;
            this.cclblReparacionRealizada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblReparacionRealizada.Location = new System.Drawing.Point(186, 134);
            this.cclblReparacionRealizada.Name = "cclblReparacionRealizada";
            this.cclblReparacionRealizada.Size = new System.Drawing.Size(0, 16);
            this.cclblReparacionRealizada.TabIndex = 19;
            // 
            // cclblEstadoReparacion
            // 
            this.cclblEstadoReparacion.AutoSize = true;
            this.cclblEstadoReparacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstadoReparacion.Location = new System.Drawing.Point(608, 79);
            this.cclblEstadoReparacion.Name = "cclblEstadoReparacion";
            this.cclblEstadoReparacion.Size = new System.Drawing.Size(0, 16);
            this.cclblEstadoReparacion.TabIndex = 18;
            // 
            // cclblErrorARepara
            // 
            this.cclblErrorARepara.AutoSize = true;
            this.cclblErrorARepara.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblErrorARepara.Location = new System.Drawing.Point(153, 79);
            this.cclblErrorARepara.Name = "cclblErrorARepara";
            this.cclblErrorARepara.Size = new System.Drawing.Size(0, 16);
            this.cclblErrorARepara.TabIndex = 17;
            // 
            // cclblFechaEgreso
            // 
            this.cclblFechaEgreso.AutoSize = true;
            this.cclblFechaEgreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaEgreso.Location = new System.Drawing.Point(613, 35);
            this.cclblFechaEgreso.Name = "cclblFechaEgreso";
            this.cclblFechaEgreso.Size = new System.Drawing.Size(0, 16);
            this.cclblFechaEgreso.TabIndex = 16;
            // 
            // cclblFechaIngreso
            // 
            this.cclblFechaIngreso.AutoSize = true;
            this.cclblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaIngreso.Location = new System.Drawing.Point(335, 35);
            this.cclblFechaIngreso.Name = "cclblFechaIngreso";
            this.cclblFechaIngreso.Size = new System.Drawing.Size(0, 16);
            this.cclblFechaIngreso.TabIndex = 15;
            // 
            // cclblId
            // 
            this.cclblId.AutoSize = true;
            this.cclblId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblId.Location = new System.Drawing.Point(71, 35);
            this.cclblId.Name = "cclblId";
            this.cclblId.Size = new System.Drawing.Size(0, 16);
            this.cclblId.TabIndex = 14;
            // 
            // btnVerLavarropa
            // 
            this.btnVerLavarropa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerLavarropa.Location = new System.Drawing.Point(242, 252);
            this.btnVerLavarropa.Name = "btnVerLavarropa";
            this.btnVerLavarropa.Size = new System.Drawing.Size(93, 23);
            this.btnVerLavarropa.TabIndex = 13;
            this.btnVerLavarropa.Text = "Ver Lavarropa";
            this.btnVerLavarropa.UseVisualStyleBackColor = true;
            this.btnVerLavarropa.Click += new System.EventHandler(this.btnVerLavarropas_Click);
            // 
            // btnVerEntregas
            // 
            this.btnVerEntregas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerEntregas.Location = new System.Drawing.Point(575, 252);
            this.btnVerEntregas.Name = "btnVerEntregas";
            this.btnVerEntregas.Size = new System.Drawing.Size(93, 23);
            this.btnVerEntregas.TabIndex = 12;
            this.btnVerEntregas.Text = "Ver Entregas";
            this.btnVerEntregas.UseVisualStyleBackColor = true;
            this.btnVerEntregas.Click += new System.EventHandler(this.btnVerEntregas_Click);
            // 
            // ccLabel11
            // 
            this.ccLabel11.AutoSize = true;
            this.ccLabel11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel11.Location = new System.Drawing.Point(43, 134);
            this.ccLabel11.Name = "ccLabel11";
            this.ccLabel11.Size = new System.Drawing.Size(137, 16);
            this.ccLabel11.TabIndex = 11;
            this.ccLabel11.Text = "Reparacion Realizada:";
            // 
            // ccLabel10
            // 
            this.ccLabel10.AutoSize = true;
            this.ccLabel10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel10.Location = new System.Drawing.Point(64, 256);
            this.ccLabel10.Name = "ccLabel10";
            this.ccLabel10.Size = new System.Drawing.Size(70, 16);
            this.ccLabel10.TabIndex = 10;
            this.ccLabel10.Text = "Lavarropa:";
            // 
            // ccLabel9
            // 
            this.ccLabel9.AutoSize = true;
            this.ccLabel9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel9.Location = new System.Drawing.Point(594, 200);
            this.ccLabel9.Name = "ccLabel9";
            this.ccLabel9.Size = new System.Drawing.Size(40, 16);
            this.ccLabel9.TabIndex = 9;
            this.ccLabel9.Text = "Total:";
            // 
            // ccLabel8
            // 
            this.ccLabel8.AutoSize = true;
            this.ccLabel8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel8.Location = new System.Drawing.Point(374, 200);
            this.ccLabel8.Name = "ccLabel8";
            this.ccLabel8.Size = new System.Drawing.Size(124, 16);
            this.ccLabel8.TabIndex = 8;
            this.ccLabel8.Text = "Total de Repuestos:";
            // 
            // ccLabel7
            // 
            this.ccLabel7.AutoSize = true;
            this.ccLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel7.Location = new System.Drawing.Point(43, 200);
            this.ccLabel7.Name = "ccLabel7";
            this.ccLabel7.Size = new System.Drawing.Size(98, 16);
            this.ccLabel7.TabIndex = 7;
            this.ccLabel7.Text = "Mano de Obra:";
            // 
            // ccLabel6
            // 
            this.ccLabel6.AutoSize = true;
            this.ccLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel6.Location = new System.Drawing.Point(467, 79);
            this.ccLabel6.Name = "ccLabel6";
            this.ccLabel6.Size = new System.Drawing.Size(140, 16);
            this.ccLabel6.TabIndex = 6;
            this.ccLabel6.Text = "Estado de Reparacion:";
            // 
            // ccLabel5
            // 
            this.ccLabel5.AutoSize = true;
            this.ccLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel5.Location = new System.Drawing.Point(467, 134);
            this.ccLabel5.Name = "ccLabel5";
            this.ccLabel5.Size = new System.Drawing.Size(121, 16);
            this.ccLabel5.TabIndex = 5;
            this.ccLabel5.Text = "Meses de Garantia:";
            // 
            // ccLabel4
            // 
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(43, 79);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(104, 16);
            this.ccLabel4.TabIndex = 4;
            this.ccLabel4.Text = "Error A Reparar:";
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRepuestos.Location = new System.Drawing.Point(205, 196);
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(93, 23);
            this.btnRepuestos.TabIndex = 24;
            this.btnRepuestos.Text = "Ver Repuestos";
            this.btnRepuestos.UseVisualStyleBackColor = true;
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // ccLabel12
            // 
            this.ccLabel12.AutoSize = true;
            this.ccLabel12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel12.Location = new System.Drawing.Point(423, 256);
            this.ccLabel12.Name = "ccLabel12";
            this.ccLabel12.Size = new System.Drawing.Size(62, 16);
            this.ccLabel12.TabIndex = 25;
            this.ccLabel12.Text = "Entregas:";
            // 
            // frmDetalleReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 392);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel ccLabel1;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel3;
        private System.Windows.Forms.Panel pnlBody;
        private ccLibrary.ccLabel ccLabel10;
        private ccLibrary.ccLabel ccLabel9;
        private ccLibrary.ccLabel ccLabel8;
        private ccLibrary.ccLabel ccLabel7;
        private ccLibrary.ccLabel ccLabel6;
        private ccLibrary.ccLabel ccLabel5;
        private ccLibrary.ccLabel ccLabel4;
        private System.Windows.Forms.Button btnVerLavarropa;
        private System.Windows.Forms.Button btnVerEntregas;
        private ccLibrary.ccLabel ccLabel11;
        private ccLibrary.ccLabel cclblTotal;
        private ccLibrary.ccLabel cclblTotalRepuestos;
        private ccLibrary.ccLabel cclblManoObra;
        private ccLibrary.ccLabel cclblMesesGarantia;
        private ccLibrary.ccLabel cclblReparacionRealizada;
        private ccLibrary.ccLabel cclblEstadoReparacion;
        private ccLibrary.ccLabel cclblErrorARepara;
        private ccLibrary.ccLabel cclblFechaEgreso;
        private ccLibrary.ccLabel cclblFechaIngreso;
        private ccLibrary.ccLabel cclblId;
        private ccLibrary.ccLabel ccLabel12;
        private System.Windows.Forms.Button btnRepuestos;
    }
}