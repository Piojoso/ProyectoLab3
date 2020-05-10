namespace MAB.Forms.Reparaciones
{
    partial class frmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ucBottom = new ucLibrary.ucBottom();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlNumeroReparaciones = new System.Windows.Forms.Panel();
            this.pnlCantRepOut = new System.Windows.Forms.Panel();
            this.chartCantRepOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTopCantRepOut = new System.Windows.Forms.Panel();
            this.rbCantRepOutAnual = new System.Windows.Forms.RadioButton();
            this.rbCantRepOutMensual = new System.Windows.Forms.RadioButton();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.pnlCantRepIn = new System.Windows.Forms.Panel();
            this.chartCantRepIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTopCantRepIn = new System.Windows.Forms.Panel();
            this.rbCantRepInAnual = new System.Windows.Forms.RadioButton();
            this.rbCantRepInMensual = new System.Windows.Forms.RadioButton();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.pnlIngresosReparaciones = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.pnlNumeroReparaciones.SuspendLayout();
            this.pnlCantRepOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantRepOut)).BeginInit();
            this.pnlTopCantRepOut.SuspendLayout();
            this.pnlCantRepIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantRepIn)).BeginInit();
            this.pnlTopCantRepIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 429);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.Size = new System.Drawing.Size(783, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlNumeroReparaciones);
            this.pnlBody.Controls.Add(this.pnlIngresosReparaciones);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(783, 429);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlNumeroReparaciones
            // 
            this.pnlNumeroReparaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNumeroReparaciones.Controls.Add(this.pnlCantRepOut);
            this.pnlNumeroReparaciones.Controls.Add(this.pnlCantRepIn);
            this.pnlNumeroReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNumeroReparaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlNumeroReparaciones.Name = "pnlNumeroReparaciones";
            this.pnlNumeroReparaciones.Size = new System.Drawing.Size(783, 429);
            this.pnlNumeroReparaciones.TabIndex = 0;
            // 
            // pnlCantRepOut
            // 
            this.pnlCantRepOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCantRepOut.Controls.Add(this.chartCantRepOut);
            this.pnlCantRepOut.Controls.Add(this.pnlTopCantRepOut);
            this.pnlCantRepOut.Location = new System.Drawing.Point(3, 219);
            this.pnlCantRepOut.Name = "pnlCantRepOut";
            this.pnlCantRepOut.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCantRepOut.Size = new System.Drawing.Size(777, 210);
            this.pnlCantRepOut.TabIndex = 9;
            // 
            // chartCantRepOut
            // 
            this.chartCantRepOut.BorderlineColor = System.Drawing.Color.Black;
            this.chartCantRepOut.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartCantRepOut.ChartAreas.Add(chartArea1);
            this.chartCantRepOut.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCantRepOut.Legends.Add(legend1);
            this.chartCantRepOut.Location = new System.Drawing.Point(15, 32);
            this.chartCantRepOut.Name = "chartCantRepOut";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCantRepOut.Series.Add(series1);
            this.chartCantRepOut.Size = new System.Drawing.Size(747, 163);
            this.chartCantRepOut.TabIndex = 5;
            this.chartCantRepOut.Text = "Cantidad de Reparaciones Ingresados";
            // 
            // pnlTopCantRepOut
            // 
            this.pnlTopCantRepOut.Controls.Add(this.rbCantRepOutAnual);
            this.pnlTopCantRepOut.Controls.Add(this.rbCantRepOutMensual);
            this.pnlTopCantRepOut.Controls.Add(this.ccLabel1);
            this.pnlTopCantRepOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopCantRepOut.Location = new System.Drawing.Point(15, 15);
            this.pnlTopCantRepOut.Name = "pnlTopCantRepOut";
            this.pnlTopCantRepOut.Size = new System.Drawing.Size(747, 17);
            this.pnlTopCantRepOut.TabIndex = 7;
            // 
            // rbCantRepOutAnual
            // 
            this.rbCantRepOutAnual.AutoSize = true;
            this.rbCantRepOutAnual.Location = new System.Drawing.Point(340, 0);
            this.rbCantRepOutAnual.Name = "rbCantRepOutAnual";
            this.rbCantRepOutAnual.Size = new System.Drawing.Size(81, 17);
            this.rbCantRepOutAnual.TabIndex = 8;
            this.rbCantRepOutAnual.Text = "Anualmente";
            this.rbCantRepOutAnual.UseVisualStyleBackColor = true;
            this.rbCantRepOutAnual.CheckedChanged += new System.EventHandler(this.rbCantRepOutAnual_CheckedChanged);
            // 
            // rbCantRepOutMensual
            // 
            this.rbCantRepOutMensual.AutoSize = true;
            this.rbCantRepOutMensual.Location = new System.Drawing.Point(240, 0);
            this.rbCantRepOutMensual.Name = "rbCantRepOutMensual";
            this.rbCantRepOutMensual.Size = new System.Drawing.Size(94, 17);
            this.rbCantRepOutMensual.TabIndex = 7;
            this.rbCantRepOutMensual.Text = "Mensualmente";
            this.rbCantRepOutMensual.UseVisualStyleBackColor = true;
            this.rbCantRepOutMensual.CheckedChanged += new System.EventHandler(this.rbCantRepOutMensual_CheckedChanged);
            // 
            // ccLabel1
            // 
            this.ccLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(0, 1);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(230, 16);
            this.ccLabel1.TabIndex = 6;
            this.ccLabel1.Text = "Cantidad de Reparaciones Egresadas:";
            // 
            // pnlCantRepIn
            // 
            this.pnlCantRepIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCantRepIn.Controls.Add(this.chartCantRepIn);
            this.pnlCantRepIn.Controls.Add(this.pnlTopCantRepIn);
            this.pnlCantRepIn.Location = new System.Drawing.Point(3, 3);
            this.pnlCantRepIn.Name = "pnlCantRepIn";
            this.pnlCantRepIn.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCantRepIn.Size = new System.Drawing.Size(777, 210);
            this.pnlCantRepIn.TabIndex = 8;
            // 
            // chartCantRepIn
            // 
            this.chartCantRepIn.BorderlineColor = System.Drawing.Color.Black;
            this.chartCantRepIn.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartCantRepIn.ChartAreas.Add(chartArea2);
            this.chartCantRepIn.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartCantRepIn.Legends.Add(legend2);
            this.chartCantRepIn.Location = new System.Drawing.Point(15, 32);
            this.chartCantRepIn.Name = "chartCantRepIn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCantRepIn.Series.Add(series2);
            this.chartCantRepIn.Size = new System.Drawing.Size(747, 163);
            this.chartCantRepIn.TabIndex = 5;
            this.chartCantRepIn.Text = "Cantidad de Reparaciones Ingresados";
            // 
            // pnlTopCantRepIn
            // 
            this.pnlTopCantRepIn.Controls.Add(this.rbCantRepInAnual);
            this.pnlTopCantRepIn.Controls.Add(this.rbCantRepInMensual);
            this.pnlTopCantRepIn.Controls.Add(this.ccLabel2);
            this.pnlTopCantRepIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopCantRepIn.Location = new System.Drawing.Point(15, 15);
            this.pnlTopCantRepIn.Name = "pnlTopCantRepIn";
            this.pnlTopCantRepIn.Size = new System.Drawing.Size(747, 17);
            this.pnlTopCantRepIn.TabIndex = 7;
            // 
            // rbCantRepInAnual
            // 
            this.rbCantRepInAnual.AutoSize = true;
            this.rbCantRepInAnual.Location = new System.Drawing.Point(340, 0);
            this.rbCantRepInAnual.Name = "rbCantRepInAnual";
            this.rbCantRepInAnual.Size = new System.Drawing.Size(81, 17);
            this.rbCantRepInAnual.TabIndex = 8;
            this.rbCantRepInAnual.Text = "Anualmente";
            this.rbCantRepInAnual.UseVisualStyleBackColor = true;
            this.rbCantRepInAnual.CheckedChanged += new System.EventHandler(this.rbCantRepInAnual_CheckedChanged);
            // 
            // rbCantRepInMensual
            // 
            this.rbCantRepInMensual.AutoSize = true;
            this.rbCantRepInMensual.Location = new System.Drawing.Point(240, 0);
            this.rbCantRepInMensual.Name = "rbCantRepInMensual";
            this.rbCantRepInMensual.Size = new System.Drawing.Size(94, 17);
            this.rbCantRepInMensual.TabIndex = 7;
            this.rbCantRepInMensual.Text = "Mensualmente";
            this.rbCantRepInMensual.UseVisualStyleBackColor = true;
            this.rbCantRepInMensual.CheckedChanged += new System.EventHandler(this.rbCantRepInMensual_CheckedChanged);
            // 
            // ccLabel2
            // 
            this.ccLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(0, 1);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(234, 16);
            this.ccLabel2.TabIndex = 6;
            this.ccLabel2.Text = "Cantidad de Reparaciones Ingresados:";
            // 
            // pnlIngresosReparaciones
            // 
            this.pnlIngresosReparaciones.BackColor = System.Drawing.Color.Red;
            this.pnlIngresosReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIngresosReparaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlIngresosReparaciones.Name = "pnlIngresosReparaciones";
            this.pnlIngresosReparaciones.Size = new System.Drawing.Size(783, 429);
            this.pnlIngresosReparaciones.TabIndex = 1;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 511);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ucBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstadisticas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Estadisticas de las Reparaciones";
            this.pnlBody.ResumeLayout(false);
            this.pnlNumeroReparaciones.ResumeLayout(false);
            this.pnlCantRepOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCantRepOut)).EndInit();
            this.pnlTopCantRepOut.ResumeLayout(false);
            this.pnlTopCantRepOut.PerformLayout();
            this.pnlCantRepIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCantRepIn)).EndInit();
            this.pnlTopCantRepIn.ResumeLayout(false);
            this.pnlTopCantRepIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlNumeroReparaciones;
        private System.Windows.Forms.Panel pnlIngresosReparaciones;
        private System.Windows.Forms.Panel pnlCantRepOut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantRepOut;
        private System.Windows.Forms.Panel pnlTopCantRepOut;
        private System.Windows.Forms.RadioButton rbCantRepOutAnual;
        private System.Windows.Forms.RadioButton rbCantRepOutMensual;
        private ccLibrary.ccLabel ccLabel1;
        private System.Windows.Forms.Panel pnlCantRepIn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCantRepIn;
        private System.Windows.Forms.Panel pnlTopCantRepIn;
        private System.Windows.Forms.RadioButton rbCantRepInAnual;
        private System.Windows.Forms.RadioButton rbCantRepInMensual;
        private ccLibrary.ccLabel ccLabel2;
    }
}