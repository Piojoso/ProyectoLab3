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

                    DialogResult resp = MessageBox.Show(
                        "Ha seleccionado al Cliente: \n" +
                        cliente.nombre + " " + cliente.apellido + "\n" +
                        "¿Desea Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(resp == DialogResult.Yes)
                    {
                        idCliente = cliente.Id;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una fila seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        clientes.Add(db.Clientes.Find(id));
                    }

                    ucDGVTabla.dataSource(clientes);
                }
            }
            else
            {
                MessageBox.Show(
                    "La busqueda fue cancelada o no se encontraron resultados",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
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
