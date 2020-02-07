namespace ucLibrary
{
    partial class ucBottom
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAccion2 = new System.Windows.Forms.Panel();
            this.btnAccion2 = new System.Windows.Forms.Button();
            this.pnlAccion3 = new System.Windows.Forms.Panel();
            this.btnAccion3 = new System.Windows.Forms.Button();
            this.pnlAccion1 = new System.Windows.Forms.Panel();
            this.btnAccion1 = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.pnlAccion2.SuspendLayout();
            this.pnlAccion3.SuspendLayout();
            this.pnlAccion1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlBottom.Controls.Add(this.pnlAccion2);
            this.pnlBottom.Controls.Add(this.pnlAccion3);
            this.pnlBottom.Controls.Add(this.pnlAccion1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(737, 82);
            this.pnlBottom.TabIndex = 6;
            // 
            // pnlAccion2
            // 
            this.pnlAccion2.Controls.Add(this.btnAccion2);
            this.pnlAccion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccion2.Location = new System.Drawing.Point(246, 0);
            this.pnlAccion2.Name = "pnlAccion2";
            this.pnlAccion2.Size = new System.Drawing.Size(245, 82);
            this.pnlAccion2.TabIndex = 8;
            // 
            // btnAccion2
            // 
            this.btnAccion2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion2.Location = new System.Drawing.Point(84, 29);
            this.btnAccion2.Name = "btnAccion2";
            this.btnAccion2.Size = new System.Drawing.Size(77, 25);
            this.btnAccion2.TabIndex = 9;
            this.btnAccion2.Text = "Accion 2";
            this.btnAccion2.UseVisualStyleBackColor = true;
            this.btnAccion2.Click += new System.EventHandler(this.btnAccion2_Click);
            // 
            // pnlAccion3
            // 
            this.pnlAccion3.Controls.Add(this.btnAccion3);
            this.pnlAccion3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAccion3.Location = new System.Drawing.Point(491, 0);
            this.pnlAccion3.Name = "pnlAccion3";
            this.pnlAccion3.Size = new System.Drawing.Size(246, 82);
            this.pnlAccion3.TabIndex = 10;
            // 
            // btnAccion3
            // 
            this.btnAccion3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAccion3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAccion3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAccion3.Location = new System.Drawing.Point(85, 29);
            this.btnAccion3.Name = "btnAccion3";
            this.btnAccion3.Size = new System.Drawing.Size(77, 25);
            this.btnAccion3.TabIndex = 11;
            this.btnAccion3.Text = "Accion 3";
            this.btnAccion3.UseVisualStyleBackColor = true;
            this.btnAccion3.Click += new System.EventHandler(this.btnAccion3_Click);
            // 
            // pnlAccion1
            // 
            this.pnlAccion1.Controls.Add(this.btnAccion1);
            this.pnlAccion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccion1.Location = new System.Drawing.Point(0, 0);
            this.pnlAccion1.Name = "pnlAccion1";
            this.pnlAccion1.Size = new System.Drawing.Size(246, 82);
            this.pnlAccion1.TabIndex = 6;
            // 
            // btnAccion1
            // 
            this.btnAccion1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion1.Location = new System.Drawing.Point(85, 29);
            this.btnAccion1.Name = "btnAccion1";
            this.btnAccion1.Size = new System.Drawing.Size(77, 25);
            this.btnAccion1.TabIndex = 7;
            this.btnAccion1.Text = "Accion 1";
            this.btnAccion1.UseVisualStyleBackColor = true;
            this.btnAccion1.Click += new System.EventHandler(this.btnAccion1_Click);
            // 
            // ucBottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBottom);
            this.MaximumSize = new System.Drawing.Size(3840, 82);
            this.Name = "ucBottom";
            this.Size = new System.Drawing.Size(737, 82);
            this.Resize += new System.EventHandler(this.ucBottom_Resize);
            this.pnlBottom.ResumeLayout(false);
            this.pnlAccion2.ResumeLayout(false);
            this.pnlAccion3.ResumeLayout(false);
            this.pnlAccion1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlAccion2;
        private System.Windows.Forms.Button btnAccion2;
        private System.Windows.Forms.Panel pnlAccion3;
        private System.Windows.Forms.Button btnAccion3;
        private System.Windows.Forms.Panel pnlAccion1;
        private System.Windows.Forms.Button btnAccion1;
    }
}
