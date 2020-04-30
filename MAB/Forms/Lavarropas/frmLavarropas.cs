using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAB.Forms.Lavarropas;
using MAB.Forms.Clientes;
using MAB.Models;
using MAB.Forms.CRUD.Reparaciones;

namespace MAB.Forms.CRUD.Lavarropas
{
    public partial class frmLavarropas : Form
    {
        private Models.Clientes cliente;

        public frmLavarropas(int? idCliente = null)
        {
            /**
             * TODO: Revisar su correcto funcionamiento
             * 
             */
            InitializeComponent();

            cargarLavarropas(idCliente);

            ucDGVTabla.click_btnAdd += btnAdd;
            ucDGVTabla.click_btnModify += btnModify;
            ucDGVTabla.click_btnSearch += btnSearch;

            ucDGVTabla.CellDoubleClick += dobleClick;

            crearCMS();
        }


        private void cargarLavarropas(int? idCliente)
        {
            if(idCliente != null)
            {
                using (MABEntities db = new MABEntities())
                {
                    var lavarropas = from lav in db.Lavarropas
                                     where lav.ClienteId == idCliente
                                     select lav;

                    ucDGVTabla.dataSource(lavarropas.ToList());

                    cliente = db.Clientes.Find(idCliente);

                    Text = "Lavarropas de: " + cliente.nombre + " " + cliente.apellido;
                }
            }
            else
            {
                using (MABEntities db = new MABEntities())
                {
                    cliente = null;

                    if(db.Lavarropas.ToList().LastOrDefault() != null)
                    {
                        int ultimoId = db.Lavarropas.ToList().LastOrDefault().Id;

                        var shortList = from lavarropas in db.Lavarropas
                                        where lavarropas.Id >= (ultimoId - 10)
                                        select new
                                        {
                                            lavarropas.Id,
                                            lavarropas.marca,
                                            lavarropas.modelo,
                                            lavarropas.estadoGeneral,
                                            cliente = lavarropas.Cliente.nombre + " " + lavarropas.Cliente.apellido,
                                        };

                        ucDGVTabla.ShortListData = shortList.ToList();
                    }

                    var fullList = from lavarropas in db.Lavarropas
                                   select new
                                   {
                                       lavarropas.Id,
                                       lavarropas.marca,
                                       lavarropas.modelo,
                                       lavarropas.estadoGeneral,
                                       cliente = lavarropas.Cliente.nombre + " " + lavarropas.Cliente.apellido,
                                   };

                    ucDGVTabla.FullListData = fullList.ToList();

                    Text = "Lavarropas";
                }
            }
        }

        private void abrirFormModify()
        {
            if (ucDGVTabla.selectedRow() != null)
            {
                int idLavarropas = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmModificarLavarropas frm = new frmModificarLavarropas(idLavarropas);
                frm.ShowDialog();

                if (cliente != null)
                {
                    cargarLavarropas(cliente.Id);
                }
                else
                {
                    cargarLavarropas(null);
                }
            }
        }

        private void crearCMS()
        {
            ToolStripMenuItem tsiVerCliente = new ToolStripMenuItem();
            tsiVerCliente.Name = "tsiVerCliente";
            tsiVerCliente.Size = new Size(148, 22);
            tsiVerCliente.Text = "Ver Cliente";
            tsiVerCliente.Click += verCliente;

            ToolStripSeparator tssSeparador = new ToolStripSeparator();
            tssSeparador.Name = "tssSeparador";
            tssSeparador.Size = new Size(145, 6);

            ToolStripMenuItem tsiVerReparaciones = new ToolStripMenuItem();
            tsiVerReparaciones.Name = "tsiVerReparaciones";
            tsiVerReparaciones.Size = new Size(148, 22);
            tsiVerReparaciones.Text = "Ver Reparaciones";
            tsiVerReparaciones.Click += verReparaciones;
            
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[]
            {
                tsiVerCliente,
                tssSeparador,
                tsiVerReparaciones,
            });
            cms.Name = "cmsDGV";

            ucDGVTabla.cargarCMS = cms;
        }

        #region Eventos de Botones

        private void btnAdd(object sender, EventArgs e)
        {
            if(cliente != null)
            {
                frmAgregarLavarropas frm = new frmAgregarLavarropas(cliente.Id);
                frm.ShowDialog();

                cargarLavarropas(cliente.Id);
            }
            else
            {
                MessageBox.Show(
                    "Se necesita un cliente para poder agregarle un Lavarropas al mismo. \n" +
                    "Es por este motivo que a continuacion se abrira una ventana para que pueda seleccionar uno.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();
                frmSeleccionarCliente.ShowDialog();

                int idCliente = frmSeleccionarCliente.ClienteSeleccionado;

                if(idCliente != -1)
                {
                    frmAgregarLavarropas frm = new frmAgregarLavarropas(idCliente);
                    frm.ShowDialog();
                }

                cargarLavarropas(null);
            }
        }

        private void btnModify(object sender, EventArgs e)
        {
            abrirFormModify();
        }

        private void btnSearch(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Existe 2 Maneras de buscar lavarropas. \n" +
                "1) Ver todos los lavarropas de un cliente en particular \n" +
                "2) Buscar un lavarropas dado su marca y modelo \n" +
                "¿Desea ver todos los lavarropas de un cliente en particular? \n" +
                "Al seleccionar no la busqueda se realizara por el segundo metodo.",
                "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(resp == DialogResult.Yes)
            {
                frmSeleccionarCliente frm = new frmSeleccionarCliente();
                frm.ShowDialog();

                int idCliente = frm.ClienteSeleccionado;

                if(idCliente != -1)
                {
                    using(MABEntities db = new MABEntities())
                    {
                        var lavarropas = from lav in db.Lavarropas
                                         where lav.ClienteId == idCliente
                                         select lav;

                        ucDGVTabla.dataSource(lavarropas.ToList());
                    }
                }
            }
            else
            {
                frmBuscarLavarropas frm = new frmBuscarLavarropas();
                frm.ShowDialog();

                if(frm.getResultados.Count != 0)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        List<Models.Lavarropas> lavarropas = new List<Models.Lavarropas>();

                        foreach(int id in frm.getResultados)
                        {
                            lavarropas.Add(db.Lavarropas.Find(id));
                        }

                        ucDGVTabla.dataSource(lavarropas);
                    }
                }
                else
                {
                    MessageBox.Show("La busqueda fue cancelada o no se encontraron resultados", 
                        "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #region Cell_DobleClick

        private void dobleClick(object sender, EventArgs e)
        {
            abrirFormModify();
        }

        #endregion

        #region EventosCMS

        private void verCliente(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idLavarropas = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                using(MABEntities db = new MABEntities())
                {
                    frmDetalleCliente frm = new frmDetalleCliente(db.Lavarropas.Find(idLavarropas).Cliente.Id);
                    frm.ShowDialog();

                    if (cliente != null)
                        cargarLavarropas(cliente.Id);
                    else
                        cargarLavarropas(null);
                }
            }
            else
            {
                MessageBox.Show(
                    "Debe seleccionar un lavarropas primero para luego poder ver su clientes", 
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        private void verReparaciones(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow()!= null)
            {
                int idLavarropas = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmReparaciones frm = new frmReparaciones(idLavarropas);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Debe seleccionar un lavarropas primero para luego poder ver sus Reparaciones",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        #endregion
    }
}
