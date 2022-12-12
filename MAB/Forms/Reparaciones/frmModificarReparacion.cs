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

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmModificarReparacion : Form
    {
        Models.Reparaciones reparacion;

        public frmModificarReparacion(int idReparacion)
        {
            /**
             * TODO: Revisar su correcto funcionamiento
             */

            InitializeComponent();

            cargarCBOEstadoReparacion();

            cargarDatos(idReparacion);

            ucBottom.Accion1 = "Guardar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += guardarCambios;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Numeros, no se permiten Letras.";

            cctbManoObra.CaracterIncorrectErrorMessage = messageError;
            cctbValorRepuestos.CaracterIncorrectErrorMessage = messageError;
        }

        private void cargarCBOEstadoReparacion()
        {
            cboEstadoReparacion.DataSource = Enum.GetValues(typeof(estadosReparacion));
        }

        private void cargarDatos(int idReparacion)
        {
            using (MABEntities db = new MABEntities())
            {
                reparacion = db.Reparaciones.Find(idReparacion);

                cclblNombreApellidoCliente.Text = reparacion.Lavarropas.Cliente.nombre + " " + reparacion.Lavarropas.Cliente.apellido;
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

            Text = "Modificar la reparacion: " + reparacion.Id;
        }

        private void guardarCambios(object sender, EventArgs e)
        {
            if(cctbFallaAReparar.Text != string.Empty)
            {
                if (cctbReparacionRealizada.Text == string.Empty)
                    cctbReparacionRealizada.Text = "";
                if (cctbManoObra.Text == string.Empty)
                    cctbManoObra.Text = "0";
                if (cctbValorRepuestos.Text == string.Empty)
                    cctbValorRepuestos.Text = "0";

                if ((estadosReparacion)cboEstadoReparacion.SelectedItem == estadosReparacion.Finalizada)
                {
                    reparacion.fechaEgreso = dtpFechaEgreso.Value;
                    reparacion.mesesGarantia = Convert.ToInt32(nudGarantia.Value);
                }

                using (MABEntities db = new MABEntities())
                {
                    reparacion.estadoReparacion = (estadosReparacion)cboEstadoReparacion.SelectedItem;
                    reparacion.fechaIngreso = dtpFechaIngreso.Value;
                    reparacion.errorAReparar = cctbFallaAReparar.Text;
                    reparacion.reparacionRealizada = cctbReparacionRealizada.Text;
                    reparacion.manoDeObra = Convert.ToDouble(cctbManoObra.Text);
                    reparacion.totalRepuestos = Convert.ToDouble(cctbValorRepuestos.Text);

                    db.Entry(reparacion).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    MessageBox.Show("Reparacion Modificada correctamente");
                }
            }
            else
            {
                MessageBox.Show("Hay campos que faltan completar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            frmRepuestos frm = new frmRepuestos(reparacion.Id);
            frm.ShowDialog();

            cargarDatos(reparacion.Id);
        }
    }
}
