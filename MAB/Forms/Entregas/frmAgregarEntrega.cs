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

namespace MAB.Forms.Entregas
{
    public partial class frmAgregarEntrega : Form
    {
        public frmAgregarEntrega(int idReparacion)
        {
            InitializeComponent();

            cargarDatos(idReparacion);

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += agregarEntrega;
            ucBottom.evAccion2 += cerrarVentana;
        }

        private Models.Reparaciones reparacion;

        private void cargarDatos(int idReparacion)
        {
            using (MABEntities db = new MABEntities())
            {
                reparacion = db.Reparaciones.Find(idReparacion);
            }

            Text = "Registrar una entrega nueva";

            cclblCliente.Text = reparacion.Lavarropas.Cliente.nombre + " " + reparacion.Lavarropas.Cliente.apellido;
            cclblNumReparacion.Text = reparacion.Id.ToString();
        }

        #region eventos de ucBottom

        private void agregarEntrega(object sender, EventArgs e)
        {
            if (dtpFechaEntrega.Value > DateTime.Now)
                dtpFechaEntrega.Value = DateTime.Now;

            if(cctbMonto.Text != string.Empty)
            {
                DialogResult resp = MessageBox.Show(
                    "Esta a punto de agregar una nueva entrega a nombre del \n" +
                    "Cliente: " + reparacion.Lavarropas.Cliente.nombre + " " + reparacion.Lavarropas.Cliente.apellido + "\n" +
                    "para la reparacion numero: " + reparacion.Id + "\n" +
                    "El dia: " + dtpFechaEntrega.Value.ToShortDateString() + " y con un monto de: $" + cctbMonto.Text + "\n" +
                    "¿Deseas Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(resp == DialogResult.Yes)
                {
                    Models.Entregas entrega = new Models.Entregas();

                    entrega.ClientesId = reparacion.Lavarropas.Cliente.Id;
                    entrega.ReparacionesId = reparacion.Id;
                    entrega.monto = Convert.ToInt32(cctbMonto.Text);
                    entrega.fecha = dtpFechaEntrega.Value;

                    using(MABEntities db = new MABEntities())
                    {
                        db.Entregas.Add(entrega);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Falta llenar el monto de la entrega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
