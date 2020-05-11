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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ucBottom = new ucLibrary.ucBottom();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlIngresosReparaciones = new System.Windows.Forms.Panel();
            this.pnlTotalRep = new System.Windows.Forms.Panel();
            this.ccLabel10 = new ccLibrary.ccLabel();
            this.ccLabel12 = new ccLibrary.ccLabel();
            this.cclblTotalNoFinalizadas = new ccLibrary.ccLabel();
            this.cclblTotalRep = new ccLibrary.ccLabel();
            this.ccLabel5 = new ccLibrary.ccLabel();
            this.cclblTotalFinalizadas = new ccLibrary.ccLabel();
            this.cclblTotalEnCurso = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.pnlIngresos = new System.Windows.Forms.Panel();
            this.chartIngresosReparaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTopIngresos = new System.Windows.Forms.Panel();
            this.rbIngresosAnuales = new System.Windows.Forms.RadioButton();
            this.rbIngresosMensuales = new System.Windows.Forms.RadioButton();
            this.ccLabel7 = new ccLibrary.ccLabel();
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
            this.pnlBody.SuspendLayout();
            this.pnlIngresosReparaciones.SuspendLayout();
            this.pnlTotalRep.SuspendLayout();
            this.pnlIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresosReparaciones)).BeginInit();
            this.pnlTopIngresos.SuspendLayout();
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
            this.pnlBody.Controls.Add(this.pnlIngresosReparaciones);
            this.pnlBody.Controls.Add(this.pnlNumeroReparaciones);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(783, 429);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlIngresosReparaciones
            // 
            this.pnlIngresosReparaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlIngresosReparaciones.Controls.Add(this.pnlTotalRep);
            this.pnlIngresosReparaciones.Controls.Add(this.pnlIngresos);
            this.pnlIngresosReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIngresosReparaciones.Location = new System.Drawing.Point(0, 0);
            this.pnlIngresosReparaciones.Name = "pnlIngresosReparaciones";
            this.pnlIngresosReparaciones.Size = new System.Drawing.Size(783, 429);
            this.pnlIngresosReparaciones.TabIndex = 1;
            // 
            // pnlTotalRep
            // 
            this.pnlTotalRep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalRep.Controls.Add(this.ccLabel10);
            this.pnlTotalRep.Controls.Add(this.ccLabel12);
            this.pnlTotalRep.Controls.Add(this.cclblTotalNoFinalizadas);
            this.pnlTotalRep.Controls.Add(this.cclblTotalRep);
            this.pnlTotalRep.Controls.Add(this.ccLabel5);
            this.pnlTotalRep.Controls.Add(this.cclblTotalFinalizadas);
            this.pnlTotalRep.Controls.Add(this.cclblTotalEnCurso);
            this.pnlTotalRep.Controls.Add(this.ccLabel3);
            this.pnlTotalRep.Location = new System.Drawing.Point(3, 3);
            this.pnlTotalRep.Name = "pnlTotalRep";
            this.pnlTotalRep.Padding = new System.Windows.Forms.Padding(15);
            this.pnlTotalRep.Size = new System.Drawing.Size(777, 132);
            this.pnlTotalRep.TabIndex = 20;
            // 
            // ccLabel10
            // 
            this.ccLabel10.AutoSize = true;
            this.ccLabel10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel10.Location = new System.Drawing.Point(289, 28);
            this.ccLabel10.Name = "ccLabel10";
            this.ccLabel10.Size = new System.Drawing.Size(142, 16);
            this.ccLabel10.TabIndex = 11;
            this.ccLabel10.Text = "Total de Reparaciones:";
            // 
            // ccLabel12
            // 
            this.ccLabel12.AutoSize = true;
            this.ccLabel12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel12.Location = new System.Drawing.Point(95, 89);
            this.ccLabel12.Name = "ccLabel12";
            this.ccLabel12.Size = new System.Drawing.Size(63, 16);
            this.ccLabel12.TabIndex = 12;
            this.ccLabel12.Text = "En Curso:";
            // 
            // cclblTotalNoFinalizadas
            // 
            this.cclblTotalNoFinalizadas.AutoSize = true;
            this.cclblTotalNoFinalizadas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalNoFinalizadas.Location = new System.Drawing.Point(419, 89);
            this.cclblTotalNoFinalizadas.Name = "cclblTotalNoFinalizadas";
            this.cclblTotalNoFinalizadas.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalNoFinalizadas.TabIndex = 18;
            // 
            // cclblTotalRep
            // 
            this.cclblTotalRep.AutoSize = true;
            this.cclblTotalRep.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalRep.Location = new System.Drawing.Point(437, 28);
            this.cclblTotalRep.Name = "cclblTotalRep";
            this.cclblTotalRep.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalRep.TabIndex = 13;
            // 
            // ccLabel5
            // 
            this.ccLabel5.AutoSize = true;
            this.ccLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel5.Location = new System.Drawing.Point(317, 89);
            this.ccLabel5.Name = "ccLabel5";
            this.ccLabel5.Size = new System.Drawing.Size(96, 16);
            this.ccLabel5.TabIndex = 17;
            this.ccLabel5.Text = "No Finalizadas:";
            // 
            // cclblTotalFinalizadas
            // 
            this.cclblTotalFinalizadas.AutoSize = true;
            this.cclblTotalFinalizadas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalFinalizadas.Location = new System.Drawing.Point(652, 89);
            this.cclblTotalFinalizadas.Name = "cclblTotalFinalizadas";
            this.cclblTotalFinalizadas.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalFinalizadas.TabIndex = 14;
            // 
            // cclblTotalEnCurso
            // 
            this.cclblTotalEnCurso.AutoSize = true;
            this.cclblTotalEnCurso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalEnCurso.Location = new System.Drawing.Point(164, 89);
            this.cclblTotalEnCurso.Name = "cclblTotalEnCurso";
            this.cclblTotalEnCurso.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalEnCurso.TabIndex = 16;
            // 
            // ccLabel3
            // 
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(572, 89);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(74, 16);
            this.ccLabel3.TabIndex = 15;
            this.ccLabel3.Text = "Finalizadas:";
            // 
            // pnlIngresos
            // 
            this.pnlIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIngresos.Controls.Add(this.chartIngresosReparaciones);
            this.pnlIngresos.Controls.Add(this.pnlTopIngresos);
            this.pnlIngresos.Location = new System.Drawing.Point(3, 141);
            this.pnlIngresos.Name = "pnlIngresos";
            this.pnlIngresos.Padding = new System.Windows.Forms.Padding(15);
            this.pnlIngresos.Size = new System.Drawing.Size(777, 285);
            this.pnlIngresos.TabIndex = 19;
            // 
            // chartIngresosReparaciones
            // 
            this.chartIngresosReparaciones.BorderlineColor = System.Drawing.Color.Black;
            this.chartIngresosReparaciones.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chartIngresosReparaciones.ChartAreas.Add(chartArea4);
            this.chartIngresosReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartIngresosReparaciones.Legends.Add(legend4);
            this.chartIngresosReparaciones.Location = new System.Drawing.Point(15, 32);
            this.chartIngresosReparaciones.Name = "chartIngresosReparaciones";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartIngresosReparaciones.Series.Add(series4);
            this.chartIngresosReparaciones.Size = new System.Drawing.Size(747, 238);
            this.chartIngresosReparaciones.TabIndex = 5;
            this.chartIngresosReparaciones.Text = "Cantidad de Reparaciones Ingresados";
            // 
            // pnlTopIngresos
            // 
            this.pnlTopIngresos.Controls.Add(this.rbIngresosAnuales);
            this.pnlTopIngresos.Controls.Add(this.rbIngresosMensuales);
            this.pnlTopIngresos.Controls.Add(this.ccLabel7);
            this.pnlTopIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopIngresos.Location = new System.Drawing.Point(15, 15);
            this.pnlTopIngresos.Name = "pnlTopIngresos";
            this.pnlTopIngresos.Size = new System.Drawing.Size(747, 17);
            this.pnlTopIngresos.TabIndex = 7;
            // 
            // rbIngresosAnuales
            // 
            this.rbIngresosAnuales.AutoSize = true;
            this.rbIngresosAnuales.Location = new System.Drawing.Point(340, 0);
            this.rbIngresosAnuales.Name = "rbIngresosAnuales";
            this.rbIngresosAnuales.Size = new System.Drawing.Size(81, 17);
            this.rbIngresosAnuales.TabIndex = 8;
            this.rbIngresosAnuales.Text = "Anualmente";
            this.rbIngresosAnuales.UseVisualStyleBackColor = true;
            this.rbIngresosAnuales.CheckedChanged += new System.EventHandler(this.rbIngresosAnuales_CheckedChanged);
            // 
            // rbIngresosMensuales
            // 
            this.rbIngresosMensuales.AutoSize = true;
            this.rbIngresosMensuales.Location = new System.Drawing.Point(240, 0);
            this.rbIngresosMensuales.Name = "rbIngresosMensuales";
            this.rbIngresosMensuales.Size = new System.Drawing.Size(94, 17);
            this.rbIngresosMensuales.TabIndex = 7;
            this.rbIngresosMensuales.Text = "Mensualmente";
            this.rbIngresosMensuales.UseVisualStyleBackColor = true;
            this.rbIngresosMensuales.CheckedChanged += new System.EventHandler(this.rbIngresosMensuales_CheckedChanged);
            // 
            // ccLabel7
            // 
            this.ccLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel7.AutoSize = true;
            this.ccLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel7.Location = new System.Drawing.Point(0, 1);
            this.ccLabel7.Name = "ccLabel7";
            this.ccLabel7.Size = new System.Drawing.Size(228, 16);
            this.ccLabel7.TabIndex = 6;
            this.ccLabel7.Text = "Ingresos Obtenidos de Reparaciones:";
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
            chartArea5.Name = "ChartArea1";
            this.chartCantRepOut.ChartAreas.Add(chartArea5);
            this.chartCantRepOut.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartCantRepOut.Legends.Add(legend5);
            this.chartCantRepOut.Location = new System.Drawing.Point(15, 32);
            this.chartCantRepOut.Name = "chartCantRepOut";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartCantRepOut.Series.Add(series5);
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
            chartArea6.Name = "ChartArea1";
            this.chartCantRepIn.ChartAreas.Add(chartArea6);
            this.chartCantRepIn.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartCantRepIn.Legends.Add(legend6);
            this.chartCantRepIn.Location = new System.Drawing.Point(15, 32);
            this.chartCantRepIn.Name = "chartCantRepIn";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartCantRepIn.Series.Add(series6);
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
            this.pnlIngresosReparaciones.ResumeLayout(false);
            this.pnlTotalRep.ResumeLayout(false);
            this.pnlTotalRep.PerformLayout();
            this.pnlIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresosReparaciones)).EndInit();
            this.pnlTopIngresos.ResumeLayout(false);
            this.pnlTopIngresos.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTotalRep;
        private ccLibrary.ccLabel ccLabel10;
        private ccLibrary.ccLabel ccLabel12;
        private ccLibrary.ccLabel cclblTotalNoFinalizadas;
        private ccLibrary.ccLabel cclblTotalRep;
        private ccLibrary.ccLabel ccLabel5;
        private ccLibrary.ccLabel cclblTotalFinalizadas;
        private ccLibrary.ccLabel cclblTotalEnCurso;
        private ccLibrary.ccLabel ccLabel3;
        private System.Windows.Forms.Panel pnlIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresosReparaciones;
        private System.Windows.Forms.Panel pnlTopIngresos;
        private System.Windows.Forms.RadioButton rbIngresosAnuales;
        private System.Windows.Forms.RadioButton rbIngresosMensuales;
        private ccLibrary.ccLabel ccLabel7;
    }
}