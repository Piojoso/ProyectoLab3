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

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmModificarReparacion : Form
    {
        Models.Reparaciones reparacion;

        /**
         * Aun no probado. Puede que traiga multiples errores
         */

        public frmModificarReparacion(int idReparacion)
        {

            /**
             * TODO: Posiblemente deba modificar todo esto cuando tenga entregas y repuestos.
             * Sospecho que quizas debi dejar la reparacion para el final.
             */

            InitializeComponent();

            ucTop.Titulo = "Modificar Reparacion";

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Confirmar";
            ucBottom.Accion3 = "Cancelar";

            ucBottom.evAccion1 += confirmarCambios;
            ucBottom.evAccion3 += cancelarCambios;

            cargarCBOEstadoReparacion();

            cargarDatos(idReparacion);
        }

        private void confirmarCambios(object sender, EventArgs e)
        {
            using (MABEntities db = new MABEntities())
            {
                bool finalizado = (estadosReparacion)cboEstadoReparacion.SelectedItem == estadosReparacion.EnCurso ? true : false;

                reparacion.estadoReparacion = (estadosReparacion)cboEstadoReparacion.SelectedItem;
                reparacion.fechaIngreso = dtpFechaIngreso.Value;
                reparacion.errorAReparar = cctbFallaAReparar.Text == string.Empty ? reparacion.errorAReparar : cctbFallaAReparar.Text;
                reparacion.reparacionRealizada = cctbReparacionRealizada.Text != string.Empty ? cctbReparacionRealizada.Text : null;
                reparacion.manoDeObra = finalizado == false ? 0 : Convert.ToDouble(cctbManoObra.Text);
                reparacion.totalRepuestos = finalizado == false ? 0 : Convert.ToDouble(cctbValorRepuestos.Text);
                reparacion.fechaEgreso = finalizado == true ? dtpFechaEgreso?.Value : null;
                reparacion.mesesGarantia = finalizado == false ? null : (int?)Convert.ToInt32(nudGarantia.Value);

                db.Entry(reparacion).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
        }

        private void cancelarCambios(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCBOEstadoReparacion()
        {
            using (MABEntities db = new MABEntities())
            {
                cboEstadoReparacion.DataSource = Enum.GetValues(typeof(estadosReparacion));
            }
        }

        private void cargarDatos(int idReparacion)
        {
            using (MABEntities db = new MABEntities())
            {
                reparacion = db.Reparaciones.Find(idReparacion);

                cclblMarcaModelo.Text = reparacion.Lavarropas.marca + " " + reparacion.Lavarropas.modelo;
                cboEstadoReparacion.SelectedItem = reparacion.estadoReparacion;
                dtpFechaIngreso.Value = reparacion.fechaIngreso;
                cctbFallaAReparar.Text = reparacion.errorAReparar;
                cctbReparacionRealizada.Text = reparacion.reparacionRealizada;
                cctbManoObra.Text = reparacion.manoDeObra.ToString();
                cctbValorRepuestos.Text = reparacion.totalRepuestos.ToString();
                cclblValorTotal.Text = (reparacion.manoDeObra + reparacion.totalRepuestos).ToString();
                dtpFechaEgreso.Value = (reparacion.fechaEgreso != null) ? reparacion.fechaEgreso.Value : DateTime.Now;
                nudGarantia.Value = (reparacion.mesesGarantia != null) ? Convert.ToDecimal(reparacion.mesesGarantia) : 0;
                dtpGarantia.Value = (reparacion.fechaEgreso != null) ? reparacion.fechaEgreso.Value.AddMonths(Convert.ToInt32(nudGarantia.Value)) : DateTime.Now;
            }
        }
    }
}
