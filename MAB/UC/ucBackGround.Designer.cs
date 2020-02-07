namespace MAB.UC
{
    partial class ucBackGround
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.ucBottom = new ucLibrary.ucBottom();
            this.ucTop = new ucLibrary.ucTop();
            this.pnlBG.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.pnlBody);
            this.pnlBG.Controls.Add(this.ucBottom);
            this.pnlBG.Controls.Add(this.ucTop);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(737, 474);
            this.pnlBG.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvPrincipal);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 82);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(737, 310);
            this.pnlBody.TabIndex = 3;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.NullValue = null;
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPrincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersVisible = false;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(737, 310);
            this.dgvPrincipal.TabIndex = 5;
            // 
            // ucBottom
            // 
            this.ucBottom.Accion1 = null;
            this.ucBottom.Accion2 = null;
            this.ucBottom.Accion3 = null;
            this.ucBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBottom.Location = new System.Drawing.Point(0, 392);
            this.ucBottom.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucBottom.Name = "ucBottom";
            this.ucBottom.NumButtons = 0;
            this.ucBottom.Size = new System.Drawing.Size(737, 82);
            this.ucBottom.TabIndex = 5;
            // 
            // ucTop
            // 
            this.ucTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTop.Location = new System.Drawing.Point(0, 0);
            this.ucTop.MaximumSize = new System.Drawing.Size(3840, 82);
            this.ucTop.Name = "ucTop";
            this.ucTop.Size = new System.Drawing.Size(737, 82);
            this.ucTop.TabIndex = 5;
            this.ucTop.Titulo = null;
            // 
            // ucBackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBG);
            this.Name = "ucBackGround";
            this.Size = new System.Drawing.Size(737, 474);
            this.pnlBG.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Panel pnlBody;
        private ucLibrary.ucTop ucTop;
        private ucLibrary.ucBottom ucBottom;
        private System.Windows.Forms.DataGridView dgvPrincipal;
    }
}
