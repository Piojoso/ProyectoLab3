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
    public partial class frmModificarEntrega : Form
    {
        public frmModificarEntrega(int idEntrega)
        {
            InitializeComponent();

            cargarEntrega(idEntrega);

            ucBottom.Accion1 = "Modificar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += modificarEntrega;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Numeros, no se permiten Letras";

            cctbMonto.CaracterIncorrectErrorMessage = messageError;
        }

        private Models.Entregas entrega;

        private void cargarEntrega(int idEntrega)
        {
            using (MABEntities db = new MABEntities())
            {
                entrega = db.Entregas.Find(idEntrega);
            }

            Text = "Modificacion de la entrega Numero: " + entrega.Id;

            cclblCliente.Text = entrega.Clientes.nombre + " " + entrega.Clientes.apellido;
            cclblNumReparacion.Text = entrega.Reparaciones.Id.ToString();
            cctbMonto.Text = entrega.monto.ToString();
            dtpFechaEntrega.Value = entrega.fecha;
        }

        #region eventos de ucBottom

        private void modificarEntrega(object sender, EventArgs e)
        {
            if (dtpFechaEntrega.Value > DateTime.Now)
                dtpFechaEntrega.Value = DateTime.Now;

            if(cctbMonto.Text != string.Empty)
            {
                entrega.monto = Convert.ToDouble(cctbMonto.Text);
                entrega.fecha = dtpFechaEntrega.Value;

                using (MABEntities db = new MABEntities())
                {
                    db.Entry(entrega).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Entrega modificada Correctamente");
                }
            }
            else
            {
                MessageBox.Show("Falta completar el campo de monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
