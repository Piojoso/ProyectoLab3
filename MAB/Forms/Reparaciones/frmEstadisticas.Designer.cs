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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.pnlRepuestosUsados = new System.Windows.Forms.Panel();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.chartRepuestoUsado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTituloChart = new System.Windows.Forms.Panel();
            this.rbRepuestoUsadoAnualmente = new System.Windows.Forms.RadioButton();
            this.rbRepuestoUsadoMensualmente = new System.Windows.Forms.RadioButton();
            this.ccLabel16 = new ccLibrary.ccLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cclblPorcentajeReparacionesConRepuesto = new ccLibrary.ccLabel();
            this.ccLabel9 = new ccLibrary.ccLabel();
            this.cclblCantReparacionesConRepuesto = new ccLibrary.ccLabel();
            this.ccLabel6 = new ccLibrary.ccLabel();
            this.btnSeleccionarRepuesto = new System.Windows.Forms.Button();
            this.cboRepuestoSeleccionado = new System.Windows.Forms.ComboBox();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel13 = new ccLibrary.ccLabel();
            this.ucBottom = new ucLibrary.ucBottom();
            this.pnlBody.SuspendLayout();
            this.pnlNumeroReparaciones.SuspendLayout();
            this.pnlCantRepOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantRepOut)).BeginInit();
            this.pnlTopCantRepOut.SuspendLayout();
            this.pnlCantRepIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCantRepIn)).BeginInit();
            this.pnlTopCantRepIn.SuspendLayout();
            this.pnlRepuestosUsados.SuspendLayout();
            this.pnlGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRepuestoUsado)).BeginInit();
            this.pnlTituloChart.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlNumeroReparaciones);
            this.pnlBody.Controls.Add(this.pnlRepuestosUsados);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(783, 433);
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
            this.pnlNumeroReparaciones.Size = new System.Drawing.Size(783, 433);
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
            series2.Name = "Repuesto";
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
            // pnlRepuestosUsados
            // 
            this.pnlRepuestosUsados.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRepuestosUsados.Controls.Add(this.pnlGrafico);
            this.pnlRepuestosUsados.Controls.Add(this.panel2);
            this.pnlRepuestosUsados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRepuestosUsados.Location = new System.Drawing.Point(0, 0);
            this.pnlRepuestosUsados.Name = "pnlRepuestosUsados";
            this.pnlRepuestosUsados.Size = new System.Drawing.Size(783, 433);
            this.pnlRepuestosUsados.TabIndex = 2;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Controls.Add(this.chartRepuestoUsado);
            this.pnlGrafico.Controls.Add(this.pnlTituloChart);
            this.pnlGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrafico.Location = new System.Drawing.Point(0, 126);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Padding = new System.Windows.Forms.Padding(15);
            this.pnlGrafico.Size = new System.Drawing.Size(783, 307);
            this.pnlGrafico.TabIndex = 19;
            // 
            // chartRepuestoUsado
            // 
            this.chartRepuestoUsado.BorderlineColor = System.Drawing.Color.Black;
            this.chartRepuestoUsado.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chartRepuestoUsado.ChartAreas.Add(chartArea3);
            this.chartRepuestoUsado.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartRepuestoUsado.Legends.Add(legend3);
            this.chartRepuestoUsado.Location = new System.Drawing.Point(15, 32);
            this.chartRepuestoUsado.Name = "chartRepuestoUsado";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRepuestoUsado.Series.Add(series3);
            this.chartRepuestoUsado.Size = new System.Drawing.Size(753, 260);
            this.chartRepuestoUsado.TabIndex = 5;
            this.chartRepuestoUsado.Text = "Cantidad de Reparaciones Ingresados";
            // 
            // pnlTituloChart
            // 
            this.pnlTituloChart.Controls.Add(this.rbRepuestoUsadoAnualmente);
            this.pnlTituloChart.Controls.Add(this.rbRepuestoUsadoMensualmente);
            this.pnlTituloChart.Controls.Add(this.ccLabel16);
            this.pnlTituloChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloChart.Location = new System.Drawing.Point(15, 15);
            this.pnlTituloChart.Name = "pnlTituloChart";
            this.pnlTituloChart.Size = new System.Drawing.Size(753, 17);
            this.pnlTituloChart.TabIndex = 7;
            // 
            // rbRepuestoUsadoAnualmente
            // 
            this.rbRepuestoUsadoAnualmente.AutoSize = true;
            this.rbRepuestoUsadoAnualmente.Location = new System.Drawing.Point(217, 0);
            this.rbRepuestoUsadoAnualmente.Name = "rbRepuestoUsadoAnualmente";
            this.rbRepuestoUsadoAnualmente.Size = new System.Drawing.Size(81, 17);
            this.rbRepuestoUsadoAnualmente.TabIndex = 8;
            this.rbRepuestoUsadoAnualmente.Text = "Anualmente";
            this.rbRepuestoUsadoAnualmente.UseVisualStyleBackColor = true;
            this.rbRepuestoUsadoAnualmente.CheckedChanged += new System.EventHandler(this.rbRepuestoUsadoAnualmente_CheckedChanged);
            // 
            // rbRepuestoUsadoMensualmente
            // 
            this.rbRepuestoUsadoMensualmente.AutoSize = true;
            this.rbRepuestoUsadoMensualmente.Location = new System.Drawing.Point(117, 0);
            this.rbRepuestoUsadoMensualmente.Name = "rbRepuestoUsadoMensualmente";
            this.rbRepuestoUsadoMensualmente.Size = new System.Drawing.Size(94, 17);
            this.rbRepuestoUsadoMensualmente.TabIndex = 7;
            this.rbRepuestoUsadoMensualmente.Text = "Mensualmente";
            this.rbRepuestoUsadoMensualmente.UseVisualStyleBackColor = true;
            this.rbRepuestoUsadoMensualmente.CheckedChanged += new System.EventHandler(this.rbRepuestoUsadoMensualmente_CheckedChanged);
            // 
            // ccLabel16
            // 
            this.ccLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel16.AutoSize = true;
            this.ccLabel16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel16.Location = new System.Drawing.Point(0, 1);
            this.ccLabel16.Name = "ccLabel16";
            this.ccLabel16.Size = new System.Drawing.Size(108, 16);
            this.ccLabel16.TabIndex = 6;
            this.ccLabel16.Text = "Repuesto Usado:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cclblPorcentajeReparacionesConRepuesto);
            this.panel2.Controls.Add(this.ccLabel9);
            this.panel2.Controls.Add(this.cclblCantReparacionesConRepuesto);
            this.panel2.Controls.Add(this.ccLabel6);
            this.panel2.Controls.Add(this.btnSeleccionarRepuesto);
            this.panel2.Controls.Add(this.cboRepuestoSeleccionado);
            this.panel2.Controls.Add(this.ccLabel4);
            this.panel2.Controls.Add(this.ccLabel13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(783, 126);
            this.panel2.TabIndex = 20;
            // 
            // cclblPorcentajeReparacionesConRepuesto
            // 
            this.cclblPorcentajeReparacionesConRepuesto.AutoSize = true;
            this.cclblPorcentajeReparacionesConRepuesto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblPorcentajeReparacionesConRepuesto.Location = new System.Drawing.Point(457, 88);
            this.cclblPorcentajeReparacionesConRepuesto.Name = "cclblPorcentajeReparacionesConRepuesto";
            this.cclblPorcentajeReparacionesConRepuesto.Size = new System.Drawing.Size(0, 16);
            this.cclblPorcentajeReparacionesConRepuesto.TabIndex = 21;
            // 
            // ccLabel9
            // 
            this.ccLabel9.AutoSize = true;
            this.ccLabel9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel9.Location = new System.Drawing.Point(184, 88);
            this.ccLabel9.Name = "ccLabel9";
            this.ccLabel9.Size = new System.Drawing.Size(267, 16);
            this.ccLabel9.TabIndex = 20;
            this.ccLabel9.Text = "Porcentaje de que cambiaron este repuesto:";
            // 
            // cclblCantReparacionesConRepuesto
            // 
            this.cclblCantReparacionesConRepuesto.AutoSize = true;
            this.cclblCantReparacionesConRepuesto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCantReparacionesConRepuesto.Location = new System.Drawing.Point(527, 55);
            this.cclblCantReparacionesConRepuesto.Name = "cclblCantReparacionesConRepuesto";
            this.cclblCantReparacionesConRepuesto.Size = new System.Drawing.Size(0, 16);
            this.cclblCantReparacionesConRepuesto.TabIndex = 19;
            // 
            // ccLabel6
            // 
            this.ccLabel6.AutoSize = true;
            this.ccLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel6.Location = new System.Drawing.Point(184, 55);
            this.ccLabel6.Name = "ccLabel6";
            this.ccLabel6.Size = new System.Drawing.Size(337, 16);
            this.ccLabel6.TabIndex = 18;
            this.ccLabel6.Text = "Numero de Reparaciones que cambiaron este repuesto:";
            // 
            // btnSeleccionarRepuesto
            // 
            this.btnSeleccionarRepuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarRepuesto.Location = new System.Drawing.Point(552, 11);
            this.btnSeleccionarRepuesto.Name = "btnSeleccionarRepuesto";
            this.btnSeleccionarRepuesto.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarRepuesto.TabIndex = 17;
            this.btnSeleccionarRepuesto.Text = "Cargar";
            this.btnSeleccionarRepuesto.UseVisualStyleBackColor = true;
            this.btnSeleccionarRepuesto.Click += new System.EventHandler(this.btnSeleccionarRepuesto_Click);
            // 
            // cboRepuestoSeleccionado
            // 
            this.cboRepuestoSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRepuestoSeleccionado.FormattingEnabled = true;
            this.cboRepuestoSeleccionado.Location = new System.Drawing.Point(307, 13);
            this.cboRepuestoSeleccionado.Name = "cboRepuestoSeleccionado";
            this.cboRepuestoSeleccionado.Size = new System.Drawing.Size(239, 21);
            this.cboRepuestoSeleccionado.TabIndex = 16;
            // 
            // ccLabel4
            // 
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(153, 15);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(148, 16);
            this.ccLabel4.TabIndex = 15;
            this.ccLabel4.Text = "Seleccione Un Repuesto";
            // 
            // ccLabel13
            // 
            this.ccLabel13.AutoSize = true;
            this.ccLabel13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel13.Location = new System.Drawing.Point(655, 86);
            this.ccLabel13.Name = "ccLabel13";
            this.ccLabel13.Size = new System.Drawing.Size(0, 16);
            this.ccLabel13.TabIndex = 14;
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 433);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.Size = new System.Drawing.Size(783, 82);
            this.ucBottom.TabIndex = 0;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 515);
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
            this.pnlRepuestosUsados.ResumeLayout(false);
            this.pnlGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRepuestoUsado)).EndInit();
            this.pnlTituloChart.ResumeLayout(false);
            this.pnlTituloChart.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlNumeroReparaciones;
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
        private System.Windows.Forms.Panel pnlRepuestosUsados;
        private System.Windows.Forms.Panel panel2;
        private ccLibrary.ccLabel ccLabel13;
        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRepuestoUsado;
        private System.Windows.Forms.Panel pnlTituloChart;
        private System.Windows.Forms.RadioButton rbRepuestoUsadoAnualmente;
        private System.Windows.Forms.RadioButton rbRepuestoUsadoMensualmente;
        private ccLibrary.ccLabel ccLabel16;
        private ccLibrary.ccLabel cclblPorcentajeReparacionesConRepuesto;
        private ccLibrary.ccLabel ccLabel9;
        private ccLibrary.ccLabel cclblCantReparacionesConRepuesto;
        private ccLibrary.ccLabel ccLabel6;
        private System.Windows.Forms.Button btnSeleccionarRepuesto;
        private System.Windows.Forms.ComboBox cboRepuestoSeleccionado;
        private ccLibrary.ccLabel ccLabel4;
    }
}