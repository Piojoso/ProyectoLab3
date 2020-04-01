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
            /**
             * TODO: Modificar form para que deje de ser ver todos los clientes y pase a ser un verDetalleCliente para poder ver
             *      info detallada del cliente. (Todos los lavarropas que tiene, telefonos, etc.);
             */
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
            if(idCliente == null) // Significa que se quiere ver todos los clientes
            {
                using (MABEntities db = new MABEntities())
                {
                    var data = db.Clientes;

                    ucBG.cargarDGV(data.ToList());
                }
            }
            else
            {
                foreach(int id in idCliente) // Significa que se quiere ver el resultado de una busqueda
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
            /**
             * TODO: Arreglar Error de null al no seleccionar una fila
             */
            DataGridViewRow fila = ucBG.getSelectedItem();

            using (MABEntities db = new MABEntities())
            {
                /**
                 * TODO: Revisar el funcionamiento de esta funcion.
                 * Puede que al mandarle un object, la funcion find, realize otra cosa que no sea la que yo deseo.
                 * En tal caso, la posible solucion seria convetir el value a int.Para que asi busque por id.
                 */
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
