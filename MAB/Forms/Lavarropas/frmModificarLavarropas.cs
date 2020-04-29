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
    public partial class frmModificarLavarropas : Form
    {
        private Models.Lavarropas lavarropas;

        public frmModificarLavarropas(int idLavarropas)
        {
            /**
             * TODO: Revisar el Correcto Funcionamiento
             */
            InitializeComponent();

            cargarLavarropas(idLavarropas);

            ucBottom.Accion1 = "Modificar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += modificarLavarropas;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Letras, no se permiten Numeros";

            cctbMarca.CaracterIncorrectErrorMessage = messageError;
        }

        private void cargarLavarropas(int idLavarropas)
        {
            using (MABEntities db = new MABEntities())
            {
                lavarropas = db.Lavarropas.Find(idLavarropas);

                Text = "Modificacion del Lavarropas: " + lavarropas.marca + " " + lavarropas.modelo;

                cclblNumId.Text = lavarropas.Id.ToString();

                cctbMarca.Text = lavarropas.marca;
                cctbModelo.Text = lavarropas.modelo;
                cctbEstadoGeneral.Text = lavarropas.estadoGeneral;
            }
        }

        private void modificarLavarropas(object sender, EventArgs e)
        {
            if((cctbMarca.Text != string.Empty) && (cctbModelo.Text != string.Empty) && (cctbEstadoGeneral.Text != string.Empty))
            {
                DialogResult resp = MessageBox.Show(
                    "Esta por modificar el lavarropas. \n" +
                    "Marca cambiara de: " + lavarropas.marca + " a " + cctbMarca.Text + "\n" +
                    "Modelo cambiara de: " + lavarropas.modelo + " a " + cctbModelo.Text + "\n" +
                    "Estado General cambiara de: " + lavarropas.estadoGeneral + " a " + cctbEstadoGeneral.Text + "\n" +
                    "¿Desea continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(resp == DialogResult.Yes)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        lavarropas.marca = cctbMarca.Text;
                        lavarropas.modelo = cctbModelo.Text;
                        lavarropas.estadoGeneral = cctbModelo.Text;

                        db.Entry(lavarropas).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Hay campos incompletos. Por favor completelos para continuar", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
