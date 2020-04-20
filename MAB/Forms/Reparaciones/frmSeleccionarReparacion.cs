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
using MAB.Forms.CRUD.Reparaciones;
using MAB.Forms.Lavarropas;

namespace MAB.Forms.Reparaciones
{
    public partial class frmSeleccionarReparacion : Form
    {
        public frmSeleccionarReparacion(int idCliente)
        {
            InitializeComponent();

            cargarReparaciones(idCliente);

            ucBottom.Accion1 = "Seleccionar";
            ucBottom.Accion2 = "Buscar";
            ucBottom.Accion3 = "Nuevo";

            ucBottom.evAccion1 += seleccionarReparacion;
            ucBottom.evAccion2 += buscarReparacion;
            ucBottom.evAccion3 += nuevaReparacion;
        }

        Models.Clientes cliente;

        List<Models.Reparaciones> reparaciones;

        private void cargarReparaciones(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);

                reparaciones = (from rep in db.Reparaciones
                                where rep.Lavarropas.Cliente.Id == cliente.Id
                                select rep).ToList();
            }

            ucDGVTabla.dataSource(reparaciones);

            Text = "Seleccione una Reparacion del cliente " + cliente.nombre + " " + cliente.apellido;

            ucDGVTabla.Columns["mesesGarantia"].Visible = false;
            ucDGVTabla.Columns["reparacionRealizada"].Visible = false;
            ucDGVTabla.Columns["manoDeObra"].Visible = false;
            ucDGVTabla.Columns["totalRepuestos"].Visible = false;
            ucDGVTabla.Columns["LavarropasId"].Visible = false;
            ucDGVTabla.Columns["Lavarropas"].Visible = false;
            ucDGVTabla.Columns["Repuestos"].Visible = false;
            ucDGVTabla.Columns["Entregas"].Visible = false;
        }
        
        private int idReparacion = -1;

        public int obtenerSeleccion
        {
            get { return idReparacion; }
        }

        #region eventos del ucBottom

        private void seleccionarReparacion(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idReparacion = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Reparaciones reparacion = db.Reparaciones.Find(idReparacion);

                    DialogResult resp = MessageBox.Show(
                        "Ha seleccionado la Reparacion: \n" +
                        reparacion.Id + "\n" +
                        "Realizada al lavarropas: " + reparacion.Lavarropas.marca + " " + reparacion.Lavarropas.modelo + "\n" +
                        "Del Cliente: " + cliente.nombre + " " + cliente.apellido + "\n" +
                        "¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resp == DialogResult.Yes)
                    {
                        idReparacion = reparacion.Id;
                        this.Close();
                    }
                }
            }
        }

        private void buscarReparacion(object sender, EventArgs e)
        {
            frmBuscarReparacion frm = new frmBuscarReparacion();
            frm.ShowDialog();

            if (frm.getResultados.Count != 0)
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Reparaciones> reparaciones = new List<Models.Reparaciones>();

                    foreach (int id in frm.getResultados)
                    {
                        reparaciones.Add(db.Reparaciones.Find(id));
                    }

                    ucDGVTabla.dataSource(reparaciones);
                }
            }
            else
            {
                MessageBox.Show("La busqueda fue cancelada o no se encontraron resultados",
                        "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nuevaReparacion(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                    "Se necesita un lavarropas al cual poder agregarle una Reparacion \n" +
                    "Es por este motivo que a continuacion se abrira una ventana para que pueda seleccionar el \n" +
                    "Lavarropas al que quiere agregarle una reparacion.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmSeleccionarLavarropas frmSeleccionarLavarropas = new frmSeleccionarLavarropas();
            frmSeleccionarLavarropas.ShowDialog();

            int idLavarropas = frmSeleccionarLavarropas.lavarropasSeleccionado;

            if (idLavarropas != -1)
            {
                frmAgregarReparaciones frmAgregarReparaciones = new frmAgregarReparaciones(idLavarropas);
                frmAgregarReparaciones.ShowDialog();
            }

            cargarReparaciones(cliente.Id);
        }

        #endregion
    }
}
