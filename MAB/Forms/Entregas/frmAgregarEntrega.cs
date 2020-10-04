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

            string messageError = "Solo se permiten Numeros, no se permiten Letras";

            cctbMonto.CaracterIncorrectErrorMessage = messageError;
        }

        private Models.Reparaciones reparacion;

        private void cargarDatos(int idReparacion)
        {
            using (MABEntities db = new MABEntities())
            {
                reparacion = db.Reparaciones.Find(idReparacion);

                Text = "Registrar una nueva Entrega";

                cclblCliente.Text = reparacion.Lavarropas.Cliente.nombre + " " + reparacion.Lavarropas.Cliente.apellido;
                cclblNumReparacion.Text = reparacion.Id.ToString();
            }
        }

        #region eventos de ucBottom

        private void agregarEntrega(object sender, EventArgs e)
        {
            if(cctbMonto.Text != string.Empty)
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

                    MessageBox.Show("Entrega Creada Correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    cctbMonto.Text = "";
                    cctbMonto.Focus();
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
