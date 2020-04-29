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

        public frmModificarReparacion(int idReparacion)
        {
            /**
             * TODO: Revisar su correcto funcionamiento
             */

            InitializeComponent();

            cargarCBOEstadoReparacion();

            cargarDatos(idReparacion);

            ucBottom.Accion1 = "Guardar";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += guardarCambios;
            ucBottom.evAccion3 += cerrarVentana;

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

                DialogResult resp;

                if ((estadosReparacion)cboEstadoReparacion.SelectedItem == estadosReparacion.Finalizada)
                {
                    resp = MessageBox.Show(
                    "¿Desea continuar con la modificacion? \n" +
                    "Estado de reparacion cambiara de: " + reparacion.estadoReparacion.ToString() + " a " + ((estadosReparacion)cboEstadoReparacion.SelectedItem).ToString() + "\n" +
                    "Fecha de Ingreso cambiara de: " + reparacion.fechaEgreso.Value.ToString() + " a " + dtpFechaIngreso.Value.ToString() + "\n" +
                    "Falla a Reparar cambiara de: " + reparacion.errorAReparar + " a " + cctbFallaAReparar.Text + "\n" +
                    "Reparacion Realizada cambiara de: " + reparacion.reparacionRealizada + " a " + cctbReparacionRealizada.Text + "\n" +
                    "Mano de Obra cambiara de: " + reparacion.manoDeObra + " a " + cctbManoObra.Text + "\n" +
                    "Total de Repuestos cambiara de: " + reparacion.totalRepuestos + " a " + cctbValorRepuestos.Text + "\n" +
                    "Fecha de Egreso cambiara de: " + reparacion.fechaEgreso + " a " + dtpFechaEgreso.Value.ToString() + "\n" +
                    "Meses de Garantia cambiara de: " + reparacion.mesesGarantia + " a " + nudGarantia.Value.ToString() + "\n" +
                    "Tenga en cuenta que la informacion anterior se perdera", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    reparacion.fechaEgreso = dtpFechaEgreso.Value;
                    reparacion.mesesGarantia = Convert.ToInt32(nudGarantia.Value);
                }
                else
                {
                    resp = MessageBox.Show(
                    "¿Desea continuar con la modificacion? \n" +
                    "Estado de reparacion cambiara de: " + reparacion.estadoReparacion.ToString() + " a " + ((estadosReparacion)cboEstadoReparacion.SelectedItem).ToString() + "\n" +
                    "Fecha de Ingreso cambiara de: " + reparacion.fechaEgreso.Value.ToString() + " a " + dtpFechaIngreso.Value.ToString() + "\n" +
                    "Falla a Reparar cambiara de: " + reparacion.errorAReparar + " a " + cctbFallaAReparar.Text + "\n" +
                    "Reparacion Realizada cambiara de: " + reparacion.reparacionRealizada + " a " + cctbReparacionRealizada.Text + "\n" +
                    "Mano de Obra cambiara de: " + reparacion.manoDeObra + " a " + cctbManoObra.Text + "\n" +
                    "Total de Repuestos cambiara de: " + reparacion.totalRepuestos + " a " + cctbValorRepuestos.Text + "\n" +
                    "Tenga en cuenta que la informacion anterior se perdera", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if(resp == DialogResult.Yes)
                {
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
                    }
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

    }
}
