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
using MAB.Forms.Repuestos;

namespace MAB.Forms.Reparaciones
{
    public partial class frmFinalizarReparacion : Form
    {
        public frmFinalizarReparacion(int idReparacion)
        {
            /**
             * TODO: Provar su correcto funcionamiento
             */
            InitializeComponent();

            cboEstadoReparacion.DataSource = Enum.GetValues(typeof(estadosReparacion));

            cargarReparacion(idReparacion);

            ucBottom.Accion1 = "Aceptar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += guardarModificacion;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Numeros, no se permiten Letras";

            cctbMesesGarantia.CaracterIncorrectErrorMessage = messageError;
            cctbManoObra.CaracterIncorrectErrorMessage = messageError;
            cctbTotalRepuestos.CaracterIncorrectErrorMessage = messageError;
            
        }

        private Models.Reparaciones reparacion;

        private void cargarReparacion(int idReparacion)
        {
            using (MABEntities db = new MABEntities())
            {
                reparacion = db.Reparaciones.Find(idReparacion);
            }

            cclblNumReparacion.Text = reparacion.Id.ToString();

            cboEstadoReparacion.SelectedItem = estadosReparacion.Finalizada;

            cctbMesesGarantia.Text = reparacion.mesesGarantia != null ? reparacion.mesesGarantia.ToString() : "3";
            cctbReparacionRealizada.Text = reparacion.reparacionRealizada;
            cctbManoObra.Text = reparacion.manoDeObra.ToString();
            cctbTotalRepuestos.Text = reparacion.totalRepuestos.ToString();

            Text = "Finalizar Reparacion";
        }

        #region guardarModificacion

        private void guardarModificacion(object sender, EventArgs e)
        {
            if (dtpFechaEgreso.Value > DateTime.Now)
                dtpFechaEgreso.Value = DateTime.Now;

            if (cctbMesesGarantia.Text == string.Empty)
                cctbMesesGarantia.Text = "3";

            if(cctbManoObra.Text != string.Empty && cctbTotalRepuestos.Text != string.Empty)
            {
                reparacion.estadoReparacion = (estadosReparacion)cboEstadoReparacion.SelectedItem;
                reparacion.mesesGarantia = Convert.ToInt32(cctbMesesGarantia.Text);
                reparacion.fechaEgreso = dtpFechaEgreso.Value;
                reparacion.reparacionRealizada = cctbReparacionRealizada.Text;
                reparacion.manoDeObra = Convert.ToInt32(cctbManoObra.Text);
                reparacion.totalRepuestos = Convert.ToInt32(cctbTotalRepuestos.Text);

                using (MABEntities db = new MABEntities())
                {
                    db.Entry(reparacion).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Reparacion finalizada correctamente");
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            frmRepuestos frm = new frmRepuestos(reparacion.Id);
            frm.ShowDialog();

            cargarReparacion(reparacion.Id);
        }
    }
}
