using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Models;

namespace MAB.UC
{
    public partial class ucBackGround : UserControl
    {
        public ucBackGround()
        {
            InitializeComponent();

            ucBottom.evAccion1 += btnAccion1;
            ucBottom.evAccion2 += btnAccion2;
            ucBottom.evAccion3 += btnAccion3;
        }

        #region Textos

        private string titulo;
        private string accion1;
        private string accion2;
        private string accion3;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; ucTop.Titulo = titulo; }
        }

        public string Accion1
        {
            get { return accion1; }
            set { accion1 = value; ucBottom.Accion1 = accion1; }
        }

        public string Accion2
        {
            get { return accion2; }
            set { accion2 = value; ucBottom.Accion2 = accion2; }
        }

        public string Accion3
        {
            get { return accion3; }
            set { accion3 = value; ucBottom.Accion3 = accion3; }
        }

        #endregion

        #region Eventos

        public event EventHandler evAccion1;
        public event EventHandler evAccion2;
        public event EventHandler evAccion3;
        
        private void btnAccion1(object sender, EventArgs e)
        {
            evAccion1?.Invoke(sender, e);
        }

        private void btnAccion2(object sender, EventArgs e)
        {
            evAccion2?.Invoke(sender, e);
        }

        private void btnAccion3(object sender, EventArgs e)
        {
            evAccion3?.Invoke(sender, e);
        }

        #endregion

        public DataGridViewRow getSelectedItem()
        {

            //PROBAR LA OPCION DE NULL CUANDO NO HAY FILA SELECCIONADA
            return dgvPrincipal.Rows[dgvPrincipal.CurrentRow.Index];
        }
        
        public void cargarDGV(Object datos)
        {
            dgvPrincipal.DataSource = datos;
        }

        public void numButtons(int cantBotones)
        {
            ucBottom.NumButtons = cantBotones;
        }
    }
}
