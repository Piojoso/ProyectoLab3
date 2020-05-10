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

namespace MAB.Forms.Reparaciones
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();

            ucBottom.Accion1 = "Reparaciones";
            ucBottom.Accion2 = "Ingresos";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += verReparaciones;
            ucBottom.evAccion2 += verIngresos;
            ucBottom.evAccion3 += cerrarVentana;
        }

        #region eventos de ucBottom

        private void verReparaciones(object sender, EventArgs e)
        {
            pnlNumeroReparaciones.BringToFront();
        }

        private void verIngresos(object sender, EventArgs e)
        {
            pnlIngresosReparaciones.BringToFront();
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region eventos de RadioButtons CantRepIn

        private void rbCantRepInMensual_CheckedChanged(object sender, EventArgs e)
        {
            using (MABEntities db = new MABEntities())
            {
                /**
                 * select COUNT(r.Id) 
                 * from Reparaciones as r
                 * group by MONTH(r.fechaIngreso);
                 * 
                 */

                var data = (from r in db.Reparaciones
                            group r by new { month = r.fechaIngreso.Month } into grouped
                            select new { count = grouped.Count() }).ToList();

                chartCantRepIn.DataSource = data;
            }
        }

        private void rbCantRepInAnual_CheckedChanged(object sender, EventArgs e)
        {
            using (MABEntities db = new MABEntities())
            {
                /**
                 * select count(r.id)
                 * from Reparaciones as r
                 * group by YEAR(r.fechaIngreso);
                 * 
                 */

                var data = (from r in db.Reparaciones
                            group r by new { year = r.fechaIngreso.Year } into grouped
                            select new { count = grouped.Count() }).ToList();

                chartCantRepIn.DataSource = data;
            }
        }

        #endregion

        #region eventos de RadioButtons cantRepOut

        private void rbCantRepOutMensual_CheckedChanged(object sender, EventArgs e)
        {
            using (MABEntities db = new MABEntities())
            {
                /**
                 * select COUNT(r.Id) 
                 * from Reparaciones as r
                 * where r.fechaEgreso is not null
                 * group by MONTH(r.fechaIngreso);
                 * 
                 */

                var data = (from r in db.Reparaciones
                            where r.fechaEgreso != null
                            group r by new { month = r.fechaEgreso.Value.Month } into grouped
                            select new { count = grouped.Count() }).ToList();

                chartCantRepOut.DataSource = data;
            }
        }

        private void rbCantRepOutAnual_CheckedChanged(object sender, EventArgs e)
        {
            using (MABEntities db = new MABEntities())
            {
                /**
                 * select count(r.id)
                 * from Reparaciones as r
                 * where r.fechaEgreso is not null
                 * group by YEAR(r.fechaIngreso);
                 * 
                 */

                var data = (from r in db.Reparaciones
                            where r.fechaEgreso != null
                            group r by new { year = r.fechaEgreso.Value.Year } into grouped
                            select new { count = grouped.Count() }).ToList();

                chartCantRepOut.DataSource = data;
            }
        }
        
        #endregion

    }
}
