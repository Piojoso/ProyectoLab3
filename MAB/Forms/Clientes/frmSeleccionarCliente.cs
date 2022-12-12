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
using MAB.Forms.CRUD.Clientes;

namespace MAB.Forms.Clientes
{
    public partial class frmSeleccionarCliente : Form
    {
        public frmSeleccionarCliente()
        {
            /**
             * TODO: revisar el correcto funcionamiento
             */
            InitializeComponent();

            ucBottom.Accion1 = "Seleccionar";
            ucBottom.Accion2 = "Buscar";
            ucBottom.Accion3 = "Nuevo";

            ucBottom.evAccion1 += seleccionarCliente;
            ucBottom.evAccion2 += buscarCliente;
            ucBottom.evAccion3 += nuevoCliente;

            cargarLista();
        }

        private int idCliente = -1;

        public int ClienteSeleccionado
        {
            get { return idCliente; }
        }

        private void cargarLista()
        {
            using (MABEntities db = new MABEntities())
            {
                ucDGVTabla.dataSource(db.Clientes.ToList());
            }

            ucDGVTabla.Columns["Id"].Visible = false;
            ucDGVTabla.Columns["Telefonos"].Visible = false;
            ucDGVTabla.Columns["Lavarropas"].Visible = false;
            ucDGVTabla.Columns["Entregas"].Visible = false;
        }

        #region Eventos de ucBottom

        private void seleccionarCliente(object sender, EventArgs e)
        {
            if(ucDGVTabla.selectedRow() != null)
            {
                using (MABEntities db = new MABEntities())
                {
                    Models.Clientes cliente = db.Clientes.Find(Convert.ToInt32(ucDGVTabla.selectedRow().Cells["Id"].Value));
                    
                    idCliente = cliente.Id;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarCliente(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.ShowDialog();

            if(frm.idClientes != null && frm.idClientes.Count != 0)
            {
                List<int> idClientes = frm.idClientes;
                List<Models.Clientes> clientes = new List<Models.Clientes>();

                using (MABEntities db = new MABEntities())
                {
                    foreach(int id in idClientes)
                    {
                        var cliente = db.Clientes.Find(id);

                        if (!clientes.Contains(cliente))
                        {
                            clientes.Add(cliente);
                        }
                    }

                    ucDGVTabla.dataSource(clientes);
                }
            }
        }

        private void nuevoCliente(object sender, EventArgs e)
        {
            frmAgregarCliente frm = new frmAgregarCliente();
            frm.ShowDialog();

            cargarLista();
        }

        #endregion
    }
}
