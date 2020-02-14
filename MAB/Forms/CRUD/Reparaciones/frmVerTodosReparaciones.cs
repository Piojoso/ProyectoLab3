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
    public partial class frmVerTodosReparaciones : Form
    {
        public frmVerTodosReparaciones()
        {
            InitializeComponent();

            ucBG.Titulo = "Todas las Reparaciones";

            ucBG.Accion1 = "Buscar";
            ucBG.Accion2 = "Modificar";
            ucBG.Accion3 = "Cerrar";

            ucBG.evAccion1 += buscarReparacion;
            ucBG.evAccion2 += modificarReparacion;
            ucBG.evAccion3 += cerrarVentana;

            cargarDGV();
        }

        private void cargarDGV(List<int> idReparaciones = null)
        {
            if (idReparaciones == null)
            {
                using (MABEntities db = new MABEntities())
                {
                    var data = db.Reparaciones;

                    ucBG.cargarDGV(data.ToList());
                }
            }
            else
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Reparaciones> reparaciones = null;

                    foreach (int id in idReparaciones)
                    {
                        var data = db.Reparaciones.Find(id);

                        reparaciones.Add(data);
                    }

                    if(reparaciones != null)
                    {
                        ucBG.cargarDGV(reparaciones);
                    }
                }
            }
        }

        private void buscarReparacion(object sender, EventArgs e)
        {
            frmBuscarReparacion frm = new frmBuscarReparacion();
            frm.ShowDialog();

            if(frm.DialogResult != DialogResult.Cancel)
            {
                cargarDGV(frm.idReparaciones);
            }
        }

        private void modificarReparacion(object sender, EventArgs e)
        {
            DataGridViewRow fila = ucBG.getSelectedItem();

            using (MABEntities db = new MABEntities())
            {
                /**
                 * TODO: verificar si no hay que castear el value
                 */
                var reparacion = db.Reparaciones.Find(fila.Cells[0].Value);

                frmModificarReparacion frm = new frmModificarReparacion(reparacion.Id);
                frm.ShowDialog();
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
