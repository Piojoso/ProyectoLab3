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
    public partial class frmAgregarRepuesto : Form
    {
        public frmAgregarRepuesto()
        {
            InitializeComponent();
            
            Text = "Agregar nuevo Repuesto";

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += agregarRepuesto;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Letras, no se permiten numeros";

            cctbNombre.CaracterIncorrectErrorMessage = messageError;
            cctbDescripcion.CaracterIncorrectErrorMessage = messageError;

            messageError = "Solo se permiten Numeros, no se permiten Letras";

            cctbStock.CaracterIncorrectErrorMessage = messageError;
            cctbPrecio.CaracterIncorrectErrorMessage = messageError;
        }

        #region eventos de ucBottom

        private void agregarRepuesto(object sender, EventArgs e)
        {
            if(cctbNombre.Text != string.Empty && cctbDescripcion.Text != string.Empty && cctbStock.Text != string.Empty && cctbPrecio.Text != string.Empty)
            {
                using(MABEntities db = new MABEntities())
                {
                    Models.Repuestos repuesto = new Models.Repuestos();

                    repuesto.nombre = cctbNombre.Text;
                    repuesto.descripcion = cctbDescripcion.Text;
                    repuesto.disponibles = Convert.ToInt32(cctbStock.Text);
                    repuesto.precio = Convert.ToDouble(cctbPrecio.Text);

                    db.Repuestos.Add(repuesto);

                    db.SaveChanges();

                    MessageBox.Show("Repuesto agregado correctamente", "Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cctbNombre.Text = "";
                    cctbDescripcion.Text = "";
                    cctbPrecio.Text = "";
                    cctbStock.Text = "";

                    cctbNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
