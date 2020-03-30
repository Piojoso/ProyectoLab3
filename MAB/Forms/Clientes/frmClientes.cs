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

namespace MAB.Forms.CRUD.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();

            ucDGVTabla.click_btnAdd += btnAdd;
            ucDGVTabla.click_btnModify += btnModificar;
            ucDGVTabla.click_btnSearch += btnSearch;

            ucDGVTabla.DeleteVisibility = false;
            
            cargarDGV();
        }

        #region eventos de los botones;

        private void btnAdd(object sender, EventArgs e)
        {
            frmAgregarCliente frm = new frmAgregarCliente();
            frm.ShowDialog();
        }

        private void btnModificar(object sender, EventArgs e)
        {
            using (MABEntities db = new MABEntities())
            {
                int idCliente = Convert.ToInt32(ucDGVTabla.selectedRow()?.Cells["idCliente"].Value);

                frmModificarCliente frm = new frmModificarCliente(idCliente);
                frm.ShowDialog();

                cargarDGV();

            }
        }

        private void btnSearch(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.ShowDialog();

            if(frm.DialogResult != DialogResult.Cancel)
            {
                if(frm.idClientes != null && frm.idClientes.Count != 0)
                {
                    using(MABEntities db = new MABEntities())
                    {
                        List<Models.Clientes> c = new List<Models.Clientes>();

                        foreach (int id in frm.idClientes)
                        {
                            c.Add(db.Clientes.Find(id));
                        }

                        ucDGVTabla.dataSource(c);

                        Text = "Clientes - Resultado de Busqueda";
                    }
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

                if(ultimo != null)
                {
                    /**
                     * TODO: Probar si funciona cuando la DB tenga Clientes guardados
                     */
                    var data = from cliente in db.Clientes
                           where cliente.Id > (ultimo.Id - 10)
                           select cliente;

                    ucDGVTabla.ShortListData = clientes.ToList();

                    this.Text = "Clientes - Ultimos 10 Clientes agregados";
                }
                else
                {
                    ucDGVTabla.FullListData =  clientes.ToList();

                    this.Text = "Clientes - Todos los Clientes";
                }
            }
        }
    }
}
