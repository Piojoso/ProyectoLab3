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
        public frmVerTodosCliente(List<int> idClientes = null)
        {
            InitializeComponent();

            ucBG.Titulo = "Clientes";

            ucBG.Accion1 = "Buscar";
            ucBG.Accion2 = "Modificar";
            ucBG.Accion3 = "Cerrar";

            ucBG.evAccion1 += buscarCliente;
            ucBG.evAccion2 += modificarCliente;
            ucBG.evAccion3 += cerrarVentana;

            cargarDGV(idClientes);
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

        }

        private void modificarCliente(object sender, EventArgs e)
        {

        }

        private void cerrarVentana(object sender, EventArgs e)
        {

        }
    }
}
