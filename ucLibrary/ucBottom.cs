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

        private int numButtons = 3;
        
        [DefaultValue(3)]
        public int NumButtons
        {
            get { return numButtons; }
            set
            {
                numButtons = value;

                if (numButtons == 1)
                {
                    tlpPrincipal.ColumnStyles[0].Width = 100;
                    tlpPrincipal.ColumnStyles[1].Width = 0;
                    tlpPrincipal.ColumnStyles[2].Width = 0;

                }
                else if (numButtons == 2)
                {
                    tlpPrincipal.ColumnStyles[0].Width = 50;
                    tlpPrincipal.ColumnStyles[1].Width = 50;
                    tlpPrincipal.ColumnStyles[2].Width = 0;
                }
                else
                {
                    tlpPrincipal.ColumnStyles[0].Width = 33;
                    tlpPrincipal.ColumnStyles[1].Width = 33;
                    tlpPrincipal.ColumnStyles[2].Width = 33;
                }
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
            /**
             * TODO:    Que los botones se mantengan centrados y cambien su tamaño segun el tamaño del uc, Si el control es lo 
             *          suficientemente chiquito, los botones ocuparan todo el espacio disponible, asi sera mas facil clickearles
             *          Si el control crece los botones iran haciendolo a medida que lo haga el uc.
             * ---HECHO
             * 
             */

            if (tlpAccion1.Width >= 100)
            {
                btnAccion1.Anchor = AnchorStyles.None;
                btnAccion2.Anchor = AnchorStyles.None;
                btnAccion3.Anchor = AnchorStyles.None;
            }
            
            if (tlpAccion1.Width > 200)
            {
                tlpAccion1.ColumnStyles[0].Width = 25;
                tlpAccion1.ColumnStyles[1].Width = 50;
                tlpAccion1.ColumnStyles[2].Width = 25;

                tlpAccion2.ColumnStyles[0].Width = 25;
                tlpAccion2.ColumnStyles[1].Width = 50;
                tlpAccion2.ColumnStyles[2].Width = 25;
                
                tlpAccion3.ColumnStyles[0].Width = 25;
                tlpAccion3.ColumnStyles[1].Width = 50;
                tlpAccion3.ColumnStyles[2].Width = 25;
            }
            else if (tlpAccion1.Width <= 200 && tlpAccion1.Width >= 100)
            {
                tlpAccion1.ColumnStyles[0].Width = 10;
                tlpAccion1.ColumnStyles[1].Width = 80;
                tlpAccion1.ColumnStyles[2].Width = 10;

                tlpAccion2.ColumnStyles[0].Width = 10;
                tlpAccion2.ColumnStyles[1].Width = 80;
                tlpAccion2.ColumnStyles[2].Width = 10;

                tlpAccion3.ColumnStyles[0].Width = 10;
                tlpAccion3.ColumnStyles[1].Width = 80;
                tlpAccion3.ColumnStyles[2].Width = 10;
                
            }
            else if (tlpAccion1.Width < 100)
            {

                tlpAccion1.ColumnStyles[0].Width = 3;
                tlpAccion1.ColumnStyles[1].Width = 94;
                tlpAccion1.ColumnStyles[2].Width = 3;

                tlpAccion2.ColumnStyles[0].Width = 3;
                tlpAccion2.ColumnStyles[1].Width = 94;
                tlpAccion2.ColumnStyles[2].Width = 3;

                tlpAccion3.ColumnStyles[0].Width = 3;
                tlpAccion3.ColumnStyles[1].Width = 94;
                tlpAccion3.ColumnStyles[2].Width = 3;

                btnAccion1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                btnAccion2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                btnAccion3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }

        }
    }
}
