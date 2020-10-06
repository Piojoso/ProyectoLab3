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
    public partial class frmBuscarLavarropas : Form
    {
        public frmBuscarLavarropas()
        {
            InitializeComponent();

            Text = "Buscar Lavarropas";

            ucBottom.Accion1 = "Buscar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += buscarLavarropas;
            ucBottom.evAccion2 += cerrarVentana;

            string messageError = "Solo se permiten Letras, no se permiten Numeros";

            cctbMarca.CaracterIncorrectErrorMessage = messageError;
        }

        private List<int> idLavarropas = new List<int>();

        public List<int> getResultados
        {
            get { return idLavarropas; }
        }

        private void buscarLavarropas(object sender, EventArgs e)
        {
            bool marca = cctbMarca.Text != string.Empty ? true : false;
            bool modelo = cctbModelo.Text != string.Empty ? true : false;
            bool estadoGeneral = cctbEstadoGeneral.Text != string.Empty ? true : false;

            using (MABEntities db = new MABEntities())
            {
                if (marca)
                {
                    var lavarropas = db.Lavarropas.Where(l => l.marca.Contains(cctbMarca.Text));

                    foreach (var lavarropa in lavarropas)
                    {
                        if (!idLavarropas.Contains(lavarropa.Id))
                        {
                            idLavarropas.Add(lavarropa.Id);
                        }
                    }
                }
                if (modelo)
                {
                    var lavarropas = db.Lavarropas.Where(l => l.modelo.Contains(cctbModelo.Text));

                    foreach (var lavarropa in lavarropas)
                    {
                        if (!idLavarropas.Contains(lavarropa.Id))
                        {
                            idLavarropas.Add(lavarropa.Id);
                        }
                    }
                }
                if (estadoGeneral)
                {
                    var lavarropas = db.Lavarropas.Where(l => l.estadoGeneral.Contains(cctbEstadoGeneral.Text));

                    foreach (var lavarropa in lavarropas)
                    {
                        if (!idLavarropas.Contains(lavarropa.Id))
                        {
                            idLavarropas.Add(lavarropa.Id);
                        }
                    }
                }
            }

            if (idLavarropas.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "No hubo resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cctbMarca.Text = string.Empty;
                cctbModelo.Text = string.Empty;
                cctbEstadoGeneral.Text = string.Empty;

                cctbMarca.Focus();
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
