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

namespace MAB.Forms.CRUD.Clientes
{
    public partial class frmModificarCliente : Form
    {
        Models.Clientes cliente;

        public frmModificarCliente(int idCliente)
        {
            InitializeComponent();

            cargarCliente(idCliente);

            ucTop.Titulo = "Modificar Cliente";

            ucBottom.NumButtons = 2;

            ucBottom.Accion1 = "Confirmar";
            ucBottom.Accion3 = "Cancelar";

            ucBottom.evAccion1 += confirmarCambios;
            ucBottom.evAccion3 += cancelarModificacion;

            cargarDatos();
        }

        private void cargarCliente(int idCliente)
        {
            using (MABEntities db = new MABEntities())
            {
                cliente = db.Clientes.Find(idCliente);
            }
        }

        private void cargarDatos()
        {
            cctbNombre.Text = cliente.nombre;
            cctbApellido.Text = cliente.apellido;
            cctbDireccion.Text = cliente.direccion;
            cclblNumTelefonos.Text = cliente.Telefonos.Count.ToString();
        }

        private void confirmarCambios(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea continuar con la modificacion?" + Environment.NewLine +
                "Tenga en cuenta que perdera la informacion anterior", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                using (MABEntities db = new MABEntities())
                {
                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
            }
        }

        private void cancelarModificacion(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmTelefonos frm = new frmTelefonos(cliente.Id);
            frm.ShowDialog();

            refreshNumTelefonos();
        }

        private void refreshNumTelefonos()
        {
            using (MABEntities db = new MABEntities())
            {
                cclblNumTelefonos.Text = cliente.Telefonos.Count.ToString();
            }
        }
    }
}
