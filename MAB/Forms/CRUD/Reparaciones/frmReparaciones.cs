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
            using (MABEntities db = new MABEntities())
            {
                var data = from reparaciones in db.Reparaciones
                           where ((DateTime.Now - reparaciones.fechaIngreso).Days > 30) 
                           || reparaciones.estadoReparacion == estadosReparacion.EnCurso
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
            MessageBox.Show("Hello World");
        }

        private void verTodosReparacion(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario no Disponible");
        }
    }
}
