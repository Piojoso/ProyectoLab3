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
                    DialogResult resp = MessageBox.Show(
                        "Desea guardar el Repuesto con: \n" +
                        "Nombre: " + cctbNombre.Text + "\n" +
                        "Descripcion: " + cctbDescripcion.Text + "\n" +
                        "Stock" + cctbStock.Text + "\n" +
                        "Precio" + cctbPrecio.Text + "\n",
                        "Atencion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resp == DialogResult.Yes)
                    {
                        Models.Repuestos repuesto = new Models.Repuestos();

                        repuesto.nombre = cctbNombre.Text;
                        repuesto.descripcion = cctbDescripcion.Text;

                        Models.Stock stock = new Models.Stock();

                        stock.Disponibilidad = Convert.ToInt32(cctbStock.Text);
                        stock.Precio = Convert.ToDouble(cctbPrecio.Text);

                        repuesto.Stock = stock;
                        stock.Repuestos = repuesto;

                        db.Stock.Add(stock);
                        db.Repuestos.Add(repuesto);

                        db.SaveChanges();
                    }
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
