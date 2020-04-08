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
        }

        private List<int> idLavarropas;

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

            DialogResult resp;

            if (idLavarropas.Count > 0)
            {
                resp = MessageBox.Show(
                    "Se han encontrado: " + idLavarropas.Count + " registro/s. \n" +
                    "¿Desea verlos?", idLavarropas.Count + " Resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(resp == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                resp = MessageBox.Show(
                    "No se encontraron registros con la actual informacion. \n" +
                    "¿Desea que se limpien todos los campos?", "Sin Resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(resp == DialogResult.Yes)
                {
                    cctbMarca.Text = string.Empty;
                    cctbModelo.Text = string.Empty;
                    cctbEstadoGeneral.Text = string.Empty;

                    cctbMarca.Focus();
                }
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
