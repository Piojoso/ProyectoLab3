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
using MAB.Forms.CRUD.Reparaciones;
using MAB.Forms.Lavarropas;
using MAB.Forms.Entregas;

namespace MAB.Forms.Reparaciones
{
    public partial class frmDetalleReparacion : Form
    {
        public frmDetalleReparacion(int idReparacion)
        {
            InitializeComponent();

            cargarReparacion(idReparacion);

            ucBottom.Accion1 = "Modificar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += modificarReparacion;
            ucBottom.evAccion2 += cerrarVentana;
        }

        Models.Reparaciones reparacion;

        private void cargarReparacion(int idReparacion)
        {
            using (MABEntities db = new MABEntities())
            {
                reparacion = db.Reparaciones.Find(idReparacion);
            }

            cclblId.Text = reparacion.Id.ToString();
            cclblFechaIngreso.Text = reparacion.fechaIngreso.ToShortDateString();
            cclblErrorARepara.Text = reparacion.errorAReparar;
            cclblEstadoReparacion.Text = reparacion.estadoReparacion.ToString();
            cclblReparacionRealizada.Text = reparacion.reparacionRealizada;
            cclblMesesGarantia.Text = reparacion.mesesGarantia == null? "0" : reparacion.mesesGarantia.ToString();
            cclblManoObra.Text = reparacion.manoDeObra.ToString();
            cclblTotalRepuestos.Text = reparacion.totalRepuestos.ToString();
            cclblTotal.Text = Convert.ToString(reparacion.manoDeObra + reparacion.totalRepuestos);

            Text = "Detalle de la Reparacion: " + reparacion.Id;
        }

        #region eventos de ucBottom

        private void modificarReparacion(object sender, EventArgs e)
        {
            frmModificarReparacion frm = new frmModificarReparacion(reparacion.Id);
            frm.ShowDialog();

            cargarReparacion(reparacion.Id);
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region eventos de botones

        private void btnVerEntregas_Click(object sender, EventArgs e)
        {
            frmEntregas frm = new frmEntregas(reparacion.Id);
            frm.ShowDialog();
        }

        private void btnVerLavarropas_Click(object sender, EventArgs e)
        {
            frmDetalleLavarropas frm = new frmDetalleLavarropas(reparacion.Lavarropas.Id);
            frm.ShowDialog();
        }

        #endregion
    }
}
