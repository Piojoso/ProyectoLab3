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
using MAB.Forms.CRUD.Telefonos;
using MAB.Forms.CRUD.Lavarropas;
using MAB.Forms.Clientes;

namespace MAB.Forms.CRUD.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            /**
             * TODO: probar correcto funcionamiento
             * 
             */

            InitializeComponent();
            
            this.Text = "Clientes";

            ucDGVTabla.click_btnAdd += btnAdd;
            ucDGVTabla.click_btnModify += btnModificar;
            ucDGVTabla.click_btnSearch += btnSearch;

            ucDGVTabla.CellDoubleClick += dobleClick;

            cargarDGV();

            creacionCMS();
        }

        #region eventos de los botones;

        private void btnAdd(object sender, EventArgs e)
        {
            frmAgregarCliente frm = new frmAgregarCliente();
            frm.ShowDialog();

            cargarDGV();
        }

        private void btnModificar(object sender, EventArgs e)
        {
            abrirFrmModificar();

            cargarDGV();
        }

        private void btnSearch(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.ShowDialog();
            
            if (frm.idClientes != null && frm.idClientes.Count != 0)
            {
                using (MABEntities db = new MABEntities())
                {
                    List<Models.Clientes> c = new List<Models.Clientes>();

                    foreach (int id in frm.idClientes)
                    {
                        var cliente = db.Clientes.Find(id);

                        if (!c.Contains(cliente))
                        {
                            c.Add(cliente);
                        }
                    }

                    ucDGVTabla.dataSource(c);
                }
            }
        }

        #endregion

        private void cargarDGV()
        {
            using (MABEntities db = new MABEntities())
            {
                var clientes = db.Clientes;
                var ultimo = clientes.ToList().LastOrDefault();

                if (ultimo != null)
                {
                    var data = from cliente in db.Clientes
                               where cliente.Id > (ultimo.Id - 10)
                               select cliente;

                    ucDGVTabla.ShortListData = clientes.ToList();
                }
                else
                {
                    ucDGVTabla.FullListData = clientes.ToList();
                }

                ucDGVTabla.Columns["Id"].Visible = false;
                ucDGVTabla.Columns["Telefonos"].Visible = false;
                ucDGVTabla.Columns["Lavarropas"].Visible = false;
                ucDGVTabla.Columns["Entregas"].Visible = false;
            }
        }

        private void abrirFrmModificar()
        {
            if (ucDGVTabla.selectedRow() != null)
            {
                int idCliente = Convert.ToInt32(ucDGVTabla.selectedRow()?.Cells["id"].Value);

                frmModificarCliente frm = new frmModificarCliente(idCliente);
                frm.ShowDialog();

                cargarDGV();
            }
        }

        #region DobleClick sobre una celda en DGV

        private void dobleClick(object sender, EventArgs e)
        {
            abrirFrmModificar();
        }

        #endregion

        private void creacionCMS()
        {
            ToolStripMenuItem tsiVerTelefonos = new ToolStripMenuItem();
            tsiVerTelefonos.Name = "tsiVerTelefono";
            tsiVerTelefonos.Size = new Size(148, 22);
            tsiVerTelefonos.Text = "Ver Telefonos";
            tsiVerTelefonos.Click += verTelefonos;

            ToolStripMenuItem tsiVerLavarropas = new ToolStripMenuItem();
            tsiVerLavarropas.Name = "tsiVerLavarropas";
            tsiVerLavarropas.Size = new Size(148, 22);
            tsiVerLavarropas.Text = "Ver Lavarropas";
            tsiVerLavarropas.Click += verLavarropas;

            ToolStripSeparator tssSeparador = new ToolStripSeparator();
            tssSeparador.Name = "tssSeparador";
            tssSeparador.Size = new Size(145, 6);

            ToolStripMenuItem tsiVerDetalle = new ToolStripMenuItem();
            tsiVerDetalle.Name = "tsiVerDetalle";
            tsiVerDetalle.Size = new Size(148, 22);
            tsiVerDetalle.Text = "Ver Detalle";
            tsiVerDetalle.Click += verDetalle;

            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.AddRange(new ToolStripItem[]
            {
                tsiVerTelefonos,
                tsiVerLavarropas,
                tssSeparador,
                tsiVerDetalle,
            });
            cms.Name = "cmsDGV";

            ucDGVTabla.cargarCMS = cms;
        }

        #region Eventos CMS

        private void verTelefonos(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idCliente = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmTelefonos frm = new frmTelefonos(idCliente);
                frm.ShowDialog();
            }            
        }

        private void verLavarropas(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idCliente = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmLavarropas frm = new frmLavarropas(idCliente);
                frm.ShowDialog();

                cargarDGV();
            }
        }

        private void verDetalle(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                int idCliente = Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value);

                frmDetalleCliente frm = new frmDetalleCliente(idCliente);
                frm.ShowDialog();

                cargarDGV();
            }
        }

        #endregion
    }
}
