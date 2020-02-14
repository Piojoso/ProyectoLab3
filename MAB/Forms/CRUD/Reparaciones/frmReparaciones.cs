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
using MAB;

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmReparaciones : Form
    {
        public frmReparaciones()
        {
            InitializeComponent();

            ucBG.Titulo = "Ultimas Reparaciones";

            cargarDGV();

            ucBG.Accion1 = "Agregar";
            ucBG.Accion2 = "Modificar";
            ucBG.Accion3 = "Ver Todos";

            ucBG.evAccion1 += new EventHandler(btnAgregar);
            ucBG.evAccion2 += new EventHandler(btnModificar);
            ucBG.evAccion3 += verTodosReparacion;
        }

        private void cargarDGV()
        {
            /**
             * TODO: Revisar esta funcion... Parece que el || no funciona. Debo revisarlo bien
             */
            using (MABEntities db = new MABEntities())
            {
                var data = from reparaciones in db.Reparaciones
                           where (((DateTime.Now - reparaciones.fechaIngreso).Days > 30) 
                           || reparaciones.estadoReparacion == estadosReparacion.EnCurso)
                           select reparaciones;

                ucBG.cargarDGV(data.ToList());
            }
        }


        void btnAgregar(object sender, EventArgs e)
        {
            frmAgregarReparaciones frm = new frmAgregarReparaciones();
            frm.ShowDialog();
        }

        void btnModificar(object sender, EventArgs e)
        {
            DataGridViewRow fila = ucBG.getSelectedItem();

            using (MABEntities db = new MABEntities())
            {
                /**
                 * TODO: Revisar si tengo que castear value (yo me la juego que si)
                 */
                Models.Reparaciones reparacion = db.Reparaciones.Find(fila.Cells[0].Value);

                /**
                 * TODO: Tratar de forzar un reparacion == null. Solo para ver que ocurre aca.
                 */
                frmModificarReparacion frm = new frmModificarReparacion(reparacion.Id);
                frm.ShowDialog();
            }
        }

        private void verTodosReparacion(object sender, EventArgs e)
        {
            frmVerTodosReparaciones frm = new frmVerTodosReparaciones();
            frm.ShowDialog();
        }
    }
}
