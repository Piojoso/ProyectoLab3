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
using MAB.Forms.Telefonos;
using MAB.Forms.CRUD.Telefonos;
using MAB.Forms.Lavarropas;
using MAB.Forms.CRUD.Lavarropas;

namespace MAB.Forms.Clientes
{
    public partial class frmDetalleCliente : Form
    {
        private Models.Clientes cliente;

        public frmDetalleCliente(int idCliente)
        {
            InitializeComponent();

            cargarCliente(idCliente);

            ucBottom.Accion1 = "Modificar";
            ucBottom.Accion2 = "Cerrar";

            ucBottom.evAccion1 += modificarCliente;
            ucBottom.evAccion2 += cerrarVentana;
        }

        private void cargarCliente(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);

                cclblShowNumId.Text = cliente.Id.ToString();
                cclblShowNombre.Text = cliente.nombre;
                cclblShowApellido.Text = cliente.apellido;
                cclblShowDireccion.Text = cliente.direccion;
                cclblShowNumTelefonos.Text = cliente.Telefonos.Count.ToString();
                cclblShowNumLavarropas.Text = cliente.Lavarropas.Count.ToString();
            }

            Text = "Detalle del Cliente " + cliente.nombre + " " + cliente.apellido;
        }

        private void modificarCliente(object sender, EventArgs e)
        {
            frmModificarCliente frm = new frmModificarCliente(cliente.Id);
            frm.ShowDialog();

            cargarCliente(cliente.Id);
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerTelefonos_Click(object sender, EventArgs e)
        {
            frmTelefonos frm = new frmTelefonos(cliente.Id);
            frm.ShowDialog();

            cargarCliente(cliente.Id);
        }

        private void btnVerLavarropas_Click(object sender, EventArgs e)
        {
            frmLavarropas frm = new frmLavarropas(cliente.Id);
            frm.ShowDialog();

            cargarCliente(cliente.Id);
        }
    }
}
