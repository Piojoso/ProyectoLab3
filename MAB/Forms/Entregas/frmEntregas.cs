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
using MAB.Forms.Reparaciones;
using MAB.Forms.Clientes;

namespace MAB.Forms.Entregas
{
    public partial class frmEntregas : Form
    {
        public frmEntregas(int? idReparacion = null, int? idCliente = null)
        {
            InitializeComponent();

            cargarEntregas(idReparacion, idCliente);

            ucDGVTabla.Columns["ClientesId"].Visible = false;
            ucDGVTabla.Columns["ReparacionesId"].Visible = false;
            ucDGVTabla.Columns["Clientes"].Visible = false;
            ucDGVTabla.Columns["Reparaciones"].Visible = false;

            ucBottom.Accion1 = "Agregar";
            ucBottom.Accion2 = "Modificar";
            ucBottom.Accion3 = "Cerrar";

            ucBottom.evAccion1 += agregarEntrega;
            ucBottom.evAccion2 += modificarEntrega;
            ucBottom.evAccion3 += cerrarVentana;

            ucDGVTabla.CellDoubleClick += modificarEntrega;

            cargarCMS();
        }

        Models.Clientes cliente;
        Models.Reparaciones reparacion;

        List<Models.Entregas> entregas;

        private void cargarEntregas(int? idReparacion, int? idCliente)
        {
            if(idReparacion != null && idCliente == null)
            {
                using (MABEntities db = new MABEntities())
                {
                    reparacion = db.Reparaciones.Find(idReparacion);

                    cliente = reparacion.Lavarropas.Cliente;

                    entregas = reparacion.Entregas.ToList();
                }

                Text = "Entregas de la reparacion: " + reparacion.Id;

                ucDGVTabla.dataSource(entregas);
            }
            else if(idReparacion == null && idCliente != null)
            {
                using(MABEntities db = new MABEntities())
                {
                    cliente = db.Clientes.Find(idCliente);

                    entregas = cliente.Entregas.ToList();
                }

                Text = "Entregas del cliente: " + cliente.nombre + " " + cliente.apellido;

                ucDGVTabla.dataSource(entregas);
            }
        }

        #region eventos de ucBottom

        private void agregarEntrega(object sender, EventArgs e)
        {
            if(cliente != null)
            {
                MessageBox.Show(
                    "Se requiere seleccionar una reparacion a la cual agregarle la nueva entrega. \n" +
                    "Por este motivo a continuacion se abrira una ventana para que pueda seleccionar una reparacion.");

                frmSeleccionarReparacion frm = new frmSeleccionarReparacion(cliente.Id);
                frm.ShowDialog();

                if(frm.obtenerSeleccion != -1)
                {
                    int idReparacion = frm.obtenerSeleccion;

                    frmAgregarEntrega crearEntrega = new frmAgregarEntrega(idReparacion);
                    frm.ShowDialog();

                    cargarEntregas(null, cliente.Id);
                }
            }
            else
            {
                frmAgregarEntrega frm = new frmAgregarEntrega(reparacion.Id);
                frm.ShowDialog();

                cargarEntregas(reparacion.Id, null);
            }
        }

        private void modificarEntrega(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idEntrega = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using (MABEntities db = new MABEntities())
                {
                    Models.Entregas entrega = db.Entregas.Find(idEntrega);
                    
                    frmModificarEntrega frm = new frmModificarEntrega(idEntrega);
                    frm.ShowDialog();
                }

                if (cliente != null)
                    cargarEntregas(null, cliente.Id);
                else
                    cargarEntregas(reparacion.Id, null);
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void cargarCMS()
        {
            ToolStripMenuItem tsiVerReparacion = new ToolStripMenuItem();
            tsiVerReparacion.Name = "tsiVerReparacion";
            tsiVerReparacion.Size = new Size(148, 22);
            tsiVerReparacion.Text = "Ver Reparacion";
            tsiVerReparacion.Click += verReparacion;

            ToolStripMenuItem tsiVerCliente = new ToolStripMenuItem();
            tsiVerCliente.Name = "tsiVerCliente";
            tsiVerCliente.Size = new Size(148, 22);
            tsiVerCliente.Text = "Ver Cliente";
            tsiVerCliente.Click += verCliente;

            ContextMenuStrip cms = new ContextMenuStrip();

            cms.Items.AddRange(new ToolStripItem[]{
                tsiVerReparacion,
                tsiVerReparacion
            });

            cms.Name = "cmsDGV";

            ucDGVTabla.cargarCMS = cms;
        }

        #region eventos de CMS

        private void verReparacion(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idEntrega = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using(MABEntities db = new MABEntities())
                {
                    Models.Entregas ent = db.Entregas.Find(idEntrega);

                    frmDetalleReparacion frm = new frmDetalleReparacion(ent.Reparaciones.Id);
                    frm.ShowDialog();
                }
            }

            if (cliente != null)
                cargarEntregas(null, cliente.Id);
            else
                cargarEntregas(reparacion.Id, null);
        }

        private void verCliente(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idEntrega = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using(MABEntities db = new MABEntities())
                {
                    Models.Entregas ent = db.Entregas.Find(idEntrega);

                    frmDetalleCliente frm = new frmDetalleCliente(ent.Clientes.Id);
                    frm.ShowDialog();    
                }
            }

            if (cliente != null)
                cargarEntregas(null, cliente.Id);
            else
                cargarEntregas(reparacion.Id, null);
        }

        #endregion
    }
