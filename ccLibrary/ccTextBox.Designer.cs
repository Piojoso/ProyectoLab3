namespace ccLibrary
{
    partial class ccTextBox
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
            this.tbPrincipal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.Size = new System.Drawing.Size(100, 20);
            this.tbPrincipal.TabIndex = 0;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrincipal;
    }
}
