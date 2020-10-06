namespace MAB.Forms
{
    partial class frmInicio
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
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlEstadisticas = new System.Windows.Forms.Panel();
            this.pnlBodyEstadisticas = new System.Windows.Forms.Panel();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.cclblModeloMasReparado = new ccLibrary.ccLabel();
            this.cclblMarcaMasReparada = new ccLibrary.ccLabel();
            this.cclblLavarropasConMasReparaciones = new ccLibrary.ccLabel();
            this.cclblUltimoLavarropasAgregado = new ccLibrary.ccLabel();
            this.cclblTotalLavarropasGuardados = new ccLibrary.ccLabel();
            this.ccLabel16 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel7 = new ccLibrary.ccLabel();
            this.ccLabel6 = new ccLibrary.ccLabel();
            this.cclblClienteConMasLavarropas = new ccLibrary.ccLabel();
            this.cclblCliente4 = new ccLibrary.ccLabel();
            this.cclblClienteConMasReparaciones = new ccLibrary.ccLabel();
            this.cclblCliente3 = new ccLibrary.ccLabel();
            this.cclblUltimoClienteAgregado = new ccLibrary.ccLabel();
            this.cclblCliente1 = new ccLibrary.ccLabel();
            this.cclblTotalClientesGuardados = new ccLibrary.ccLabel();
            this.cclblCliente2 = new ccLibrary.ccLabel();
            this.tpOtros = new System.Windows.Forms.TabPage();
            this.tpStockFaltante = new System.Windows.Forms.TabPage();
            this.crvRepuestos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlTituloEstadisticas = new System.Windows.Forms.Panel();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.ucBotonera = new ucLibrary.ucBotonera();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ucTitleBar = new ucLibrary.ucTitleBar();
            this.crStocks1 = new MAB.Reports.crStocks();
            this.pnlBG.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlEstadisticas.SuspendLayout();
            this.pnlBodyEstadisticas.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpStockFaltante.SuspendLayout();
            this.pnlTituloEstadisticas.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.pnlBody);
            this.pnlBG.Controls.Add(this.pnlTitulo);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(783, 534);
            this.pnlBG.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlContent);
            this.pnlBody.Controls.Add(this.pnlNavBar);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 25);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(783, 509);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlEstadisticas);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(168, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(615, 509);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlEstadisticas
            // 
            this.pnlEstadisticas.Controls.Add(this.pnlBodyEstadisticas);
            this.pnlEstadisticas.Controls.Add(this.pnlTituloEstadisticas);
            this.pnlEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.pnlEstadisticas.Name = "pnlEstadisticas";
            this.pnlEstadisticas.Size = new System.Drawing.Size(615, 509);
            this.pnlEstadisticas.TabIndex = 2;
            // 
            // pnlBodyEstadisticas
            // 
            this.pnlBodyEstadisticas.Controls.Add(this.tcPrincipal);
            this.pnlBodyEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyEstadisticas.Location = new System.Drawing.Point(0, 25);
            this.pnlBodyEstadisticas.Name = "pnlBodyEstadisticas";
            this.pnlBodyEstadisticas.Size = new System.Drawing.Size(615, 484);
            this.pnlBodyEstadisticas.TabIndex = 1;
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpGeneral);
            this.tcPrincipal.Controls.Add(this.tpOtros);
            this.tcPrincipal.Controls.Add(this.tpStockFaltante);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Multiline = true;
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(615, 484);
            this.tcPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.cclblModeloMasReparado);
            this.tpGeneral.Controls.Add(this.cclblMarcaMasReparada);
            this.tpGeneral.Controls.Add(this.cclblLavarropasConMasReparaciones);
            this.tpGeneral.Controls.Add(this.cclblUltimoLavarropasAgregado);
            this.tpGeneral.Controls.Add(this.cclblTotalLavarropasGuardados);
            this.tpGeneral.Controls.Add(this.ccLabel16);
            this.tpGeneral.Controls.Add(this.ccLabel4);
            this.tpGeneral.Controls.Add(this.ccLabel2);
            this.tpGeneral.Controls.Add(this.ccLabel7);
            this.tpGeneral.Controls.Add(this.ccLabel6);
            this.tpGeneral.Controls.Add(this.cclblClienteConMasLavarropas);
            this.tpGeneral.Controls.Add(this.cclblCliente4);
            this.tpGeneral.Controls.Add(this.cclblClienteConMasReparaciones);
            this.tpGeneral.Controls.Add(this.cclblCliente3);
            this.tpGeneral.Controls.Add(this.cclblUltimoClienteAgregado);
            this.tpGeneral.Controls.Add(this.cclblCliente1);
            this.tpGeneral.Controls.Add(this.cclblTotalClientesGuardados);
            this.tpGeneral.Controls.Add(this.cclblCliente2);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(607, 458);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Generales";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // cclblModeloMasReparado
            // 
            this.cclblModeloMasReparado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblModeloMasReparado.AutoSize = true;
            this.cclblModeloMasReparado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblModeloMasReparado.Location = new System.Drawing.Point(303, 316);
            this.cclblModeloMasReparado.Name = "cclblModeloMasReparado";
            this.cclblModeloMasReparado.Size = new System.Drawing.Size(0, 16);
            this.cclblModeloMasReparado.TabIndex = 23;
            // 
            // cclblMarcaMasReparada
            // 
            this.cclblMarcaMasReparada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblMarcaMasReparada.AutoSize = true;
            this.cclblMarcaMasReparada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarcaMasReparada.Location = new System.Drawing.Point(303, 279);
            this.cclblMarcaMasReparada.Name = "cclblMarcaMasReparada";
            this.cclblMarcaMasReparada.Size = new System.Drawing.Size(0, 16);
            this.cclblMarcaMasReparada.TabIndex = 22;
            // 
            // cclblLavarropasConMasReparaciones
            // 
            this.cclblLavarropasConMasReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblLavarropasConMasReparaciones.AutoSize = true;
            this.cclblLavarropasConMasReparaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblLavarropasConMasReparaciones.Location = new System.Drawing.Point(303, 242);
            this.cclblLavarropasConMasReparaciones.Name = "cclblLavarropasConMasReparaciones";
            this.cclblLavarropasConMasReparaciones.Size = new System.Drawing.Size(0, 16);
            this.cclblLavarropasConMasReparaciones.TabIndex = 21;
            // 
            // cclblUltimoLavarropasAgregado
            // 
            this.cclblUltimoLavarropasAgregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblUltimoLavarropasAgregado.AutoSize = true;
            this.cclblUltimoLavarropasAgregado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblUltimoLavarropasAgregado.Location = new System.Drawing.Point(303, 168);
            this.cclblUltimoLavarropasAgregado.Name = "cclblUltimoLavarropasAgregado";
            this.cclblUltimoLavarropasAgregado.Size = new System.Drawing.Size(0, 16);
            this.cclblUltimoLavarropasAgregado.TabIndex = 20;
            // 
            // cclblTotalLavarropasGuardados
            // 
            this.cclblTotalLavarropasGuardados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblTotalLavarropasGuardados.AutoSize = true;
            this.cclblTotalLavarropasGuardados.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalLavarropasGuardados.Location = new System.Drawing.Point(303, 205);
            this.cclblTotalLavarropasGuardados.Name = "cclblTotalLavarropasGuardados";
            this.cclblTotalLavarropasGuardados.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalLavarropasGuardados.TabIndex = 19;
            // 
            // ccLabel16
            // 
            this.ccLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel16.AutoSize = true;
            this.ccLabel16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel16.Location = new System.Drawing.Point(20, 316);
            this.ccLabel16.Name = "ccLabel16";
            this.ccLabel16.Size = new System.Drawing.Size(147, 16);
            this.ccLabel16.TabIndex = 17;
            this.ccLabel16.Text = "Modelo mas Reparado:";
            // 
            // ccLabel4
            // 
            this.ccLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(20, 279);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(137, 16);
            this.ccLabel4.TabIndex = 16;
            this.ccLabel4.Text = "Marca mas Reparada:";
            // 
            // ccLabel2
            // 
            this.ccLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(20, 242);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(212, 16);
            this.ccLabel2.TabIndex = 15;
            this.ccLabel2.Text = "Lavarropas con mas Reparaciones:";
            // 
            // ccLabel7
            // 
            this.ccLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel7.AutoSize = true;
            this.ccLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel7.Location = new System.Drawing.Point(20, 168);
            this.ccLabel7.Name = "ccLabel7";
            this.ccLabel7.Size = new System.Drawing.Size(181, 16);
            this.ccLabel7.TabIndex = 14;
            this.ccLabel7.Text = "Ultimo Lavarropas Agregado:";
            // 
            // ccLabel6
            // 
            this.ccLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel6.AutoSize = true;
            this.ccLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel6.Location = new System.Drawing.Point(20, 205);
            this.ccLabel6.Name = "ccLabel6";
            this.ccLabel6.Size = new System.Drawing.Size(197, 16);
            this.ccLabel6.TabIndex = 13;
            this.ccLabel6.Text = "Total de Lavarropas Guardados:";
            // 
            // cclblClienteConMasLavarropas
            // 
            this.cclblClienteConMasLavarropas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblClienteConMasLavarropas.AutoSize = true;
            this.cclblClienteConMasLavarropas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblClienteConMasLavarropas.Location = new System.Drawing.Point(303, 131);
            this.cclblClienteConMasLavarropas.Name = "cclblClienteConMasLavarropas";
            this.cclblClienteConMasLavarropas.Size = new System.Drawing.Size(0, 16);
            this.cclblClienteConMasLavarropas.TabIndex = 12;
            // 
            // cclblCliente4
            // 
            this.cclblCliente4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente4.AutoSize = true;
            this.cclblCliente4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente4.Location = new System.Drawing.Point(20, 131);
            this.cclblCliente4.Name = "cclblCliente4";
            this.cclblCliente4.Size = new System.Drawing.Size(172, 16);
            this.cclblCliente4.TabIndex = 11;
            this.cclblCliente4.Text = "Cliente con mas Lavarropas:";
            // 
            // cclblClienteConMasReparaciones
            // 
            this.cclblClienteConMasReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblClienteConMasReparaciones.AutoSize = true;
            this.cclblClienteConMasReparaciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblClienteConMasReparaciones.Location = new System.Drawing.Point(303, 94);
            this.cclblClienteConMasReparaciones.Name = "cclblClienteConMasReparaciones";
            this.cclblClienteConMasReparaciones.Size = new System.Drawing.Size(0, 16);
            this.cclblClienteConMasReparaciones.TabIndex = 10;
            // 
            // cclblCliente3
            // 
            this.cclblCliente3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente3.AutoSize = true;
            this.cclblCliente3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente3.Location = new System.Drawing.Point(20, 94);
            this.cclblCliente3.Name = "cclblCliente3";
            this.cclblCliente3.Size = new System.Drawing.Size(186, 16);
            this.cclblCliente3.TabIndex = 9;
            this.cclblCliente3.Text = "Cliente con mas Reparaciones:";
            // 
            // cclblUltimoClienteAgregado
            // 
            this.cclblUltimoClienteAgregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblUltimoClienteAgregado.AutoSize = true;
            this.cclblUltimoClienteAgregado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblUltimoClienteAgregado.Location = new System.Drawing.Point(303, 20);
            this.cclblUltimoClienteAgregado.Name = "cclblUltimoClienteAgregado";
            this.cclblUltimoClienteAgregado.Size = new System.Drawing.Size(0, 16);
            this.cclblUltimoClienteAgregado.TabIndex = 3;
            // 
            // cclblCliente1
            // 
            this.cclblCliente1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente1.AutoSize = true;
            this.cclblCliente1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente1.Location = new System.Drawing.Point(20, 20);
            this.cclblCliente1.Name = "cclblCliente1";
            this.cclblCliente1.Size = new System.Drawing.Size(155, 16);
            this.cclblCliente1.TabIndex = 2;
            this.cclblCliente1.Text = "Ultimo Cliente Agregado:";
            // 
            // cclblTotalClientesGuardados
            // 
            this.cclblTotalClientesGuardados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblTotalClientesGuardados.AutoSize = true;
            this.cclblTotalClientesGuardados.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalClientesGuardados.Location = new System.Drawing.Point(303, 57);
            this.cclblTotalClientesGuardados.Name = "cclblTotalClientesGuardados";
            this.cclblTotalClientesGuardados.Size = new System.Drawing.Size(0, 16);
            this.cclblTotalClientesGuardados.TabIndex = 1;
            // 
            // cclblCliente2
            // 
            this.cclblCliente2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente2.AutoSize = true;
            this.cclblCliente2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente2.Location = new System.Drawing.Point(20, 57);
            this.cclblCliente2.Name = "cclblCliente2";
            this.cclblCliente2.Size = new System.Drawing.Size(177, 16);
            this.cclblCliente2.TabIndex = 0;
            this.cclblCliente2.Text = "Total de Clientes Guardados:";
            // 
            // tpOtros
            // 
            this.tpOtros.Location = new System.Drawing.Point(4, 22);
            this.tpOtros.Name = "tpOtros";
            this.tpOtros.Padding = new System.Windows.Forms.Padding(3);
            this.tpOtros.Size = new System.Drawing.Size(607, 458);
            this.tpOtros.TabIndex = 2;
            this.tpOtros.Text = "Otros";
            this.tpOtros.UseVisualStyleBackColor = true;
            // 
            // tpStockFaltante
            // 
            this.tpStockFaltante.Controls.Add(this.crvRepuestos);
            this.tpStockFaltante.Location = new System.Drawing.Point(4, 22);
            this.tpStockFaltante.Name = "tpStockFaltante";
            this.tpStockFaltante.Padding = new System.Windows.Forms.Padding(3);
            this.tpStockFaltante.Size = new System.Drawing.Size(607, 458);
            this.tpStockFaltante.TabIndex = 3;
            this.tpStockFaltante.Text = "Stock Faltante";
            this.tpStockFaltante.UseVisualStyleBackColor = true;
            // 
            // crvRepuestos
            // 
            this.crvRepuestos.ActiveViewIndex = -1;
            this.crvRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepuestos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepuestos.Location = new System.Drawing.Point(3, 3);
            this.crvRepuestos.Name = "crvRepuestos";
            this.crvRepuestos.ShowCloseButton = false;
            this.crvRepuestos.ShowCopyButton = false;
            this.crvRepuestos.ShowGotoPageButton = false;
            this.crvRepuestos.ShowPageNavigateButtons = false;
            this.crvRepuestos.ShowParameterPanelButton = false;
            this.crvRepuestos.ShowRefreshButton = false;
            this.crvRepuestos.Size = new System.Drawing.Size(601, 452);
            this.crvRepuestos.TabIndex = 6;
            this.crvRepuestos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlTituloEstadisticas
            // 
            this.pnlTituloEstadisticas.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTituloEstadisticas.Controls.Add(this.ccLabel1);
            this.pnlTituloEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloEstadisticas.Name = "pnlTituloEstadisticas";
            this.pnlTituloEstadisticas.Size = new System.Drawing.Size(615, 25);
            this.pnlTituloEstadisticas.TabIndex = 0;
            // 
            // ccLabel1
            // 
            this.ccLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel1.AutoSize = true;
            this.ccLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel1.Location = new System.Drawing.Point(6, 4);
            this.ccLabel1.Name = "ccLabel1";
            this.ccLabel1.Size = new System.Drawing.Size(75, 16);
            this.ccLabel1.TabIndex = 0;
            this.ccLabel1.Text = "Estadisticas";
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlNavBar.Controls.Add(this.ucBotonera);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(168, 509);
            this.pnlNavBar.TabIndex = 0;
            // 
            // ucBotonera
            // 
            this.ucBotonera.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ucBotonera.BotonInicial = 0;
            this.ucBotonera.btnAccion1 = "Accion 1";
            this.ucBotonera.btnAccion2 = "Accion 2";
            this.ucBotonera.btnAccion3 = "Accion 3";
            this.ucBotonera.btnAccion4 = "Accion 4";
            this.ucBotonera.btnAccion5 = "Accion 5";
            this.ucBotonera.btnAccion6 = "Accion 6";
            this.ucBotonera.btnAccion7 = "Accion 7";
            this.ucBotonera.ColorAlternativo = System.Drawing.Color.Empty;
            this.ucBotonera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBotonera.Location = new System.Drawing.Point(0, 0);
            this.ucBotonera.Name = "ucBotonera";
            this.ucBotonera.NumBotones = 0;
            this.ucBotonera.Size = new System.Drawing.Size(168, 509);
            this.ucBotonera.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitulo.Controls.Add(this.ucTitleBar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(783, 25);
            this.pnlTitulo.TabIndex = 0;
            // 
            // ucTitleBar
            // 
            this.ucTitleBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTitleBar.ButtonsBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTitleBar.ButtonsForeColor = System.Drawing.Color.WhiteSmoke;
            this.ucTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTitleBar.Location = new System.Drawing.Point(0, 0);
            this.ucTitleBar.MinimumSize = new System.Drawing.Size(180, 25);
            this.ucTitleBar.Name = "ucTitleBar";
            this.ucTitleBar.Size = new System.Drawing.Size(783, 25);
            this.ucTitleBar.TabIndex = 1;
            this.ucTitleBar.TitleAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 534);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBG);
            this.DoubleBuffered = true;
            this.Name = "frmInicio";
            this.pnlBG.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlEstadisticas.ResumeLayout(false);
            this.pnlBodyEstadisticas.ResumeLayout(false);
            this.tcPrincipal.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpStockFaltante.ResumeLayout(false);
            this.pnlTituloEstadisticas.ResumeLayout(false);
            this.pnlTituloEstadisticas.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNavBar;
        private ucLibrary.ucBotonera ucBotonera;
        private ucLibrary.ucTitleBar ucTitleBar;
        private System.Windows.Forms.Panel pnlBodyEstadisticas;
        private System.Windows.Forms.Panel pnlTituloEstadisticas;
        private ccLibrary.ccLabel ccLabel1;
        private System.Windows.Forms.Panel pnlEstadisticas;
        private Reports.crStocks crStocks1;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpGeneral;
        private ccLibrary.ccLabel ccLabel16;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel7;
        private ccLibrary.ccLabel ccLabel6;
        private ccLibrary.ccLabel cclblClienteConMasLavarropas;
        private ccLibrary.ccLabel cclblCliente4;
        private ccLibrary.ccLabel cclblClienteConMasReparaciones;
        private ccLibrary.ccLabel cclblCliente3;
        private ccLibrary.ccLabel cclblUltimoClienteAgregado;
        private ccLibrary.ccLabel cclblCliente1;
        private ccLibrary.ccLabel cclblTotalClientesGuardados;
        private ccLibrary.ccLabel cclblCliente2;
        private System.Windows.Forms.TabPage tpOtros;
        private System.Windows.Forms.TabPage tpStockFaltante;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepuestos;
        private ccLibrary.ccLabel cclblModeloMasReparado;
        private ccLibrary.ccLabel cclblMarcaMasReparada;
        private ccLibrary.ccLabel cclblLavarropasConMasReparaciones;
        private ccLibrary.ccLabel cclblUltimoLavarropasAgregado;
        private ccLibrary.ccLabel cclblTotalLavarropasGuardados;
    }
}