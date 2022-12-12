namespace MAB.Forms.Entregas
{
    partial class frmComprobanteDeRecibo
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
            this.crvComprobanteDeRecibo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvComprobanteDeRecibo
            // 
            this.crvComprobanteDeRecibo.ActiveViewIndex = -1;
            this.crvComprobanteDeRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvComprobanteDeRecibo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvComprobanteDeRecibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvComprobanteDeRecibo.Location = new System.Drawing.Point(0, 0);
            this.crvComprobanteDeRecibo.Name = "crvComprobanteDeRecibo";
            this.crvComprobanteDeRecibo.ShowCloseButton = false;
            this.crvComprobanteDeRecibo.ShowCopyButton = false;
            this.crvComprobanteDeRecibo.ShowGotoPageButton = false;
            this.crvComprobanteDeRecibo.ShowPageNavigateButtons = false;
            this.crvComprobanteDeRecibo.ShowParameterPanelButton = false;
            this.crvComprobanteDeRecibo.ShowRefreshButton = false;
            this.crvComprobanteDeRecibo.Size = new System.Drawing.Size(675, 372);
            this.crvComprobanteDeRecibo.TabIndex = 7;
            this.crvComprobanteDeRecibo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmComprobanteDeRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 372);
            this.Controls.Add(this.crvComprobanteDeRecibo);
            this.MinimizeBox = false;
            this.Name = "frmComprobanteDeRecibo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comprobante de Recibo";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvComprobanteDeRecibo;
    }
}