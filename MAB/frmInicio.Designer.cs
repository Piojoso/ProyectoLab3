﻿namespace MAB.Forms
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
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.ccLabel15 = new ccLibrary.ccLabel();
            this.cclblCliente4 = new ccLibrary.ccLabel();
            this.ccLabel20 = new ccLibrary.ccLabel();
            this.cclblCliente3 = new ccLibrary.ccLabel();
            this.ccLabel5 = new ccLibrary.ccLabel();
            this.cclblCliente1 = new ccLibrary.ccLabel();
            this.ccLabel3 = new ccLibrary.ccLabel();
            this.cclblCliente2 = new ccLibrary.ccLabel();
            this.tpLavarropas = new System.Windows.Forms.TabPage();
            this.ccLabel8 = new ccLibrary.ccLabel();
            this.ccLabel16 = new ccLibrary.ccLabel();
            this.ccLabel4 = new ccLibrary.ccLabel();
            this.ccLabel2 = new ccLibrary.ccLabel();
            this.ccLabel7 = new ccLibrary.ccLabel();
            this.ccLabel6 = new ccLibrary.ccLabel();
            this.tpReparaciones = new System.Windows.Forms.TabPage();
            this.tpStock = new System.Windows.Forms.TabPage();
            this.ccLabel14 = new ccLibrary.ccLabel();
            this.ccLabel13 = new ccLibrary.ccLabel();
            this.pnlTituloEstadisticas = new System.Windows.Forms.Panel();
            this.ccLabel1 = new ccLibrary.ccLabel();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.ucBotonera = new ucLibrary.ucBotonera();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ucTitleBar = new ucLibrary.ucTitleBar();
            this.pnlBG.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlEstadisticas.SuspendLayout();
            this.pnlBodyEstadisticas.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.tpLavarropas.SuspendLayout();
            this.tpStock.SuspendLayout();
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
            this.tcPrincipal.Controls.Add(this.tpClientes);
            this.tcPrincipal.Controls.Add(this.tpLavarropas);
            this.tcPrincipal.Controls.Add(this.tpReparaciones);
            this.tcPrincipal.Controls.Add(this.tpStock);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Multiline = true;
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(615, 484);
            this.tcPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.ccLabel15);
            this.tpClientes.Controls.Add(this.cclblCliente4);
            this.tpClientes.Controls.Add(this.ccLabel20);
            this.tpClientes.Controls.Add(this.cclblCliente3);
            this.tpClientes.Controls.Add(this.ccLabel5);
            this.tpClientes.Controls.Add(this.cclblCliente1);
            this.tpClientes.Controls.Add(this.ccLabel3);
            this.tpClientes.Controls.Add(this.cclblCliente2);
            this.tpClientes.Location = new System.Drawing.Point(4, 22);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(607, 458);
            this.tpClientes.TabIndex = 0;
            this.tpClientes.Text = "Clientes";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // ccLabel15
            // 
            this.ccLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel15.AutoSize = true;
            this.ccLabel15.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel15.Location = new System.Drawing.Point(364, 133);
            this.ccLabel15.Name = "ccLabel15";
            this.ccLabel15.Size = new System.Drawing.Size(65, 16);
            this.ccLabel15.TabIndex = 12;
            this.ccLabel15.Text = "ccLabel15";
            // 
            // cclblCliente4
            // 
            this.cclblCliente4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente4.AutoSize = true;
            this.cclblCliente4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente4.Location = new System.Drawing.Point(20, 131);
            this.cclblCliente4.Name = "cclblCliente4";
            this.cclblCliente4.Size = new System.Drawing.Size(169, 16);
            this.cclblCliente4.TabIndex = 11;
            this.cclblCliente4.Text = "Cliente con mas Lavarropas";
            // 
            // ccLabel20
            // 
            this.ccLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel20.AutoSize = true;
            this.ccLabel20.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel20.Location = new System.Drawing.Point(364, 96);
            this.ccLabel20.Name = "ccLabel20";
            this.ccLabel20.Size = new System.Drawing.Size(65, 16);
            this.ccLabel20.TabIndex = 10;
            this.ccLabel20.Text = "ccLabel20";
            // 
            // cclblCliente3
            // 
            this.cclblCliente3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente3.AutoSize = true;
            this.cclblCliente3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente3.Location = new System.Drawing.Point(20, 94);
            this.cclblCliente3.Name = "cclblCliente3";
            this.cclblCliente3.Size = new System.Drawing.Size(183, 16);
            this.cclblCliente3.TabIndex = 9;
            this.cclblCliente3.Text = "Cliente con mas Reparaciones";
            // 
            // ccLabel5
            // 
            this.ccLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel5.AutoSize = true;
            this.ccLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel5.Location = new System.Drawing.Point(364, 22);
            this.ccLabel5.Name = "ccLabel5";
            this.ccLabel5.Size = new System.Drawing.Size(58, 16);
            this.ccLabel5.TabIndex = 3;
            this.ccLabel5.Text = "ccLabel5";
            // 
            // cclblCliente1
            // 
            this.cclblCliente1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente1.AutoSize = true;
            this.cclblCliente1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente1.Location = new System.Drawing.Point(20, 20);
            this.cclblCliente1.Name = "cclblCliente1";
            this.cclblCliente1.Size = new System.Drawing.Size(152, 16);
            this.cclblCliente1.TabIndex = 2;
            this.cclblCliente1.Text = "Ultimo Cliente Agregado";
            // 
            // ccLabel3
            // 
            this.ccLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ccLabel3.AutoSize = true;
            this.ccLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel3.Location = new System.Drawing.Point(364, 59);
            this.ccLabel3.Name = "ccLabel3";
            this.ccLabel3.Size = new System.Drawing.Size(58, 16);
            this.ccLabel3.TabIndex = 1;
            this.ccLabel3.Text = "ccLabel3";
            // 
            // cclblCliente2
            // 
            this.cclblCliente2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cclblCliente2.AutoSize = true;
            this.cclblCliente2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblCliente2.Location = new System.Drawing.Point(20, 57);
            this.cclblCliente2.Name = "cclblCliente2";
            this.cclblCliente2.Size = new System.Drawing.Size(174, 16);
            this.cclblCliente2.TabIndex = 0;
            this.cclblCliente2.Text = "Total de Clientes Guardados";
            // 
            // tpLavarropas
            // 
            this.tpLavarropas.Controls.Add(this.ccLabel8);
            this.tpLavarropas.Controls.Add(this.ccLabel16);
            this.tpLavarropas.Controls.Add(this.ccLabel4);
            this.tpLavarropas.Controls.Add(this.ccLabel2);
            this.tpLavarropas.Controls.Add(this.ccLabel7);
            this.tpLavarropas.Controls.Add(this.ccLabel6);
            this.tpLavarropas.Location = new System.Drawing.Point(4, 22);
            this.tpLavarropas.Name = "tpLavarropas";
            this.tpLavarropas.Padding = new System.Windows.Forms.Padding(3);
            this.tpLavarropas.Size = new System.Drawing.Size(607, 458);
            this.tpLavarropas.TabIndex = 1;
            this.tpLavarropas.Text = "Lavarropas";
            this.tpLavarropas.UseVisualStyleBackColor = true;
            // 
            // ccLabel8
            // 
            this.ccLabel8.AutoSize = true;
            this.ccLabel8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel8.Location = new System.Drawing.Point(20, 205);
            this.ccLabel8.Name = "ccLabel8";
            this.ccLabel8.Size = new System.Drawing.Size(227, 16);
            this.ccLabel8.TabIndex = 5;
            this.ccLabel8.Text = "Lavarropas actualmente con garantia:";
            // 
            // ccLabel16
            // 
            this.ccLabel16.AutoSize = true;
            this.ccLabel16.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel16.Location = new System.Drawing.Point(20, 168);
            this.ccLabel16.Name = "ccLabel16";
            this.ccLabel16.Size = new System.Drawing.Size(144, 16);
            this.ccLabel16.TabIndex = 4;
            this.ccLabel16.Text = "Modelo mas Reparado";
            // 
            // ccLabel4
            // 
            this.ccLabel4.AutoSize = true;
            this.ccLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel4.Location = new System.Drawing.Point(20, 131);
            this.ccLabel4.Name = "ccLabel4";
            this.ccLabel4.Size = new System.Drawing.Size(134, 16);
            this.ccLabel4.TabIndex = 3;
            this.ccLabel4.Text = "Marca mas Reparada";
            // 
            // ccLabel2
            // 
            this.ccLabel2.AutoSize = true;
            this.ccLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel2.Location = new System.Drawing.Point(20, 94);
            this.ccLabel2.Name = "ccLabel2";
            this.ccLabel2.Size = new System.Drawing.Size(209, 16);
            this.ccLabel2.TabIndex = 2;
            this.ccLabel2.Text = "Lavarropas con mas Reparaciones";
            // 
            // ccLabel7
            // 
            this.ccLabel7.AutoSize = true;
            this.ccLabel7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel7.Location = new System.Drawing.Point(20, 20);
            this.ccLabel7.Name = "ccLabel7";
            this.ccLabel7.Size = new System.Drawing.Size(178, 16);
            this.ccLabel7.TabIndex = 1;
            this.ccLabel7.Text = "Ultimo Lavarropas Agregado";
            // 
            // ccLabel6
            // 
            this.ccLabel6.AutoSize = true;
            this.ccLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel6.Location = new System.Drawing.Point(20, 57);
            this.ccLabel6.Name = "ccLabel6";
            this.ccLabel6.Size = new System.Drawing.Size(194, 16);
            this.ccLabel6.TabIndex = 0;
            this.ccLabel6.Text = "Total de Lavarropas Guardados";
            // 
            // tpReparaciones
            // 
            this.tpReparaciones.Location = new System.Drawing.Point(4, 22);
            this.tpReparaciones.Name = "tpReparaciones";
            this.tpReparaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpReparaciones.Size = new System.Drawing.Size(607, 458);
            this.tpReparaciones.TabIndex = 2;
            this.tpReparaciones.Text = "Reparaciones";
            this.tpReparaciones.UseVisualStyleBackColor = true;
            // 
            // tpStock
            // 
            this.tpStock.Controls.Add(this.ccLabel14);
            this.tpStock.Controls.Add(this.ccLabel13);
            this.tpStock.Location = new System.Drawing.Point(4, 22);
            this.tpStock.Name = "tpStock";
            this.tpStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpStock.Size = new System.Drawing.Size(607, 458);
            this.tpStock.TabIndex = 3;
            this.tpStock.Text = "Stock";
            this.tpStock.UseVisualStyleBackColor = true;
            // 
            // ccLabel14
            // 
            this.ccLabel14.AutoSize = true;
            this.ccLabel14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel14.Location = new System.Drawing.Point(20, 57);
            this.ccLabel14.Name = "ccLabel14";
            this.ccLabel14.Size = new System.Drawing.Size(65, 16);
            this.ccLabel14.TabIndex = 5;
            this.ccLabel14.Text = "ccLabel14";
            // 
            // ccLabel13
            // 
            this.ccLabel13.AutoSize = true;
            this.ccLabel13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.ccLabel13.Location = new System.Drawing.Point(20, 22);
            this.ccLabel13.Name = "ccLabel13";
            this.ccLabel13.Size = new System.Drawing.Size(65, 16);
            this.ccLabel13.TabIndex = 0;
            this.ccLabel13.Text = "ccLabel13";
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
            this.tpClientes.ResumeLayout(false);
            this.tpClientes.PerformLayout();
            this.tpLavarropas.ResumeLayout(false);
            this.tpLavarropas.PerformLayout();
            this.tpStock.ResumeLayout(false);
            this.tpStock.PerformLayout();
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
        private ccLibrary.ccLabel ccLabel5;
        private ccLibrary.ccLabel cclblCliente1;
        private ccLibrary.ccLabel ccLabel3;
        private ccLibrary.ccLabel cclblCliente2;
        private ccLibrary.ccLabel ccLabel7;
        private ccLibrary.ccLabel ccLabel6;
        private ccLibrary.ccLabel ccLabel13;
        private ccLibrary.ccLabel ccLabel14;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabPage tpLavarropas;
        private System.Windows.Forms.TabPage tpReparaciones;
        private System.Windows.Forms.TabPage tpStock;
        private ccLibrary.ccLabel ccLabel20;
        private ccLibrary.ccLabel cclblCliente3;
        private ccLibrary.ccLabel ccLabel15;
        private ccLibrary.ccLabel cclblCliente4;
        private ccLibrary.ccLabel ccLabel2;
        private ccLibrary.ccLabel ccLabel16;
        private ccLibrary.ccLabel ccLabel4;
        private ccLibrary.ccLabel ccLabel8;
    }
}