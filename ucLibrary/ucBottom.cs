using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucLibrary
{
    public partial class ucBottom: UserControl
    {
        public ucBottom()
        {
            InitializeComponent();
        }

        #region Numero de Botones

        private int numButtons;

        /**
         * Funcion que se encarga de las modificaciones 
         * necesarias para la cantidad de botones que 
         * sean requeridos.
         */
        public int NumButtons
        {
            /** 
             * TODO: Hacer que los paneles ocupen todo el ancho disponible.
             * En el caso de 2 botones, que se divida a la mitad el ancho del form.
             * TODO: Probar a hacer la solucion al problema usando un TableLayoutPanel.
             */ 
            get { return numButtons; }
            set
            {
                numButtons = value;

                if(numButtons == 1)
                {
                    pnlAccion1.Visible = false;
                    pnlAccion3.Visible = false;
                }
                else if (numButtons == 2)
                    pnlAccion2.Visible = false;
            }
        }

        #endregion

        #region Textos

        private string accion1;
        private string accion2;
        private string accion3;

        public string Accion1
        {
            get { return accion1; }
            set { accion1 = value; btnAccion1.Text = accion1; }
        }

        public string Accion2
        {
            get { return accion2; }
            set { accion2 = value; btnAccion2.Text = accion2; }
        }

        public string Accion3
        {
            get { return accion3; }
            set { accion3 = value; btnAccion3.Text = accion3; }
        }

        #endregion

        #region Eventos

        public event EventHandler evAccion1;
        public event EventHandler evAccion2;
        public event EventHandler evAccion3;

        private void btnAccion1_Click(object sender, EventArgs e)
        {
            evAccion1?.Invoke(sender, e);
        }

        private void btnAccion2_Click(object sender, EventArgs e)
        {
            evAccion2?.Invoke(sender, e);
        }

        private void btnAccion3_Click(object sender, EventArgs e)
        {
            evAccion3?.Invoke(sender, e);
        }
        #endregion

        private void ucBottom_Resize(object sender, EventArgs e)
        {
            double widthPanel = this.Size.Width / 3;
            widthPanel = Math.Round(widthPanel);
            Size newSize = new Size(Convert.ToInt32(widthPanel), this.Size.Height);

            pnlAccion1.Size = newSize;
            pnlAccion2.Size = newSize;
            pnlAccion3.Size = newSize;

            btnAccion1.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);

            if (widthPanel <= 245)
            {
                btnAccion1.Anchor = AnchorStyles.None;
                btnAccion2.Anchor = AnchorStyles.None;
                btnAccion3.Anchor = AnchorStyles.None;
            }
            else
            {
                btnAccion1.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
                btnAccion2.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
                btnAccion3.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
            }
        }
        
    }
}
