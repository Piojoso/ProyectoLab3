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
    public partial class frmVerTodosCliente : Form
    {
        public frmVerTodosCliente()
        {
            InitializeComponent();

            ucBG.Titulo = "Clientes";

            ucBG.Accion1 = "Buscar";
            ucBG.Accion2 = "Modificar";
            ucBG.Accion3 = "Cerrar";

            ucBG.evAccion1 += buscarCliente;
            ucBG.evAccion2 += modificarCliente;
            ucBG.evAccion3 += cerrarVentana;

            cargarDGV();
        }

        private void cargarDGV(List<int> idCliente = null)
        {
            if(idCliente == null)
            {
                using (MABEntities db = new MABEntities())
                {
                    var data = db.Clientes;

                    ucBG.cargarDGV(data.ToList());
                }
            }
            else
            {
                foreach(int id in idCliente)
                {
                    using (MABEntities db = new MABEntities())
                    {
                        var data = from cliente in db.Clientes
                                   where cliente.Id == id
                                   select cliente;

                        ucBG.cargarDGV(data.ToList());
                    }
                }
            }
        }

        private void buscarCliente(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.ShowDialog();

            if(frm.DialogResult != DialogResult.Cancel)
            {
                cargarDGV(frm.idClientes);
            }
        }

        private void modificarCliente(object sender, EventArgs e)
        {
            // ERROR AL USAR si no hay una fila seleccionada
            DataGridViewRow fila = ucBG.getSelectedItem();

            using (MABEntities db = new MABEntities())
            {
                // ATENTO A ESTO... CREO QUE DEBERIA CONVERTIR EL VALUE A INT PARA EL FIND()
                // TAMBIEN TENGO ESTE POSIBLE PROBLEMA EN LOS TELEFONOS
                Models.Clientes cliente = db.Clientes.Find(fila.Cells[0].Value);

                frmModificarCliente frm = new frmModificarCliente(cliente.Id);
                frm.ShowDialog();

                cargarDGV();
            }
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
