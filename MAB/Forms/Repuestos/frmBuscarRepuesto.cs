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

            using (MABEntities db = new MABEntities())
            {
                if (nombre)
                {
                    var repuestos = db.Repuestos.Where(r => r.nombre.Contains(cctbNombre.Text));

                    foreach (var r in repuestos)
                    {
                        if (!idRepuestos.Contains(r.Id))
                        {
                            idRepuestos.Add(r.Id);
                        }
                    }
                }
                if (descripcion)
                {
                    var repuestos = db.Repuestos.Where(r => r.descripcion.Contains(cctbDescripcion.Text));

                    foreach (var r in repuestos)
                    {
                        if (!idRepuestos.Contains(r.Id))
                        {
                            idRepuestos.Add(r.Id);
                        }
                    }
                }
                if(stock)
                {
                    var repuestos = db.Repuestos.Where(r => r.disponibles == Convert.ToInt32(cctbNombre.Text));

                    foreach (var r in repuestos)
                    {
                        if (!idRepuestos.Contains(r.Id))
                        {
                            idRepuestos.Add(r.Id);
                        }
                    }
                }
                if (precio)
                {
                    var repuestos = db.Repuestos.Where(r => r.precio == Convert.ToInt32(cctbNombre.Text));

                    foreach (var r in repuestos)
                    {
                        if (!idRepuestos.Contains(r.Id))
                        {
                            idRepuestos.Add(r.Id);
                        }
                    }
                }
            }

            if (idRepuestos.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "No hubo resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                cctbNombre.Text = string.Empty;
                cctbDescripcion.Text = string.Empty;
                cctbStock.Text = string.Empty;
                cctbPrecio.Text = string.Empty;

                cctbNombre.Focus();
            }
        }
        
        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
