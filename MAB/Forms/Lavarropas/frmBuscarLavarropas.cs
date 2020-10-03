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

            List<Models.Lavarropas> lavarropas;

            using (MABEntities db = new MABEntities())
            {
                lavarropas = db.Lavarropas.ToList();
            }

            foreach (Models.Lavarropas l in lavarropas)
            {
                if (marca && l.marca == cctbMarca.Text)
                {
                    idLavarropas.Add(l.Id);
                    break;
                }
                else if (modelo && l.modelo == cctbModelo.Text)
                {
                    idLavarropas.Add(l.Id);
                    break;
                }
                else if (estadoGeneral && l.estadoGeneral == cctbEstadoGeneral.Text)
                {
                    idLavarropas.Add(l.Id);
                    break;
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
