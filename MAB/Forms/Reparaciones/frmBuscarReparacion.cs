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

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmBuscarReparacion : Form
    {
        public List<int> idReparaciones = null;

        public frmBuscarReparacion()
        {
            InitializeComponent();

            ucTop.Titulo = "Buscar Reparacion";

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Buscar";
            ucBottom.Accion3 = "Cancelar";

            ucBottom.evAccion1 += buscarReparacion;
            ucBottom.evAccion3 += cancelarBusqueda;
        }

        private void buscarReparacion(object sender, EventArgs e)
        {
            /**
             * TODO: Testear esta funcion
             */
            using (MABEntities db = new MABEntities())
            {
                var reparaciones = db.Reparaciones;

                foreach(Models.Reparaciones reparacion in reparaciones)
                {
                    if((dtpInicioIngreso.Value <= reparacion.fechaIngreso) && (reparacion.fechaIngreso <= dtpFinIngreso.Value))
                    {
                        idReparaciones.Add(reparacion.Id);
                        break;
                    }
                    else if ((dtpInicioEgreso.Value <= reparacion.fechaEgreso) && (reparacion.fechaEgreso <= dtpFinEgreso.Value))
                    {
                        idReparaciones.Add(reparacion.Id);
                        break;
                    }
                }
            }

            if(idReparaciones != null)
            {
                DialogResult resp = MessageBox.Show("Se encontraron " + idReparaciones.Count + " Reparaciones. " +
                    "\n ¿Desea verlas?", "¿Ver Resultados?", MessageBoxButtons.YesNo);

                if( resp == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron reparaciones en esos rangos de Fechas. Pruebe con otros", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarBusqueda(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
