﻿namespace MAB.Forms.CRUD.Reparaciones
{
    partial class frmModificarReparacion
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
            this.ucTop = new ucLibrary.ucTop();
            this.ucBottom = new ucLibrary.ucBottom();
            this.cclblFechaIngreso = new ccLibrary.ccLabel();
            this.cclblFechaEgreso = new ccLibrary.ccLabel();
            this.cclblErrorReparar = new ccLibrary.ccLabel();
            this.cclblEstadoReparacion = new ccLibrary.ccLabel();
            this.cclblMesesGarantia = new ccLibrary.ccLabel();
            this.cclblReparacionRealizada = new ccLibrary.ccLabel();
            this.cclblManoObra = new ccLibrary.ccLabel();
            this.cclblTotalRepuestos = new ccLibrary.ccLabel();
            this.cclblLavarropa = new ccLibrary.ccLabel();
            this.cclblTotal = new ccLibrary.ccLabel();
            this.cclblValorTotal = new ccLibrary.ccLabel();
            this.cctbFallaAReparar = new ccLibrary.ccTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cclblMarcaModelo = new ccLibrary.ccLabel();
            this.cboEstadoReparacion = new System.Windows.Forms.ComboBox();
            this.cctbReparacionRealizada = new ccLibrary.ccTextBox();
            this.cctbManoObra = new ccLibrary.ccTextBox();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.cctbValorRepuestos = new ccLibrary.ccTextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.nudGarantia = new System.Windows.Forms.NumericUpDown();
            this.dtpGarantia = new System.Windows.Forms.DateTimePicker();
            this.cclblFinaliza = new ccLibrary.ccLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudGarantia)).BeginInit();
            this.SuspendLayout();
            // 
            // ucTop
            // 
            this.ucTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTop.Location = new System.Drawing.Point(0, 0);
            this.ucTop.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucTop.Name = "ucTop";
            this.ucTop.Size = new System.Drawing.Size(780, 82);
            this.ucTop.TabIndex = 0;
            this.ucTop.Titulo = null;
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 364);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(780, 82);
            this.ucBottom.TabIndex = 1;
            // 
            // cclblFechaIngreso
            // 
            this.cclblFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFechaIngreso.AutoSize = true;
            this.cclblFechaIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFechaIngreso.Location = new System.Drawing.Point(65, 164);
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
            this.cclblFechaEgreso.Location = new System.Drawing.Point(65, 317);
            this.cclblFechaEgreso.Name = "cclblFechaEgreso";
            this.cclblFechaEgreso.Size = new System.Drawing.Size(105, 16);
            this.cclblFechaEgreso.TabIndex = 3;
            this.cclblFechaEgreso.Text = "Fecha de Egreso";
            // 
            // cclblErrorReparar
            // 
            this.cclblErrorReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblErrorReparar.AutoSize = true;
            this.cclblErrorReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblErrorReparar.Location = new System.Drawing.Point(385, 164);
            this.cclblErrorReparar.Name = "cclblErrorReparar";
            this.cclblErrorReparar.Size = new System.Drawing.Size(96, 16);
            this.cclblErrorReparar.TabIndex = 4;
            this.cclblErrorReparar.Text = "Falla a Reparar";
            // 
            // cclblEstadoReparacion
            // 
            this.cclblEstadoReparacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblEstadoReparacion.AutoSize = true;
            this.cclblEstadoReparacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblEstadoReparacion.Location = new System.Drawing.Point(403, 113);
            this.cclblEstadoReparacion.Name = "cclblEstadoReparacion";
            this.cclblEstadoReparacion.Size = new System.Drawing.Size(151, 16);
            this.cclblEstadoReparacion.TabIndex = 5;
            this.cclblEstadoReparacion.Text = "Estado de la Reparacion";
            // 
            // cclblMesesGarantia
            // 
            this.cclblMesesGarantia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMesesGarantia.AutoSize = true;
            this.cclblMesesGarantia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMesesGarantia.Location = new System.Drawing.Point(382, 317);
            this.cclblMesesGarantia.Name = "cclblMesesGarantia";
            this.cclblMesesGarantia.Size = new System.Drawing.Size(118, 16);
            this.cclblMesesGarantia.TabIndex = 6;
            this.cclblMesesGarantia.Text = "Meses de Garantia";
            // 
            // cclblReparacionRealizada
            // 
            this.cclblReparacionRealizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblReparacionRealizada.AutoSize = true;
            this.cclblReparacionRealizada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblReparacionRealizada.Location = new System.Drawing.Point(65, 215);
            this.cclblReparacionRealizada.Name = "cclblReparacionRealizada";
            this.cclblReparacionRealizada.Size = new System.Drawing.Size(134, 16);
            this.cclblReparacionRealizada.TabIndex = 7;
            this.cclblReparacionRealizada.Text = "Reparacion Realizada";
            // 
            // cclblManoObra
            // 
            this.cclblManoObra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblManoObra.AutoSize = true;
            this.cclblManoObra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblManoObra.Location = new System.Drawing.Point(65, 266);
            this.cclblManoObra.Name = "cclblManoObra";
            this.cclblManoObra.Size = new System.Drawing.Size(95, 16);
            this.cclblManoObra.TabIndex = 8;
            this.cclblManoObra.Text = "Mano de Obra";
            // 
            // cclblTotalRepuestos
            // 
            this.cclblTotalRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTotalRepuestos.AutoSize = true;
            this.cclblTotalRepuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotalRepuestos.Location = new System.Drawing.Point(322, 266);
            this.cclblTotalRepuestos.Name = "cclblTotalRepuestos";
            this.cclblTotalRepuestos.Size = new System.Drawing.Size(121, 16);
            this.cclblTotalRepuestos.TabIndex = 9;
            this.cclblTotalRepuestos.Text = "Total de Repuestos";
            // 
            // cclblLavarropa
            // 
            this.cclblLavarropa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblLavarropa.AutoSize = true;
            this.cclblLavarropa.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblLavarropa.Location = new System.Drawing.Point(65, 113);
            this.cclblLavarropa.Name = "cclblLavarropa";
            this.cclblLavarropa.Size = new System.Drawing.Size(73, 16);
            this.cclblLavarropa.TabIndex = 10;
            this.cclblLavarropa.Text = "Lavarropas";
            // 
            // cclblTotal
            // 
            this.cclblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblTotal.AutoSize = true;
            this.cclblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblTotal.Location = new System.Drawing.Point(642, 266);
            this.cclblTotal.Name = "cclblTotal";
            this.cclblTotal.Size = new System.Drawing.Size(40, 16);
            this.cclblTotal.TabIndex = 11;
            this.cclblTotal.Text = "Total:";
            // 
            // cclblValorTotal
            // 
            this.cclblValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblValorTotal.AutoSize = true;
            this.cclblValorTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblValorTotal.Location = new System.Drawing.Point(688, 266);
            this.cclblValorTotal.Name = "cclblValorTotal";
            this.cclblValorTotal.Size = new System.Drawing.Size(15, 16);
            this.cclblValorTotal.TabIndex = 12;
            this.cclblValorTotal.Text = "0";
            // 
            // cctbFallaAReparar
            // 
            this.cctbFallaAReparar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbFallaAReparar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbFallaAReparar.Location = new System.Drawing.Point(486, 161);
            this.cctbFallaAReparar.Name = "cctbFallaAReparar";
            this.cctbFallaAReparar.Size = new System.Drawing.Size(231, 24);
            this.cctbFallaAReparar.TabIndex = 13;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(179, 160);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 14;
            // 
            // cclblMarcaModelo
            // 
            this.cclblMarcaModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblMarcaModelo.AutoSize = true;
            this.cclblMarcaModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblMarcaModelo.Location = new System.Drawing.Point(144, 113);
            this.cclblMarcaModelo.Name = "cclblMarcaModelo";
            this.cclblMarcaModelo.Size = new System.Drawing.Size(0, 16);
            this.cclblMarcaModelo.TabIndex = 15;
            // 
            // cboEstadoReparacion
            // 
            this.cboEstadoReparacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstadoReparacion.FormattingEnabled = true;
            this.cboEstadoReparacion.Location = new System.Drawing.Point(560, 111);
            this.cboEstadoReparacion.Name = "cboEstadoReparacion";
            this.cboEstadoReparacion.Size = new System.Drawing.Size(157, 21);
            this.cboEstadoReparacion.TabIndex = 16;
            // 
            // cctbReparacionRealizada
            // 
            this.cctbReparacionRealizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbReparacionRealizada.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbReparacionRealizada.Location = new System.Drawing.Point(205, 212);
            this.cctbReparacionRealizada.Name = "cctbReparacionRealizada";
            this.cctbReparacionRealizada.Size = new System.Drawing.Size(512, 24);
            this.cctbReparacionRealizada.TabIndex = 17;
            // 
            // cctbManoObra
            // 
            this.cctbManoObra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbManoObra.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbManoObra.Location = new System.Drawing.Point(163, 263);
            this.cctbManoObra.Name = "cctbManoObra";
            this.cctbManoObra.Size = new System.Drawing.Size(153, 24);
            this.cctbManoObra.TabIndex = 18;
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Location = new System.Drawing.Point(173, 313);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaEgreso.TabIndex = 19;
            // 
            // cctbValorRepuestos
            // 
            this.cctbValorRepuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cctbValorRepuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cctbValorRepuestos.Location = new System.Drawing.Point(449, 263);
            this.cctbValorRepuestos.Name = "cctbValorRepuestos";
            this.cctbValorRepuestos.Size = new System.Drawing.Size(187, 24);
            this.cctbValorRepuestos.TabIndex = 20;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(322, 109);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 22;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            // 
            // nudGarantia
            // 
            this.nudGarantia.Location = new System.Drawing.Point(506, 316);
            this.nudGarantia.Name = "nudGarantia";
            this.nudGarantia.Size = new System.Drawing.Size(48, 20);
            this.nudGarantia.TabIndex = 23;
            // 
            // dtpGarantia
            // 
            this.dtpGarantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGarantia.Location = new System.Drawing.Point(619, 312);
            this.dtpGarantia.Name = "dtpGarantia";
            this.dtpGarantia.Size = new System.Drawing.Size(98, 20);
            this.dtpGarantia.TabIndex = 24;
            // 
            // cclblFinaliza
            // 
            this.cclblFinaliza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cclblFinaliza.AutoSize = true;
            this.cclblFinaliza.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.cclblFinaliza.Location = new System.Drawing.Point(560, 317);
            this.cclblFinaliza.Name = "cclblFinaliza";
            this.cclblFinaliza.Size = new System.Drawing.Size(53, 16);
            this.cclblFinaliza.TabIndex = 25;
            this.cclblFinaliza.Text = "Finaliza:";
            // 
            // frmModificarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 446);
            this.Controls.Add(this.cclblFinaliza);
            this.Controls.Add(this.dtpGarantia);
            this.Controls.Add(this.nudGarantia);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.cctbValorRepuestos);
            this.Controls.Add(this.dtpFechaEgreso);
            this.Controls.Add(this.cctbManoObra);
            this.Controls.Add(this.cctbReparacionRealizada);
            this.Controls.Add(this.cboEstadoReparacion);
            this.Controls.Add(this.cclblMarcaModelo);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.cctbFallaAReparar);
            this.Controls.Add(this.cclblValorTotal);
            this.Controls.Add(this.cclblTotal);
            this.Controls.Add(this.cclblLavarropa);
            this.Controls.Add(this.cclblTotalRepuestos);
            this.Controls.Add(this.cclblManoObra);
            this.Controls.Add(this.cclblReparacionRealizada);
            this.Controls.Add(this.cclblMesesGarantia);
            this.Controls.Add(this.cclblEstadoReparacion);
            this.Controls.Add(this.cclblErrorReparar);
            this.Controls.Add(this.cclblFechaEgreso);
            this.Controls.Add(this.cclblFechaIngreso);
            this.Controls.Add(this.ucBottom);
            this.Controls.Add(this.ucTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarReparacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmModificarReparacion";
            ((System.ComponentModel.ISupportInitialize)(this.nudGarantia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucLibrary.ucTop ucTop;
        private ucLibrary.ucBottom ucBottom;
        private ccLibrary.ccLabel cclblFechaIngreso;
        private ccLibrary.ccLabel cclblFechaEgreso;
        private ccLibrary.ccLabel cclblErrorReparar;
        private ccLibrary.ccLabel cclblEstadoReparacion;
        private ccLibrary.ccLabel cclblMesesGarantia;
        private ccLibrary.ccLabel cclblReparacionRealizada;
        private ccLibrary.ccLabel cclblManoObra;
        private ccLibrary.ccLabel cclblTotalRepuestos;
        private ccLibrary.ccLabel cclblLavarropa;
        private ccLibrary.ccLabel cclblTotal;
        private ccLibrary.ccLabel cclblValorTotal;
        private ccLibrary.ccTextBox cctbFallaAReparar;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private ccLibrary.ccLabel cclblMarcaModelo;
        private System.Windows.Forms.ComboBox cboEstadoReparacion;
        private ccLibrary.ccTextBox cctbReparacionRealizada;
        private ccLibrary.ccTextBox cctbManoObra;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private ccLibrary.ccTextBox cctbValorRepuestos;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.NumericUpDown nudGarantia;
        private System.Windows.Forms.DateTimePicker dtpGarantia;
        private ccLibrary.ccLabel cclblFinaliza;
    }
}