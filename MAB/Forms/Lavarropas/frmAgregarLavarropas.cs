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

namespace MAB.Forms.Lavarropas
{
    public partial class frmAgregarLavarropas : Form
    {
        private Models.Clientes Cliente;

        public frmAgregarLavarropas(int idCliente)
        {
            /**
             * TODO: Revisar el correcto funcionamiento
             */

            InitializeComponent();

            cargarCliente(idCliente);

            ucBottom.Accion1 = "Guardar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += guardarLavarropas;
            ucBottom.evAccion2 += cerrarVentana;
        }

        private void cargarCliente(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                Cliente = db.Clientes.Find(idCliente);

                if(Cliente != null)
                {
                    Text = "Registrar Lavarropas";

                    cclblNombreCliente.Text = Cliente.nombre + " " + Cliente.apellido;
                }
            }
        }

        private void guardarLavarropas(object sender, EventArgs e)
        {
            if((cctbMarca.Text != string.Empty) && (cctbModelo.Text != string.Empty) && (cctbEstado.Text != string.Empty))
            {
                DialogResult resp = MessageBox.Show(
                    "Se guardara el Lavarropas: \n" +
                    "Marca: " + cctbMarca.Text + "\n" +
                    "Modelo: " + cctbModelo.Text + "\n" +
                    "Para el Cliente: " + Cliente.nombre + " " + Cliente.apellido + "\n" +
                    "¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(resp == DialogResult.Yes)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        Models.Lavarropas Lavarropas = new Models.Lavarropas();

                        Lavarropas.marca = cctbMarca.Text;
                        Lavarropas.modelo = cctbModelo.Text;
                        Lavarropas.estadoGeneral = cctbEstado.Text;
                        Lavarropas.ClienteId = Cliente.Id;

                        db.Lavarropas.Add(Lavarropas);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay campos que faltan completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
