using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Models;

namespace MAB.Forms.Repuestos
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();

            cargarDGV();

            ucDGVTabla.click_btnAdd += btnAgregar;
            ucDGVTabla.click_btnModify += btnModificar;
            ucDGVTabla.click_btnSearch += btnBuscar;
        }

        private void cargarDGV()
        {
            using (MABEntities db = new MABEntities())
            {
                var repuestos = db.Repuestos;

                ucDGVTabla.FullListData = repuestos.ToList();
            }
        }

        #region eventos de botones

        private void btnAgregar(object sender, EventArgs e)
        {

        }

        private void btnModificar(object sender, EventArgs e)
        {

        }

        private void btnBuscar(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
