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
    public partial class frmBuscarRepuesto : Form
    {
        public frmBuscarRepuesto()
        {
            InitializeComponent();

            ucBottom.Accion1 = "Buscar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += buscarRepuesto;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Letras, no se permiten numeros";

            cctbNombre.CaracterIncorrectErrorMessage = messageError;
            cctbDescripcion.CaracterIncorrectErrorMessage = messageError;

            messageError = "Solo se permiten Numeros, no se permiten Letras";

            cctbStock.CaracterIncorrectErrorMessage = messageError;
            cctbPrecio.CaracterIncorrectErrorMessage = messageError;
        }

        private List<int> idRepuestos = new List<int>();

        public List<int> getRepuestos
        {
            get { return idRepuestos; }
        }

        #region eventos de ucBottom

        private void buscarRepuesto(object sender, EventArgs e)
        {
            bool nombre = cctbNombre.Text != string.Empty ? true : false;
            bool descripcion = cctbDescripcion.Text != string.Empty ? true : false;
            bool stock = cctbStock.Text != string.Empty ? true : false;
            bool precio = cctbPrecio.Text != string.Empty ? true : false;

            List<Models.Repuestos> repuestos;

            using (MABEntities db = new MABEntities())
            {
                repuestos = db.Repuestos.ToList();
            }

            foreach (Models.Repuestos r in repuestos)
            {
                if (nombre && r.nombre == cctbNombre.Text)
                {
                    idRepuestos.Add(r.Id);
                    break;
                }
                else if (descripcion && r.descripcion == cctbDescripcion.Text)
                {
                    idRepuestos.Add(r.Id);
                    break;
                }
                else if(stock && r.disponibles == Convert.ToInt32(cctbStock.Text))
                {
                    idRepuestos.Add(r.Id);
                    break;
                }
                else if (precio && r.precio == Convert.ToDouble(cctbPrecio.Text))
                {
                    idRepuestos.Add(r.Id);
                    break;
                }
            }

            DialogResult resp;

            if (idRepuestos.Count > 0)
            {
                resp = MessageBox.Show(
                    "Se han encontrado: " + idRepuestos.Count + " registro/s. \n" +
                    "¿Desea verlos?", idRepuestos.Count + " Resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                resp = MessageBox.Show(
                    "No se encontraron registros con la actual informacion. \n" +
                    "¿Desea que se limpien todos los campos?", "Sin Resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    cctbNombre.Text = string.Empty;
                    cctbDescripcion.Text = string.Empty;
                    cctbStock.Text = string.Empty;
                    cctbPrecio.Text = string.Empty;

                    cctbNombre.Focus();
                }
            }
        }
        
        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
