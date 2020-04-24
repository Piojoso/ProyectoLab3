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
using MAB.Forms.Lavarropas;
using MAB.Forms.Reparaciones;

namespace MAB.Forms.CRUD.Reparaciones
{
    public partial class frmReparaciones : Form
    {
        public frmReparaciones(int? idLavarropas = null)
        {
            /**
             * TODO: Revisar el correcto funcionamiento
             */

            InitializeComponent();
            
            cargarDGV(idLavarropas);

            ucDGVTabla.click_btnAdd += btnAgregar;
            ucDGVTabla.click_btnModify += btnModificar;
            ucDGVTabla.click_btnSearch += btnBuscar;
            
            ucDGVTabla.Columns["mesesGarantia"].Visible = false;
            ucDGVTabla.Columns["reparacionRealizada"].Visible = false;
            ucDGVTabla.Columns["manoDeObra"].Visible = false;
            ucDGVTabla.Columns["totalRepuestos"].Visible = false;
            ucDGVTabla.Columns["LavarropasId"].Visible = false;
            ucDGVTabla.Columns["Lavarropas"].Visible = false;
            ucDGVTabla.Columns["Repuestos"].Visible = false;
            ucDGVTabla.Columns["Entregas"].Visible = false;

            ucDGVTabla.CellDoubleClick += btnModificar;

            crearCMS();
        }

        private Models.Lavarropas lavarropas;

        private void cargarDGV(int? idLavarropas)
        {
            if(idLavarropas != null)
            {
                using (MABEntities db = new MABEntities())
                {
                    lavarropas = db.Lavarropas.Find(idLavarropas);

                    var data = from reparaciones in db.Reparaciones
                               where reparaciones.LavarropasId == lavarropas.Id
                               select reparaciones;

                    ucDGVTabla.dataSource(data.ToList());
                }

                Text = "Reparaciones del Lavarropas " + lavarropas.marca + lavarropas.modelo;
            }
            else
            {
                using (MABEntities db = new MABEntities())
                {
                    lavarropas = null;

                    var shortList = from reparaciones in db.Reparaciones
                               where reparaciones.estadoReparacion == estadosReparacion.EnCurso
                               select reparaciones;

                    ucDGVTabla.ShortListData = shortList.ToList();

                    var fullList = db.Reparaciones;

                    ucDGVTabla.FullListData = fullList.ToList();
                    
                }

                Text = "Reparaciones";
            }
        }

        private void crearCMS()
        {
            /**
             * TODO: agregar opcion de finalizarReparacion, el cual marcara la reparacion como finalizada y le pondra la
             * informacion necesaria por defecto.
             * --- HECHO
             */

            ToolStripMenuItem tsmiFinalizar = new ToolStripMenuItem();
            tsmiFinalizar.Name = "tsmiFinalizar";
            tsmiFinalizar.Size = new Size(148, 22);
            tsmiFinalizar.Text = "Marcar Reparacion como Finalizada";
            tsmiFinalizar.Click += finalizarReparacion;

            ToolStripSeparator tssSeparador = new ToolStripSeparator();
            tssSeparador.Name = "tssSeparador";
            tssSeparador.Size = new Size(145, 6);

            ToolStripMenuItem tsiVerLavarropas = new ToolStripMenuItem();
            tsiVerLavarropas.Name = "tsiVerLavarropas";
            tsiVerLavarropas.Size = new Size(148, 22);
            tsiVerLavarropas.Text = "Ver Lavarropas";
            tsiVerLavarropas.Click += verLavarropas;

            ToolStripMenuItem tsiVerDetalle = new ToolStripMenuItem();
            tsiVerDetalle.Name = "tsiVerDetalle";
            tsiVerDetalle.Size = new Size(148, 22);
            tsiVerDetalle.Text = "Ver Detalle";
            tsiVerDetalle.Click += verDetalle;

            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[]
            {
                tsmiFinalizar,
                tssSeparador,
                tsiVerLavarropas,
                tsiVerDetalle,
            });
            cms.Name = "cmsDGV";

            ucDGVTabla.cargarCMS = cms;
        }

        #region Eventos de Botones

        private void btnAgregar(object sender, EventArgs e)
        {
            if (lavarropas != null)
            {
                frmAgregarReparaciones frm = new frmAgregarReparaciones(lavarropas.Id);
                frm.ShowDialog();

                cargarDGV(lavarropas.Id);
            }
            else
            {
                DialogResult resp = MessageBox.Show(
                    "Se necesita un lavarropas al cual poder agregarle una Reparacion \n" +
                    "Es por este motivo que a continuacion se abrira una ventana para que pueda seleccionar el \n" +
                    "Lavarropas al que quiere agregarle una reparacion.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSeleccionarLavarropas frmSeleccionarLavarropas = new frmSeleccionarLavarropas();
                frmSeleccionarLavarropas.ShowDialog();

                int idLavarropas = frmSeleccionarLavarropas.lavarropasSeleccionado;
                
                if(idLavarropas != -1)
                {
                    frmAgregarReparaciones frmAgregarReparaciones = new frmAgregarReparaciones(lavarropas.Id);
                    frmAgregarReparaciones.ShowDialog();
                }

                cargarDGV(null);
            }
        }

        private void btnModificar(object sender, EventArgs e)
        {
            if (ucDGVTabla.selectedRow() != null)
            {
                int idReparacion = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmModificarReparacion frm = new frmModificarReparacion(idReparacion);
                frm.ShowDialog();

                if (lavarropas != null)
                {
                    cargarDGV(lavarropas.Id);
                }
                else
                {
                    cargarDGV(null);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna Reparacion seleccionada.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar(object sender, EventArgs e)
        {
            frmBuscarReparacion frm = new frmBuscarReparacion();
            frm.ShowDialog();

            if(frm.getResultados.Count != 0)
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Reparaciones> reparaciones = new List<Models.Reparaciones>();

                    foreach(int id in frm.getResultados)
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

        #endregion

        #region eventos de CMS

        private void finalizarReparacion(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idReparacion = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Reparaciones reparacion = db.Reparaciones.Find(idReparacion);

                    if(reparacion.estadoReparacion == estadosReparacion.EnCurso)
                    {
                        frmFinalizarReparacion frm = new frmFinalizarReparacion(idReparacion);
                        frm.ShowDialog();
                    }
                    else
                    {
                         DialogResult resp = MessageBox.Show(
                            "Esta reparacion ya fue finalizada. \n" +
                            "¿Desea modificarla?", "Imposible de Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if(resp == DialogResult.Yes)
                        {
                            frmModificarReparacion frm = new frmModificarReparacion(idReparacion);
                            frm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada para ser Finalizada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void verLavarropas(object sender, EventArgs e) 
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idReparacion = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Reparaciones reparacion = db.Reparaciones.Find(idReparacion);

                    frmDetalleLavarropas frm = new frmDetalleLavarropas(reparacion.Lavarropas.Id);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "Debe seleccionar una Reparacion primero para luego poder ver el Lavarropas al que se realizo.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        private void verDetalle(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idReparacion = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);
                
                frmDetalleReparacion frm = new frmDetalleReparacion(idReparacion);
                frm.ShowDialog();

                cargarDGV(lavarropas.Id);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una reparacion para poder ver el detalle.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
