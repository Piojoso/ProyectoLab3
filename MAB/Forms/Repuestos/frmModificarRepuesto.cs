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
    public partial class frmModificarRepuesto : Form
    {
        public frmModificarRepuesto(int idRepuesto)
        {
            InitializeComponent();

            ucBottom.Accion1 = "Modificar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += modificarRepuesto;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Letras, no se permiten numeros";

            cctbNombre.CaracterIncorrectErrorMessage = messageError;
            cctbDescripcion.CaracterIncorrectErrorMessage = messageError;

            messageError = "Solo se permiten Numeros, no se permiten Letras";

            cctbStock.CaracterIncorrectErrorMessage = messageError;
            cctbPrecio.CaracterIncorrectErrorMessage = messageError;

            cargarRepuesto(idRepuesto);
        }

        private Models.Repuestos repuesto;

        private void cargarRepuesto(int idRepuesto)
        {
            using (MABEntities db = new MABEntities())
            {
                repuesto = db.Repuestos.Find(idRepuesto);
            }

            cctbNombre.Text = repuesto.nombre;
            cctbDescripcion.Text = repuesto.descripcion;
            cctbStock.Text = repuesto.disponibles.ToString();
            cctbPrecio.Text = repuesto.precio.ToString();

        }

        #region evento de ucBottom

        private void modificarRepuesto(object sender, EventArgs e)
        {
            if (cctbNombre.Text != string.Empty && cctbDescripcion.Text != string.Empty && cctbPrecio.Text != string.Empty && cctbStock.Text != string.Empty)
            {
                DialogResult resp = MessageBox.Show(
                    "¿Desea continuar con la modificacion? \n" +
                    "Nombre cambiara de: " + repuesto.nombre + " a " + cctbNombre.Text + "\n" +
                    "Descripcion cambiara de: " + repuesto.descripcion + " a " + cctbDescripcion.Text + "\n" +
                    "Stock cambiara de: " + repuesto.disponibles + " a " + cctbStock.Text + "\n" +
                    "Precio cambiara de: " + repuesto.precio + " a " + cctbPrecio.Text + "\n" +
                    "Tenga en cuenta que la informacion anterior se perdera", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    repuesto.nombre = cctbNombre.Text;
                    repuesto.descripcion = cctbDescripcion.Text;
                    repuesto.disponibles = Convert.ToInt32(cctbStock.Text);
                    repuesto.precio = Convert.ToDouble(cctbPrecio.Text);

                    using (MABEntities db = new MABEntities())
                    {
                        db.Entry(repuesto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        MessageBox.Show("Repuesto modificado Correctamente");
                    }
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
    }
}
